using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public int CopiesAvailable { get; set; }

        public int CategoryId { get; set; }
        public Category? category { get; set; }

        public int AuthorId { get; set; }
        public Author? author { get; set; }

        public ICollection<Member> members { get; set; } = new List<Member>();
        public ICollection<BookBorrowTransaction> bookBorrows { get; set; } = new List<BookBorrowTransaction>();

        public override string ToString()
        {
            return "BookId: "+ BookId + "   BookName: " + BookName.Substring(0, Math.Min(BookName.Length, 13))
                + "   CopiesAvailable: " +
                CopiesAvailable + "   CategoryId: " + CategoryId + "  AuthorId: " + AuthorId;
        }


    }
}
