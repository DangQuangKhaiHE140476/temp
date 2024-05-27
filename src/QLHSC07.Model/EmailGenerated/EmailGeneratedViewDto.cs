using System;
using System.ComponentModel;

namespace QLHSC07.Model.EmailGenerated
{
    public class EmailGeneratedViewDto
    {
        public long Id { get; set; }
        public string EmailType { get; set; }
        public int Status { get; set; }
        public DateTime SentDate { get; set; }
        public string ErrorMessage { get; set; }
        [DisplayName("ReferenceTypeName")]
        public string ReferenceTypeName { get; set; }
        public int ReferenceTypeId { get; set; }
        public int ReferenceNumber { get; set; }
        public string Title { get; set; }
        public string SendFrom { get; set; }
        [DisplayName("StatusSendMail")]
        public string StatusSendMail { get; set; }
    }
}
