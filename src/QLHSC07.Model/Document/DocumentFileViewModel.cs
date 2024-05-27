namespace QLHSC07.Model.Document
{
    public class DocumentFileRequest
    {
        public long Id { get; set; }

        public long DocumentId { get; set; }

        public string UrlPath { get; set; }

        public string TypeFile { get; set; }
    }

    public class DocumentFileViewModel
    {
        public long Id { get; set; }

        public long DocumentId { get; set; }

        public string UrlPath { get; set; }
        
        public string TypeFile { get; set; }

    }
}
