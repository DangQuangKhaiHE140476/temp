using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DATVANG.CORE.Helper;
using Microsoft.VisualBasic.CompilerServices;

namespace DATVANG.Entity
{
    [Table("category", Schema = Constant.Schema.CMS)]
    public class Category {
        [Key]
        [Column("id")]
        public IntegerType Id { get; set; }
        [Column("category_code")]
        public string CategoryCode { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("order")]
        public IntegerType Order { get; set; }
    }
}