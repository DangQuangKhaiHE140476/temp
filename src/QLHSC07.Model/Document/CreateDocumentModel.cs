using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QLHSC07.Entity.Document;

namespace QLHSC07.Model.Document
{
    public class DocumentModel
    {
        public string Name {get;set;}
        public long PlanningId { set; get; }
        public long ParentId {get;set;}
        public string Path {get;set;}
        public int Type {get;set;}
        public int? FileExtensionId { get; set; }
    }

    public class DocumentDetailDtos
    {
        public long Id { get; set; }
        public long PlanningId { set; get; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public long ParentId { get; set; }
        public string Path { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public bool HasChild { get; set; }
        public long FileSize { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public FileExtension FileExtension { get; set; }
    }

    public class CreateFolderModels
    {
        public long PlanningId { set; get; }
        public long ParentId { get; set; }
        public string TargetPath { get; set; }
        public string FolderName { get; set; }
    }

    public class DownloadDocumentModels
    {
        public string FilePath { get; set; }
        //public int Type { get; set; }
    }

    public class MoveDocumentModels
    {
        public long DocumentId { get; set; }
        public long TargetParentId { get; set; } 
        public string TargetFolderPath { get; set; }
    }

    public class DeleteDocumentModels
    {
        public long Id { get; set; }
    }

    public class SetDocumentStatusModel
    {
        public List<long> DocumentId { get; set; }
            
        public bool Status { get; set; }
    }

    public class UploadDocumentModels
    {
        public long PlanningId { set; get; }
        public long ParentId { get; set; }
        public string UploadFolderPath { get; set; }
    }
}