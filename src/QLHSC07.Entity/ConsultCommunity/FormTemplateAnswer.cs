using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.ConsultCommunity
{
    [Table(TableFieldNameHelper.Cms.FormTemplateAnswer, Schema = Constant.Schema.CMS)]
    public class FormTemplateAnswer
    {
        [Column("id")]
        public int Id { set; get; }
        [Column("question_id")]
        public int QuestionId { set; get; }
        [Column("title")]
        public string Title { set; get; }
        [Column("order")]
        public int Order { set; get; }
        public virtual FormTemplateQuestion Question { set; get; }

    }
}
