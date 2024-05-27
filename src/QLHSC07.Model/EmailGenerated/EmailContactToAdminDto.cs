using System;

namespace QLHSC07.Model.EmailGenerated
{
    public class EmailContactToAdminDto
    {
        public long Id { get; set; }
        public DateTime SentDate { get; set; }
        public string SendFrom { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool IsReplied { get; set; }
    }
    public class DetailEmailContactToAdminDto
    {
        public long Id { get; set; }
        public DateTime SentDate { get; set; }
        public string SendFrom { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public bool IsReplied { get; set; }
        public RepliedMessage RepliedContent { get; set; }
    }

    public class RepliedMessage
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public string SendFrom { get; set; }
    }
}
