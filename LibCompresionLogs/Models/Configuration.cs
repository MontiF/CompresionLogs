using System.Collections.Generic;

namespace LibCompresionLogs.Models
{
    public class Configuration
    {
        public int MonthsToKeep { get; set; } = 3;
        public int DayToExecute { get; set; } = 1;
        public string DestinationPath { get; set; } = string.Empty;
        public int ZipLifeTimeMonths { get; set; }
        public List<MonitoringFolder> MonitoringFolders { get; set; } = new List<MonitoringFolder>();
        public List<string> DefaultExtensions { get; set; } = new List<string> { ".log"};

        public string FTPHost { get; set; } = string.Empty;
        public int FTPPort { get; set; } = 21;
        public string FTPUser { get; set; } = string.Empty;
        public string FTPPass { get; set; } = string.Empty;
        public string FTPPath { get; set; } = string.Empty;
        public bool IsSFTP { get; set; } = false;
    }
}