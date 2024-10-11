using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.Models
{
    public class Member
    { 
        public int MemberId { get; set; }
        public string MemberName { get; set; }

        public string MemberEmail { get; set; }

        public ICollection<Book> books { get; set; } = new List<Book>();
        public ICollection<BookBorrowTransaction> bookBorrows { get; set; } = new List<BookBorrowTransaction>();

        public override string ToString()
        {
            return "MemberId: " + MemberId + "    MemberName: " + MemberName + "    MemberEmail: " + MemberEmail;
        }
    }
}
