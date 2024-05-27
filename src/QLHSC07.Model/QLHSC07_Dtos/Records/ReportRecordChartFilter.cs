using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Records
{
    public class ReportRecordChartFilter : PagedAndSortResultRequestDto
    {
        public long? RecordTypeId { get; set; }
        public int Year { get; set; }
        public long? PC07ManageId { get; set; }
    }
}
