using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Model.QLHSC07_Dtos.Records
{
    public class FilterRecordsDto : PagedAndSortResultRequestDto
    {
        public string Keyword { get; set; }
        public long? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string InvestorName { get; set; }
        public string Address { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long? RecordsTypeId { get; set; }
        public string ReceiveUserName { get; set; }
        public long? PC07ReceiveId { get; set; }
        public long? PC07ManageId { get; set; }
        public long? RecordsStatusId { get; set; }
        public long? DocumentAnsTypeId { get; set; }
        public long? ProvinceId { get; set; }
        public long? ProjectTypeId { get; set; }
        public bool? IsNewProject { get; set; }
    }
}
