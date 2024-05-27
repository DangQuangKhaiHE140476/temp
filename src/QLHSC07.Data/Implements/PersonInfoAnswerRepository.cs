using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.ConsultCommunity;

namespace QLHSC07.Data.Implements
{
    public class PersonInfoAnswerRepository : BaseRepository<PersonInfoAnswer>, IPersonInfoAnswerRepository
    {
        public PersonInfoAnswerRepository(AppDbContext context) : base(context)
        {
        }
    }
}