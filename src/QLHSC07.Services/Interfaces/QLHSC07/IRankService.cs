using QLHSC07.Entity.QLHSC07_Entities;
using QLHSC07.Model.QLHSC07_Dtos.Rank;
using QLHSC07.Services.BaseServices;
using System.Collections.Generic;

namespace QLHSC07.Services.Interfaces.QLHSC07
{
    public interface IRankService : IBaseService<long, Rank, RankDto, RankDto, CreateRankDto, UpdateRankDto, FilterRankDto>
    {
        IList<RankLookupDto> GetLookupRank();
    }
}
