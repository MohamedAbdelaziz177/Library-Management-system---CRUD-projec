using EF_core_demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace EF_core_demo.Data
{
    internal class BookModelValidations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(e => e.BookId);
            builder.Property(e => e.BookName).IsRequired();
            builder.HasIndex(e => e.BookName);

            builder.HasOne(e => e.category)
                .WithMany(e => e.Books)
                .HasForeignKey(e => e.CategoryId);

            builder.HasOne(e => e.author)
                .WithMany(e => e.books)
                .HasForeignKey(e => e.AuthorId);

            builder.HasMany(e => e.members)
                   .WithMany(e => e.books)
                   .UsingEntity
                   ("BookBorrowTransaction");

            builder.HasData(AddBooks());
        }


         private List<Book> AddBooks()
         {
           var lstOfBooks = new List<Book>
           {
               new Book { BookId = 1, BookName = "The Great Adventure", CopiesAvailable = 5, AuthorId = 1, CategoryId = 3 },
               new Book { BookId = 2, BookName = "Science of Tomorrow", CopiesAvailable = 3, AuthorId = 2, CategoryId = 2 },
               new Book { BookId = 3, BookName = "History of Ancient Civilizations", CopiesAvailable = 7, AuthorId = 3, CategoryId = 5 },
               new Book { BookId = 4, BookName = "Self-Improvement 101", CopiesAvailable = 10, AuthorId = 4, CategoryId = 6 },
               new Book { BookId = 5, BookName = "Mysteries of the Universe", CopiesAvailable = 4, AuthorId = 5, CategoryId = 3 },
               new Book { BookId = 6, BookName = "The Art of War", CopiesAvailable = 2, AuthorId = 6, CategoryId = 5 },
               new Book { BookId = 7, BookName = "Fictional Worlds", CopiesAvailable = 8, AuthorId = 7, CategoryId = 1 },
               new Book { BookId = 8, BookName = "Advanced Physics", CopiesAvailable = 9, AuthorId = 8, CategoryId = 2 },
               new Book { BookId = 9, BookName = "The Magic Realm", CopiesAvailable = 6, AuthorId = 9, CategoryId = 7 },
               new Book { BookId = 10, BookName = "Biography of a Legend", CopiesAvailable = 3, AuthorId = 10, CategoryId = 4 },
               new Book { BookId = 11, BookName = "Modern Technology", CopiesAvailable = 4, AuthorId = 11, CategoryId = 2 },
               new Book { BookId = 12, BookName = "Historical Figures", CopiesAvailable = 5, AuthorId = 12, CategoryId = 5 }
           };

            return lstOfBooks;
          }
    }
}

