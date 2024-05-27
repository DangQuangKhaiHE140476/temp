using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity
{
    [Table(TableFieldNameHelper.Sys.EmailTemplate, Schema = Constant.Schema.SYS)]
    public class EmailTemplate
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("status")]
        public bool Status { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("send_to")]
        public string SendTo { get; set; }
        [Column("cc")]
        public string CC { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("created_by")]
        public string CreatedBy { get; set; }
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        [Column("modified_by")]
        public string ModifiedBy { get; set; }
        [Column("modified_date")]
        public DateTime ModifiedDate { get; set; }

    }
}
