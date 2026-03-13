using LibCompresionLogs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibCompresionLogs.Controladores
{
    public static class ConfigService
    {
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public static Configuration Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new Configuration
                {
                    MonthsToKeep = 3,
                    DayToExecute = 1,
                    DefaultExtensions = new List<string> { ".log" }
                };
            }

            try
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Configuration>(json, _options) ?? new Configuration();
            }
            catch
            {
                return new Configuration();
            }
        }
        public static void Save(string filePath, Configuration config) { 
            string? directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory)) { 
                Directory.CreateDirectory(directory);
            }

            string json = JsonSerializer.Serialize(config, _options);
            File.WriteAllText(filePath, json);

        }
    }
}
