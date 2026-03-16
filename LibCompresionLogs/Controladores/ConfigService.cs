using LibCompresionLogs.Models;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace LibCompresionLogs.Controladores
{
    public static class ConfigService
    {
        private static Configuration? _instance;
        private static readonly object _lock = new object();
        private static readonly string _configPath = @"C:\CompresionLogs\config.json";

        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public static Configuration Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = Load();
                        }
                    }
                }
                return _instance;
            }
        }

        private static Configuration Load()
        {
            if (!File.Exists(_configPath))
            {
                return new Configuration
                {
                    MonthsToKeep = 3,
                    DayToExecute = 1,
                    MonitoringFolders = new List<MonitoringFolder>(),
                    ZipLifeTimeMonths = 0,
                    DefaultExtensions = new List<string>() { ".log"}
                };
            }

            try
            {
                string json = File.ReadAllText(_configPath);
                return JsonSerializer.Deserialize<Configuration>(json, _options) ?? new Configuration();
            }
            catch
            {
                return new Configuration();
            }
        }

        public static void Save()
        {
            string? directory = Path.GetDirectoryName(_configPath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json = JsonSerializer.Serialize(Instance, _options);
            File.WriteAllText(_configPath, json);
        }
    }
}
