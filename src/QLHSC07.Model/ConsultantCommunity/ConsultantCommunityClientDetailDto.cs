namespace QLHSC07.Model.ConsultantCommunity
{
    public class ConsultantCommunityClientDetailDto
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string PlanningName { set; get; }
        public string Content { set; get; }
        public bool IsExpired { get; set; }
        public string DocumentPath { get; set; }
    }
}
