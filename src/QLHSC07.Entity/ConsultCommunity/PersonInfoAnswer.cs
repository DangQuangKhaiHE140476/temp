using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.ConsultCommunity
{
    [Table(TableFieldNameHelper.Cms.PersonInfoAnswer, Schema = Constant.Schema.CMS)]
    public class PersonInfoAnswer : BaseFullAuditedEntity<int>
    {
        [Column("form_template_id")]
        public int TemplateId { set; get; }
        [Column("name")]
        public string Name { set; get; }
        [Column("phone_no")]
        public string PhoneNo { set; get; }
        [Column("address")]
        public string Address { set; get; }
        [Column("email")]
        public string Email { set; get; }
        [Column("suggestion")]
        public string Suggestion { set; get; }
        [Column("reply")]
        public string Reply { set; get; }
        public virtual ICollection<AnswerExtension> Answers { get; set; } = new List<AnswerExtension>();
        public virtual FormTemplate FormTemplate { get; set; }
    }
}
