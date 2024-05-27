using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace QLHSC07.Model.Document
{
    public class DocumentTypeViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class DocumentCmsViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public DateTime? PublishDate { get; set; }
        public long DocumentId { get; set; }
        public long? DocumentUploadId { get; set; }
        public long? MapId { get; set; }
        public string Note { get; set; }
        public string LandForConstruction { get; set; }
        //public double? Acreage { get; set; }
        public string Acreage { get; set; }
        public int? Population { get; set; }
        public string ConsultingUnit { get; set; }
        public string PlanningAgency { get; set; }
        public string PlanningUnit { get; set; }
        public string AgencySubmitted { get; set; }
        public IList<DocumentCmsViewModel> PlanningRelationShips { get; set; }
        public List<DocumentViewModel> Documents { get; set; }
        public string NumberOfDecisions { get; set; }
        public int? YearOfStatement { get; set; }
        public string Report { get; set; }
    }

    public class DocumentViewModel : BaseModel
    {
        public long Id { get; set; }
        //[Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public long ParentId { get; set; }
        public string Path { get; set; }
        public int Type { get; set; }
        public long PlanningId { get; set; }
        public string PlanningName { get; set; }
        public string Extension { get; set; }
        public string ExtensionIcon { get; set; }
        public string TypeName { get; set; }
    }
    //public class DocumentSearchModel 
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //    public long ParentId { get; set; }
    //    public string Path { get; set; }
    //    public int Type { get; set; }
    //    public string TypeName { get; set; }
    //    public long PlanningId { get; set; }
    //    public string PlanningName { get; set; }
    //    public string Extension { get; set; }
    //    public string ExtensionIcon { get; set; }
    //    public DateTime CreatedDate { get; set; }
    //    public DateTime ModifiedDate { get; set; }
    //}
}
