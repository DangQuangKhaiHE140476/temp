namespace QLHSC07.Model.EmailTemplate
{
    public class EMailContainerDto
    {
        public string SendTo { set; get; }
        public string[] SendTos { set; get; }
        public string CC { set; get; }
        public string Subject { set; get; }
        public string Body { set; get; }
        public int EMailType { set; get; }

    }
}
