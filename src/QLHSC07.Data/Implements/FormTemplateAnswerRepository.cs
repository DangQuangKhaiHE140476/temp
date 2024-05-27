using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.ConsultCommunity;

namespace QLHSC07.Data.Implements
{
    public class FormTemplateAnswerRepository : BaseRepository<FormTemplateAnswer>, IFormTemplateAnswerRepository
    {
        public FormTemplateAnswerRepository(AppDbContext context) : base(context)
        {
        }
    }
}