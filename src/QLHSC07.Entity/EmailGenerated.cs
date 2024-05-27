using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Enum;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity
{
    [Table(TableFieldNameHelper.Sys.EmailGenerated, Schema = Constant.Schema.SYS)]
    public class EmailGenerated
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("email_type")]
        public string EmailType { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("sent_date")]
        public DateTime SentDate { get; set; }
        [Column("error_message")]
        public string ErrorMessage { get; set; }
        [Column("reference_type")]
        public int ReferenceTypeId { get; set; }
        [Column("reference_number")]
        public int ReferenceNumber { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("send_to")]
        public string SendTo { get; set; }
        [Column("cc")]
        public string CC { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("subject")]
        public string Subject { get; set; }
        [Column("send_from")]
        public string SendFrom { get; set; }
        [Column("user_name")]
        public string UserName { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("message")]
        public string Message { get; set; }
        [Column("is_replied")]
        public bool IsReplied { get; set; }
        public virtual ReferenceType ReferenceType { get; set; }
        public string GetReferenceTypeName()
        {
            return ReferenceType.Name;
        }

        public string GetStatusSendMail()
        {
            return Status == EmailGenerateStatusEnum.Success.GetHashCode() ? "Success" : "Failure";
        } 
    }
}
