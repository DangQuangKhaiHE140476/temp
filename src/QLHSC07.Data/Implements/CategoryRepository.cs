using DATVANG.Data.Repository;
using DATVANG.Entity;

namespace DATVANG.Data.Implements
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
