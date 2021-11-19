using Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFrameWork.Context.Mapping
{
    public class GenreMap : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(I => I.GenreId);
            builder.Property(I => I.GenreId).UseIdentityColumn();
            builder.Property(I => I.GenreName).HasMaxLength(20).IsRequired();
            builder.HasMany(I => I.Books).WithOne(I => I.Genre).HasForeignKey(I => I.GenreId);
        }
    }
}
