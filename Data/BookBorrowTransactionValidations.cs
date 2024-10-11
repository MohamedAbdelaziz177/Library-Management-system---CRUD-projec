using EF_core_demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.Data
{
    internal class BookBorrowTransactionValidations : IEntityTypeConfiguration<BookBorrowTransaction>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<BookBorrowTransaction> builder)
        {
            builder.HasKey(t => new { t.bookId, t.MemberId, t.BorrowDate });
             
        }
    }
}
