using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.FileService;
using QLHSC07.CORE.Helper;
using QLHSC07.Entity.Document;


namespace QLHSC07.Entity
{
    [Table(TableFieldNameHelper.Cms.DocumentUpload, Schema = Constant.Schema.CMS)]
    public class DocumentUpload : BaseFullAuditedEntity<long>
    {

        [Column("name")]
        public string Name { get; set; }
        [Column("parent_id")]
        public long ParentId { get; set; }
        [Column("type")]
        public int Type { get; set; }
        [Column("path")]
        public string Path { get; set; }
        [Column("file_extension_id")]
        public int? FileExtensionId { get; set; }  
        [Column("allowed_modify")]
        public bool AllowedModify { get; set; }
        [Column("multi_size_image_paths", TypeName = "jsonb")]
        public List<MultiSizeImagePaths> MultiSizeImagePaths { get; set; }
        [Column("is_resize_image")]
        public bool IsResizeImage { get; set; }
        public virtual FileExtension FileExtension { get; set; }
    }
    public class MultiSizeImagePaths
    {
        public string Name { get; set; }
        public ImageSize Size { get; set; }
        public string Path { get; set; }
    }
}
