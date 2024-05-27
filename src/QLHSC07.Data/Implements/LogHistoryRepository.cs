using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.LogHistory;

namespace QLHSC07.Data.Implements
{
    public class LogHistoryRepository : BaseRepository<LogHistoryEntity>, ILogHistoryRepository
    {
        public LogHistoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
