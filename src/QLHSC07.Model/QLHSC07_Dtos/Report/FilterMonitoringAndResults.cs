using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Report
{
    public class FilterMonitoringAndResults
    {
        public int? RecordTypeId { get; set; }
        public int? ProjectTypeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? GroupProjectId { get; set; }
        public long? PC07ManageId { get; set; }
    }
}
