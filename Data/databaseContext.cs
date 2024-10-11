using System;
using System.Collections.Generic;
using EF_core_demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MyApp;

namespace EF_core_demo.Data
{
    public partial class appDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=EFdb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AuthorModelValidations().Configure(modelBuilder.Entity<Author>());
            new BookModelValidations().Configure(modelBuilder.Entity<Book>());
            new CategoryModelValidations().Configure(modelBuilder.Entity<Category>());
            new MemberModelValidations().Configure(modelBuilder.Entity<Member>());
            new BookBorrowTransactionValidations().Configure(modelBuilder.Entity<BookBorrowTransaction>());

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<Category> categories { get; set; }

        public DbSet<Author> authors { get; set; }

        public DbSet<BookBorrowTransaction> bookBorrowTransactions { get; set; }

    }
}
