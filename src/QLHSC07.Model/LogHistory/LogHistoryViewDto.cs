namespace QLHSC07.Model.LogHistory
{
    public class LogHistoryViewDto : BaseModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Action { get; set; }
        public string ActionName { get; set; }
        public string Description { get; set; }
    }
}