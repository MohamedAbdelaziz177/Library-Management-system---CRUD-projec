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
    internal class CategoryModelValidations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.CategoryId);
            builder.Property(e => e.CategoryName).IsRequired();
            builder.Property(e => e.CategoryDescription).IsRequired(false);
            builder.HasData(AddCategories());
        }


        private List<Category> AddCategories()
        {
            var lstOfCats =  new List<Category>()
            {
                new Category { CategoryId = 1, CategoryName = "Fiction", CategoryDescription = "Books that contain fictional stories and events." },
                new Category { CategoryId = 2, CategoryName = "Non-Fiction", CategoryDescription = "Books that are based on real facts and information." },
                new Category { CategoryId = 3, CategoryName = "Science Fiction", CategoryDescription = "Books that deal with futuristic concepts and technology." },
                new Category { CategoryId = 4, CategoryName = "Biography", CategoryDescription = "Books that describe the life of a real person." },
                new Category { CategoryId = 5, CategoryName = "History", CategoryDescription = "Books that explore historical events and eras." },
                new Category { CategoryId = 6, CategoryName = "Self-Help", CategoryDescription = "Books that provide guidance on personal growth and improvement." },
                new Category { CategoryId = 7, CategoryName = "Fantasy", CategoryDescription = "Books that involve magical or supernatural elements in the story." }
            };

            return lstOfCats;
        }
    }
}
