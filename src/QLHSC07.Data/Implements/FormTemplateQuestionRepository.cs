using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.ConsultCommunity;

namespace QLHSC07.Data.Implements
{
    public class FormTemplateQuestionRepository : BaseRepository<FormTemplateQuestion>, IFormTemplateQuestionRepository
    {
        public FormTemplateQuestionRepository(AppDbContext context) : base(context)
        {
        }
    }
}