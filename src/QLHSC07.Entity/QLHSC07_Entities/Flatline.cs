using QLHSC07.CORE.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.Flatline, Schema = Constant.Schema.QLHSC07)]
    public class Flatline : BaseFullAuditedEntity<long>
    {
        public long? RecordId { get; set; }
        public long? ProjectId { get; set; }
        public string RecordNum { get; set; }
        public string ProjectName { get; set; }
        public string InvestorName { get; set; }
        public string RecordTypeName { get; set; }
        public string ReceptionForm { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string ReceiveUserName { get; set; }
        public DateTime? DatePredictReturn { get; set; }
        public DateTime? DateRealReturn { get; set; }
        public string PC07ReceiveName { get; set; }
        public string Address { get; set; }
        public string Positions { get; set; }
        public long? ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }
        public string ReturnDocNumb { get; set; }
        public long? RecordTypeId { get; set; }
        public bool? IsNewProject { get; set; }
        public long? GroupProjectId { get; set; }
        public long? PC07ManageId { get; set; }
    }
}
