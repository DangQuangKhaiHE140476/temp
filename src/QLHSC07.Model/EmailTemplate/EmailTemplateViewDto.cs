using QLHSC07.Infrastructure.Implements;
using QLHSC07.Infrastructure.Interface;

namespace QLHSC07.Model.EmailTemplate
{
    public class EmailTemplatePagedListViewModel : BasePagedList<EmailTemplateViewDto>
    {
        public EmailTemplatePagedListViewModel(IPagedList<EmailTemplateViewDto> list) : base(list)
        {
        }
    }
    public class EmailTemplateViewDto : BaseModel
    {
        public bool Status { get; set; }
        public string Title { get; set; }
        public string SendTo { get; set; }
        public string CC { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int Id { get; set; }
    }
}
