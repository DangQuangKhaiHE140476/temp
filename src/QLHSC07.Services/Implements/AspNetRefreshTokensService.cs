using QLHSC07.Data.Interfaces;
using QLHSC07.Data.Repository;
using QLHSC07.Entity.IdentityExtentions;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Services.Implements
{
    public class AspNetRefreshTokensRepository : BaseRepository<AspNetRefreshTokens>, IAspNetRefreshTokensRepository
    {
        public AspNetRefreshTokensRepository(AppDbContext context) : base(context)
        {
        }
    }
}
