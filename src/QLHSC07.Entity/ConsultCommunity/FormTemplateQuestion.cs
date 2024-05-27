using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.ConsultCommunity
{
    [Table(TableFieldNameHelper.Cms.FormTemplateQuestion, Schema = Constant.Schema.CMS)]
    public class FormTemplateQuestion
    {
        [Column("id")]
        public int Id { set; get; }
        [Column("form_template_id")]
        public int FormTemplateId { set; get; }
        [Column("title")]
        public string Title { set; get; }
        [Column("order")]
        public int Order { set; get; }
        [Column("have_additional")]
        public bool HaveAdditional { set; get; }
        [Column("answer_type")]
        public string AnswerType { get; set; }
        public virtual FormTemplate FormTemplate { set; get; }
        public virtual ICollection<FormTemplateAnswer> Answers { get; } = new List<FormTemplateAnswer>();

    }
}
