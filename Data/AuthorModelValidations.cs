using EF_core_demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.Data
{
    public class AuthorModelValidations : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(e => e.AuthorId);
            builder.Property(e => e.AuthorName).IsRequired();
            builder.Property(e => e.AuthorEmail).IsRequired(false);
            builder.HasData(addVirtualData());

        }

        private List<Author> addVirtualData() {

            var lstOfAuthors = new List<Author>()
             {
                 new Author { AuthorId = 1, AuthorName = "Albert Einstein", AuthorEmail = "Albert Einstein@virtual.com" },
                 new Author { AuthorId = 2, AuthorName = "John Doe", AuthorEmail = "john.doe@example.com" },
                 new Author { AuthorId = 3, AuthorName = "Jane Smith", AuthorEmail = "jane.smith@example.com" },
                 new Author { AuthorId = 4, AuthorName = "Emily Johnson", AuthorEmail = "emily.johnson@example.com" },
                 new Author { AuthorId = 5, AuthorName = "Michael Brown", AuthorEmail = "michael.brown@example.com" },
                 new Author { AuthorId = 6, AuthorName = "Linda White", AuthorEmail = "linda.white@example.com" },
                 new Author { AuthorId = 7, AuthorName = "Mo Aziz", AuthorEmail = "Moaziz@virtual.com" },
                 new Author { AuthorId = 8, AuthorName = "Ma Aziz", AuthorEmail = "Maaziz@virtual.com" },
                 new Author { AuthorId = 9, AuthorName = "Moh Aziz", AuthorEmail = "Moahziz@virtual.com" },
                 new Author { AuthorId = 10, AuthorName = "Mee Aziz", AuthorEmail = "meeaziz@virtual.com" },
                 new Author { AuthorId = 11, AuthorName = "Moaz Aziz", AuthorEmail = "Moazaziz@virtual.com" },
                 new Author { AuthorId = 12, AuthorName = "Moza Aziz", AuthorEmail = "Mozaaziz@virtual.com" }
             };

            return lstOfAuthors;
        }


    }
}
