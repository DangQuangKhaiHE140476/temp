using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Records
{
    public class RecordInfoAtLocalDto
    {
        public string LocalName { get; set; }
        public int TotalRecord { get; set; }
        public int RecordSolved { get; set; }
        public int RecordBeforeDeadLine { get; set; }
        public int RecordOnTime { get; set; }
        public int RecordOutOfDate { get; set; }
        public int RecordProcessing { get; set; }
        public string PercenOnTime { get; set; }
    }

    public class RecordInfoAtLocalPrepairDto
    {
        public long? Id { get; set; }
        public string LocalName { get; set; }
        public long? RecordsStatusId { get; set; }
        public long? RecordsId { get; set; }
        public DateTime? DateRealReturn { get; set; }
        public DateTime? DatePredictReturn { get; set; }
    }
}
