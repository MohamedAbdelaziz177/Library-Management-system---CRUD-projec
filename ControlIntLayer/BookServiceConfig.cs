using EF_core_demo.Data;
using EF_core_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.ControlIntLayer
{
    public class BookServiceConfiguration
    {

        // intializing APPDBCTX.
        private appDbContext con;
        public BookServiceConfiguration(appDbContext con) 
        {
            this.con = con;
        }   


        // Adding new book to the libarary.
        public bool AddNewBook(Book book)
        {
            var checkBookValid = (con.authors.Find(book.AuthorId) is not null)
                && (con.categories.Find(book.CategoryId) is not null);

            if (checkBookValid)

            {
                book.CopiesAvailable = 1;
                con.Books.Add(book);
             
                con.SaveChanges();
            }

            return checkBookValid;
            

        }
        

        // Removing an existing book from the libarary.
        public bool RemoveBook(int id)
        {
            var checkBookValid = con.Books.Find(id) is not null;

            if (checkBookValid)
            {
                con.Books.Remove(con.Books.Find(id));
                con.SaveChanges();
            }

            return checkBookValid;
        }


        // Increase the value of somebook's count.
        public bool CountBookUp(int id)
        {
            var checkBookValid = con.Books.Find(id) is not null;

            if (checkBookValid)
            {
                con.Books.Find(id).CopiesAvailable += 1;
                con.SaveChanges();
            }

            return checkBookValid;

        }

        // Decrease the value of somebook's count.
        public bool CountBookDown(int id)
        {
            var checkBookValid = con.Books.Find(id) is not null;

            if (checkBookValid)
            {
                con.Books.Find(id).CopiesAvailable -= 1;
                con.SaveChanges();
            }

            return checkBookValid;

        }

        // Getting the count of somebook with its ID.
        public int getBookCount(int id)
        {
            var checkBookValid = con.Books.Find(id) is not null;

            if (checkBookValid)
            {
                return con.Books.Find(id).CopiesAvailable;
            }

            return 0;   
        }

        // Displaying All Books
        public List<Book> ShowAllBooks()
        {
            return con.Books.ToList();
        }


    }
}
