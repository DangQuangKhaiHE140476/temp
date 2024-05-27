using System;

namespace QLHSC07.Model.EmailGenerated
{
    public class CreateEmailGeneratedDto
    {
        public long Id { get; set; }
        public string EmailType { get; set; }
        public int Status { get; set; }
        public DateTime SentDate { get; set; }
        public string ErrorMessage { get; set; }
        public int ReferenceTypeId { get; set; }
        public int ReferenceNumber { get; set; }
        public string Title { get; set; }
        public string SendTo { get; set; }
        public string CC { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string SendFrom { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool IsReplied { get; set; }
    }
}
