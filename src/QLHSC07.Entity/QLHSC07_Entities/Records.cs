using QLHSC07.CORE.Helper;
using QLHSC07.Entity.IdentityAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLHSC07.Entity.QLHSC07_Entities
{
    [Table(TableFieldNameHelper.QLHSC07.Records, Schema = Constant.Schema.QLHSC07)]
    public class Records : BaseFullAuditedEntity<long>
    {
        [Column("project_id")]
        public long? ProjectId { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public Project Projects { get; set; }

        [Column("records_types_id")]
        public long? RecordsTypeId { get; set; }
        [ForeignKey(nameof(RecordsTypeId))]
        public RecordsType RecordsTypes { get; set; }

        /// <summary>
        /// Number of votes received
        /// </summary>
        [Column("record_num")]
        public string RecordNum { get; set; }
        
        /// <summary>
        /// Reception form
        /// </summary>
        [Column("receive_type_id")]
        public long? ReceiveTypeId { get; set; }
        [ForeignKey(nameof(ReceiveTypeId))]
        public ReceiveType ReceiveTypes { get; set; }

        [Column("receive_date")]
        public DateTime? ReceiveDate { get; set; }

        [Column("receive_user_name")]
        public string ReceiveUserName { get; set; }

        [Column("pc07_receive_id")]
        public long? PC07ReceiveId { get; set; }
        [ForeignKey(nameof(PC07ReceiveId))]
        public virtual PC07Local PC07Receive { get; set; }

        [Column("pc07_manage_id")]
        public long? PC07ManageId { get; set; }
        [ForeignKey(nameof(PC07ManageId))]
        public virtual PC07Local PC07Manage { get; set; }

        ///Number of reply texts
        [Column("predict_return_date")]
        public DateTime? DatePredictReturn { get; set; }

        [Column("date_real_return")]
        public DateTime? DateRealReturn { get; set; }
        
        [Column("date_predict_check")]
        public DateTime? DatePredictCheck { get; set; }

        [Column("result")]
        public bool? Result { get; set; }

        [Column("return_doc_numb")]
        public string ReturnDocNumb { get; set; }
        
        [Column("document_ans_type_id")]
        public long? DocumentAnsTypeId { get; set; }
        [ForeignKey(nameof(DocumentAnsTypeId))]
        public DocumentAnsType DocumentAnsType { get; set; }

        [Column("records_status_id")]
        public long? RecordsStatusId { get; set; }
        [ForeignKey(nameof(RecordsStatusId))]
        public RecordsStatus RecordsStatus { get; set; }
        
        [Column("is_new_project")]
        public bool? IsNewProject { get; set; }
        [Column("cancel_reason")]
        public string CancelReason { get; set; }  //Nếu statusId=4, thì có thêm field này

        public virtual ICollection<RecordsFile> RecordsFiles { get; set; }
    }
}
