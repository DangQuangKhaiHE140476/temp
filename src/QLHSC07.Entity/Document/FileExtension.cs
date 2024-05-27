using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.Document
{
    [Table(TableFieldNameHelper.Cms.FileExtension,Schema = Constant.Schema.CMS)]
    public class FileExtension
    {
        [Column("id")]
        public int Id { set; get; }
        [Column("name")]
        public string Name { set; get; }
        [Column("icon")]
        public string Icon { set; get; }
    }
}
