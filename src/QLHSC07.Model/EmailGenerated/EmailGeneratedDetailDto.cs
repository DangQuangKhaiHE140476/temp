using System;
using System.ComponentModel;

namespace QLHSC07.Model.EmailGenerated
{
    public class EmailGeneratedDetailDto
    {
        public long Id { get; set; }
        [DisplayName("EmailType")]
        public string EmailType { get; set; }
        public int Status { get; set; }
        public DateTime SentDate { get; set; }
        public string ErrorMessage { get; set; }
        [DisplayName("ReferenceTypeName")]
        public string ReferenceTypeName { get; set; }
        public int ReferenceTypeId { get; set; }
        public int ReferenceNumber { get; set; }
        public string Title { get; set; }
        public string SendTo { get; set; }
        public string CC { get; set; }
        public string Description { get; set; }
        [DisplayName("Code")]
        public string Code { get; set; }
        public string Subject { get; set; }
        public string SendFrom { get; set; }
        [DisplayName("StatusSendMail")]
        public string StatusSendMail { get; set; }
    }
}
