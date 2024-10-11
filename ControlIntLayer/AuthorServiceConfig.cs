using EF_core_demo.Data;
using EF_core_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.ControlIntLayer
{
    public class AuthorServiceConfig
    {
        // Intailizing appDbContext

        private appDbContext con;
        public AuthorServiceConfig(appDbContext con)
        { 
            this.con = con;
        }


        // Adding new Author
        public bool AddAuthor(Author author)
        {
            bool checkAuthorExist = con.authors.Contains(author);

            if (!checkAuthorExist)
            {
                con.authors.Add(author);
                con.SaveChanges();
                return true;
            }

            return false;
        }


        // Displaying all Authors
        public List<Author> ShowAllAuthors()
        {
            return con.authors.ToList();
        }
    }
}
