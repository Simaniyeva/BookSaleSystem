using Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFrameWork.Context.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(I => I.BookId);
            builder.Property(I => I.BookId).UseIdentityColumn();
            builder.Property(I => I.BookName).HasMaxLength(50).IsRequired();
            builder.Property(I => I.Price).HasMaxLength(10000).IsRequired();
            builder.Property(I => I.Count).HasMaxLength(1000).IsRequired();
            builder.HasOne(I => I.Genre).WithMany(I => I.Books).HasForeignKey(I => I.GenreId);
        }
    }
}
