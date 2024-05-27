using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.ConsultCommunity
{
    [Table(TableFieldNameHelper.Cms.AnswerExtension, Schema = Constant.Schema.CMS)]
    public class AnswerExtension
    {
        [Column("id")]
        public int Id { set; get; }
        [Column("answer_id")]
        public int? AnswerId { set; get; }
        [Column("question_id")]
        public int QuestionId { set; get; }
        [Column("person_info_id")]
        public int PersonInfoId { set; get; }
        [Column("additional")]
        public string Additional { set; get; }

        public virtual PersonInfoAnswer PersonInfoAnswer { get; set; }
        public virtual FormTemplateQuestion Question { get; set; }
        public virtual FormTemplateAnswer Answer { get; set; }
    }
}
