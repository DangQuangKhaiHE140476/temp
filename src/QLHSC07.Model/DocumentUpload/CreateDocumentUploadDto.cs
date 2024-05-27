using System;
using System.ComponentModel.DataAnnotations;
using QLHSC07.Entity.Document;

namespace QLHSC07.Model.DocumentUpload
{
    public class DocumentUploadDto
    {
        public string Name {get;set;}
        public long ParentId {get;set;}
        public string Path {get;set;}
        public int Type {get;set;}
        public int? FileExtensionId { get; set; }
        public bool AllowedModify { get; set; }
    }

    public class DocumentDetailDto
    {
        public long Id { get; set; }
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
        public bool AllowedModify { get; set; }
    }

    public class CreateFolderDto
    {
        public long ParentId { get; set; }
        public string TargetPath { get; set; }
        public string FolderName { get; set; }
    }

    public class DownloadDocumentDto
    {
        public string FilePath { get; set; }
        //public int Type { get; set; }
    }

    public class MoveDocumentDto
    {
        public long DocumentId { get; set; }
        public long TargetParentId { get; set; } 
        public string TargetFolderPath { get; set; }
    }

    public class DeleteDocumentDto
    {
        public long Id { get; set; }
    }

    public class UploadDocumentDto
    {
        public long ParentId { get; set; }
        public string UploadFolderPath { get; set; }
    }
}