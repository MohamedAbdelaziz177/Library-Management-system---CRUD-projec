using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return "CategoryId: " + CategoryId + "    CategoryName: " + CategoryName
                + "     CategoryDescription: " + CategoryDescription;
        }
    }
}
