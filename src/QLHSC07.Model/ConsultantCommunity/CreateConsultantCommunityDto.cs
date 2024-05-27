using System;

namespace QLHSC07.Model.ConsultantCommunity
{
    public class CreateConsultantCommunityDto
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public DateTime StartTime { set; get; }
        public DateTime EndTime { set; get; }
        public bool IsHotNew { set; get; }
        public int StatusId { set; get; }
        public int Order { set; get; }
        public string Content { set; get; }
        public string FormOpinion { set; get; }
        public long PlanningId { set; get; }
        public string FormTemplateStringModel { get; set; }
        public long? DocumentUploadId { get; set; }
    }
}
