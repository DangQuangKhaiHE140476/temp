using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using QLHSC07.CORE.Helper;

namespace QLHSC07.Entity.ConsultCommunity
{
    [Table(TableFieldNameHelper.Cms.FormTemplate, Schema = Constant.Schema.CMS)]
    public class FormTemplate : BaseFullAuditedEntity<int>
    {
        [Column("title")]
        public string Title { set; get; }
        [Column("consultant_community_id")]
        public int? ConsultantCommunityId { set; get; }
        public virtual ICollection<FormTemplateQuestion> Questions { get; set; } = new List<FormTemplateQuestion>();
        public virtual ICollection<PersonInfoAnswer> PersonInfoAnswers { get; } = new List<PersonInfoAnswer>();
        //public string GetConsultantCommunityTitle()
        //{
        //    return ConsultantCommunity.Title;
        //}
    }
}
