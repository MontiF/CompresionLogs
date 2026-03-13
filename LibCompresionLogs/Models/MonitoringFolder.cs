using System;
using System.Collections.Generic;
using System.Text;

namespace LibCompresionLogs.Models
{
    public class MonitoringFolder
        {
            public string Path { get; set; } = string.Empty;
            public int? MonthsToKeep { get; set; }
        }
}
