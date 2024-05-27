using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.Document
{
    [Table(TableFieldNameHelper.Cms.DocumentFile, Schema = Constant.Schema.CMS)]
    public class DocumentFile
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("document_id")]
        public long DocumentId { get; set; }

        [Column("type_file")]
        public string TypeFile { get; set; }

        [Column("url_path")]
        public string UrlPath { get; set; }
    }
}
