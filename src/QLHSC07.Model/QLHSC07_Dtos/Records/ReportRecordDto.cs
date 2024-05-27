using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Records
{
    public class ReportRecordDto
    {
        public int Year { get; set; }
        public long? RecordTypeId { get; set; }
        public string RecordTypeName { get; set; }
        public string Percent { get; set; }
        public decimal PercentSort { get; set; }
        public int RecordSolvedNumber { get; set; }
        public int PercentOnTime { get; set; }
        public int PercentLate { get; set; }
        public int TotalRecord { get; set; }
    }
}
