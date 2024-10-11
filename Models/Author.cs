using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public string AuthorEmail { get; set; }

        public List<Book>? books { get; set; } = new List<Book>();

        public override string ToString()
        {
            return "AuthorId: " + AuthorId + "  AuthorName: " + AuthorName + "  AuthorEmail: " + AuthorEmail;
        }
    }
}
