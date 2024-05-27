using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSC07.Entity.IdentityExtentions.IdentityMapping
{
    public class AspNetRefreshTokensMap : QLHSC07EntityTypeConfiguration<AspNetRefreshTokens>
    {
        public override void Configure(EntityTypeBuilder<AspNetRefreshTokens> builder)
        {
            builder.ToTable("AspNetRefreshTokens");
        }
    }
}
