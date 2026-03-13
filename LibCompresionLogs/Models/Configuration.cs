using System.Collections.Generic;

namespace LibCompresionLogs.Models
{
    public class Configuration
    {
        public int MonthsToKeep { get; set; } = 3;
        public int DayToExecute { get; set; } = 1;
        public string DestinationPath { get; set; } = string.Empty;
        public List<MonitoringFolder> MonitoringFolders { get; set; } = new List<MonitoringFolder>();
        public List<string> DefaultExtensions { get; set; } = new List<string> { ".log" };
    }
}