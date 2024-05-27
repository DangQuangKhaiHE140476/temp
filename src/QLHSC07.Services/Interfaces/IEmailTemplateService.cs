using QLHSC07.Data.Repository;
using QLHSC07.Entity;
using QLHSC07.Model.EmailTemplate;

namespace QLHSC07.Services.Interfaces
{
    public interface IEmailTemplateService
    {
        EmailTemplatePagedListViewModel List(int pageIndex,int pageSize,string sortExpression, string code, string title);
        EmailTemplateViewDto GetEmailTemplateByCode(string code);
        bool Create(CreateEmailTemplateDto model);
        bool Update(UpdateEmailTemplateDto model);
        bool Delete(DeleteEmailTemplateDto model);

        bool GetByCode(string code);
    }
}
