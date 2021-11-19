using DataAccessLayer.Abstract.EntityFrameWork.Context.Mapping;
using Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFrameWork.Context
{
    public class BookContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=WINDOWS-84ER0LR;database=BookStoreDb;Trusted_Connection=true;");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new GenreMap());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
