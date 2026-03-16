using LibCompresionLogs.Controladores;
using LibCompresionLogs.Models;
using SevenZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FluentFTP;
using Renci.SshNet;

namespace CompresionLogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SevenZipBase.SetLibraryPath(@"C:\Program Files\7-Zip\7z.dll");

            var config = ConfigService.Instance;

            if (!ComprobacionesPrevias(config))
            {
                return;
            }

            if (!Directory.Exists(config.DestinationPath))
            {
                Directory.CreateDirectory(config.DestinationPath);
            }

            foreach (var folder in config.MonitoringFolders)
            {
                if (string.IsNullOrEmpty(folder.Path) || !Directory.Exists(folder.Path))
                {
                    Console.WriteLine($"Error: La carpeta {folder.Path} no existe");
                    continue;
                }

                int months = folder.MonthsToKeep ?? config.MonthsToKeep;
                DateTime fechaCorte = DateTime.Now.AddMonths(-months);

                List<string> todosLosArchivos = new List<string>();
                foreach (var extension in config.DefaultExtensions)
                {
                    var archivos = Directory.EnumerateFiles(folder.Path, $"*{extension}").Where(f =>
                    {
                        return File.GetLastWriteTime(f) <= fechaCorte;
                    }); todosLosArchivos.AddRange(archivos);
                }
                if (todosLosArchivos.Count > 0)
                {
                    try
                    {
                        string folderName = new DirectoryInfo(folder.Path).Name;
                        string fileName = $"{folderName}_{DateTime.Today:yyyyMMdd}.7z";
                        string pathSaveZip = Path.Combine(config.DestinationPath, fileName);

                        SevenZipCompressor compressor = new SevenZipCompressor
                        {
                            ArchiveFormat = OutArchiveFormat.SevenZip,
                            CompressionLevel = CompressionLevel.High
                        };

                        compressor.CompressFiles(pathSaveZip, todosLosArchivos.ToArray());
                        Console.WriteLine($"Archivo creado: {pathSaveZip}");

                        bool uploadSuccess = true;
                        if (!string.IsNullOrEmpty(config.FTPHost))
                        {
                            try
                            {
                                if (config.IsSFTP)
                                {
                                    using (var sftp = new SftpClient(config.FTPHost, config.FTPPort, config.FTPUser, config.FTPPass))
                                    {
                                        sftp.Connect();
                                        using (var fileStream = File.OpenRead(pathSaveZip))
                                        {
                                            sftp.UploadFile(fileStream, config.FTPPath + "/" + fileName);
                                        }
                                        sftp.Disconnect();
                                    }
                                }
                                else
                                {
                                    using (var ftp = new FtpClient(config.FTPHost, config.FTPUser, config.FTPPass, config.FTPPort))
                                    {
                                        ftp.Connect();
                                        ftp.UploadFile(pathSaveZip, config.FTPPath + "/" + fileName);
                                    }
                                }
                                Console.WriteLine("Transferencia completada con éxito.");
                            }
                            catch (Exception ftpEx)
                            {
                                Console.WriteLine($"Error FTP: {ftpEx.Message}");
                                uploadSuccess = false;
                            }
                        }

                        foreach (var archivo in todosLosArchivos)
                        {
                            try { File.Delete(archivo); }
                            catch { Console.WriteLine($"No se pudo borrar: {archivo}"); }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"No se encontraron losw archivos con las extensiones configuradas en {folder.Path}");
                }
            }
            if (config.ZipLifeTimeMonths != 0)
            {
                int lifeTimeMonths = config.ZipLifeTimeMonths;
                DateTime fechaCorteZip = DateTime.Now.AddMonths(-lifeTimeMonths);
                var zipsToDelete = Directory.EnumerateFiles(config.DestinationPath, "*.7z").Where(f =>
                {
                    return File.GetLastWriteTime(f) <= fechaCorteZip;
                }).ToList();

                foreach (var zip in zipsToDelete)
                {
                    try{
                        File.Delete(zip);
                        Console.WriteLine($"ZIP antiguo eliminado: {Path.GetFileName(zip)}");
                    }catch{
                        Console.WriteLine($"No se pudo eliminar el ZIP: {zip}");
                    }
                    
                }
            }
        }
        static bool ComprobacionesPrevias(Configuration config)
        {
            if (config.MonitoringFolders == null || config.MonitoringFolders.Count == 0)
            {
                Console.WriteLine("Error: Carpetas no configuradas");
                return false;
            }

            if (string.IsNullOrEmpty(config.DestinationPath))
            {
                Console.WriteLine("Error: Destino no configurado");
                return false;
            }

            if (config.DayToExecute != DateTime.Now.Day)
            {
                Console.WriteLine("Hoy no toca");
                return false;
            }

            return true;
        }
    }
}