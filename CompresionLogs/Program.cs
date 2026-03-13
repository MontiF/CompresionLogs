using LibCompresionLogs.Controladores;
using LibCompresionLogs.Models;
using SevenZip;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace CompresionLogs
{
    internal class Program
    {
        private static Configuration _config;
        private static readonly string _configPath = "C:\\CompresionLogs\\config.json";

        static void Main(string[] args)
        {
            SevenZipBase.SetLibraryPath(@"C:\Program Files\7-Zip\7z.dll");

            _config = ConfigService.Load(_configPath);

            if (!ComprobacionesPrevias(_config))
            {
                return;
            }

            if (!Directory.Exists(_config.DestinationPath))
            {
                Directory.CreateDirectory(_config.DestinationPath);
            }

            int nMonitoringFolders = _config.MonitoringFolders.Count;
            for (int i = 0; i < nMonitoringFolders; i++)
            {
                if (string.IsNullOrEmpty(_config.MonitoringFolders[i].Path) || !Directory.Exists(_config.MonitoringFolders[i].Path))
                {
                    Console.WriteLine("Error: La carpeta a monitorear no existe");
                    continue;
                }

                string pathFolder = _config.MonitoringFolders[i].Path;
                var archivosLog = Directory.EnumerateFiles(pathFolder, "*.log").ToList();

                if (archivosLog.Count > 0)
                {
                    try
                    {
                        string folderName = new DirectoryInfo(pathFolder).Name;
                        string fileName = $"{folderName}_{DateTime.Today:yyyyMMdd}.7z";
                        string pathSaveZip = Path.Combine(_config.DestinationPath, fileName);

                        SevenZipCompressor compressor = new SevenZipCompressor();
                        compressor.ArchiveFormat = OutArchiveFormat.SevenZip;
                        compressor.CompressionLevel = CompressionLevel.High;

                        compressor.CompressFiles(pathSaveZip, archivosLog.ToArray());

                        Console.WriteLine($"Archivo creado: {pathSaveZip} : ");

                        foreach (var log in archivosLog)
                        {
                            Console.Write($"| {Path.GetFileName(log)} | ");
                            try {
                                File.Delete(log); 
                            } catch { 
                                Console.WriteLine($"No se pudo borrar: {log}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"No se encontraron .log en {pathFolder}");
                }
            }
        }

        static bool ComprobacionesPrevias(Configuration _config)
        {
            if (!File.Exists(_configPath))
            {
                Console.WriteLine("Error: Debes realizar antes la configuracion");
                return false;
            }

            if (_config.MonitoringFolders == null || _config.MonitoringFolders.Count == 0)
            {
                Console.WriteLine("Error: Carpetas no configuradas");
                return false;
            }

            if (string.IsNullOrEmpty(_config.DestinationPath))
            {
                Console.WriteLine("Error: Destino no configurado");
                return false;
            }

            if (_config.DayToExecute != DateTime.Now.Day)
            {
                Console.WriteLine("Hoy no toca bro");
                return false;
            }

            return true;
        }
    }
}