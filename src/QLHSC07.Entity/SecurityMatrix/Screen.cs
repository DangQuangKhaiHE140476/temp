using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.SecurityMatrix
{
    [Table(TableFieldNameHelper.Sys.Screen,Schema = Constant.Schema.SYS)]
    public class Screen
    {
        [Column("id")]
        public int Id { set; get; }
        [Column("parent_id")]
        public int? ParentId { set; get; }
        [ForeignKey(nameof(ParentId))]
        public Screen Parent { get; set; }

        [Column("code")]
        public string Code { set; get; }
        [Column("name")]
        public string Name { set; get; }
        [Column("title")]
        public string Title { set; get; }
        [Column("icon")]
        public string Icon { set; get; }
        [Column("order")]
        public int Order { get; set; }
        public ICollection<SecurityMatrix> SecurityMatrices { set; get; } = new List<SecurityMatrix>();
        public ICollection<Screen> Childrent { get; set; }
    }
}
