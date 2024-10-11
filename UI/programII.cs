using EF_core_demo.ControlIntLayer;
using EF_core_demo.Data;
using EF_core_demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.ComponentModel;

namespace MyApp
{
    public partial class Program
    {
        public static void show<T>(List<T> lst)
        {

            foreach (T item in lst)
            {
                Console.WriteLine(item);
            }
        }

        public static Book GetBook()
        {
            Book book = new Book();

            //Console.WriteLine(" #Book Id? ");
           // book.BookId = int.Parse(Console.ReadLine());

            Console.WriteLine(" #Book Name? ");
            book.BookName = Console.ReadLine();

            Console.WriteLine(" #Book CategoryId? ");
            book.CategoryId = int.Parse(Console.ReadLine());

            Console.WriteLine(" #Book AuthorId? ");
            book.AuthorId = int.Parse(Console.ReadLine());

            return book;

        }

        public static BookBorrowTransaction GetBorrowDetails()
        {
            BookBorrowTransaction borrowDetails = new BookBorrowTransaction();

            Console.WriteLine(" #Book Id? ");
            borrowDetails.bookId = int.Parse(Console.ReadLine());

            Console.WriteLine(" #Member Id? ");
            borrowDetails.MemberId = int.Parse(Console.ReadLine());

            DateTime borrowDate = DateTime.Now;
            borrowDetails.BorrowDate = borrowDate;

            return borrowDetails;


        }

        public static BookBorrowTransaction ReturnBookDetails()
        {
            BookBorrowTransaction returnDetails = new BookBorrowTransaction();

            Console.WriteLine(" #Book Id? ");
            returnDetails.bookId = int.Parse(Console.ReadLine());

            Console.WriteLine(" #Member Id? ");
            returnDetails.MemberId = int.Parse(Console.ReadLine());

            DateTime returnDate = DateTime.Now;
            returnDetails.ReturnDate = returnDate;

            return returnDetails;
        }

        public static void GetAllBorrows(appDbContext con)
        {
            var res = from a in con.bookBorrowTransactions
                      join b in con.Books
                      on a.bookId equals b.BookId
                      join c in con.members
                      on a.MemberId equals c.MemberId
                      select (new { a.MemberId, a.bookId, c.MemberName, b.BookName, a.BorrowDate , a.ReturnDate});

           // Console.WriteLine("Member" + "  " + "Book" + "   " + "Borrow Date" + "   ");
            foreach (var item in res)
            {
                Console.WriteLine("Member: " + item.MemberName +
                    "   " + "Book: " + item.BookName + "   " + "Borrow Date: " +  item.BorrowDate +
                    "  Return Date: " + item.ReturnDate);
            }
        }
    }
}
