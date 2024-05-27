using System;
using System.ComponentModel;
using System.Dynamic;

namespace QLHSC07.Model.ConsultantCommunity
{
    public class ConsultantCommunityViewDto : BaseModel
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public DateTime StartTime { set; get; }
        public DateTime EndTime { set; get; }
        public bool IsHotNew { set; get; }
        public int StatusId { set; get; }
        [DisplayName("StatusName")]
        public string StatusName { set; get; }
        public int Order { set; get; }
        public string Content { set; get; }
        public string FormOpinion { set; get; }
        public long PlanningId { set; get; }
        [DisplayName("PlaningName")]
        public string PlaningName { set; get; }
        public string ConsultantDocumentFile { set; get; }
        public int? FormTemplateId { set; get; }
        public string FormTemplateName { set; get; }
    }
    public class ConsultantCommunityUpdateDto : BaseModel
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public DateTime StartTime { set; get; }
        public DateTime EndTime { set; get; }
        public bool IsHotNew { set; get; }
        public int StatusId { set; get; }
        [DisplayName("StatusName")]
        public string StatusName { set; get; }
        public int Order { set; get; }
        public string Content { set; get; }
        public string FormOpinion { set; get; }
        public long PlanningId { set; get; }
        [DisplayName("PlaningName")]
        public string PlaningName { set; get; }
        public string ConsultantDocumentFile { set; get; }
        //public long? DocumentUploadId { get; set; }
        public Files Files { get; set; }
        public int? FormTemplateId { set; get; }
        public string FormTemplateName { set; get; }
    }

    //public class Files
    //{
    //    public string fileName { get; set; }
    //    public string fileType { get; set; }
    //    public string filePreview { get; set; }
    //    public long fileSize { get; set; }
    //    public long? fileId { get; set; }
    //}

    public class ConsultantCommunityClientDto
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public DateTime StartTime { set; get; }
        public DateTime EndTime { set; get; }
        public int? Order { set; get; }
        public bool IsHotNew { set; get; }
        public string PlanningName { set; get; }
        public long? PlanningTypeId { set; get; }
        public int? ApprovalLevelId { set; get; }
        public string Place { set; get; }
        public string PlanningAgency { set; get; }
        public string ConsultingUnit { set; get; }
        public string Avatar { set; get; }
    }
}
