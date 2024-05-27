namespace QLHSC07.Model.Document
{
    public class RenameDocumentDto
    {
        public long DocumentId { set; get; }
        public string NewDocumentName { set; get; }
        public int Type { set; get; }
        public long PlanningId { set; get; }
    }
}
