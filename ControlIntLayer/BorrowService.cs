using EF_core_demo.Data;
using EF_core_demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_demo.ControlIntLayer
{
    public class BorrowService
    {
        // intializing APPDBCTX.

        private appDbContext con;
        public BorrowService(appDbContext con)
        {
            this.con = con;
        }

        // Borrowing
        public bool BorrowBook(BookBorrowTransaction transaction)
        {
            var book = con.Books.Find(transaction.bookId);
            var member = con.members.Find(transaction.MemberId);


            if (book == null || member == null || book.CopiesAvailable < 1)
            {
                return false;
            }

            using (var trx = con.Database.BeginTransaction())
            {
                try
                {
                    book.CopiesAvailable -= 1;

                    transaction.ReturnDate = null;
                    con.bookBorrowTransactions.Add(transaction);

                    trx.Commit();

                    return true;
                }

                catch 
                {
                    trx.Rollback();
                    return false;
                }

                finally
                {
                    con.SaveChanges();
                }


             }
            
        }

        // Returning
        public bool returnBook(BookBorrowTransaction transaction)
        {
            var book = con.Books.Find(transaction.bookId);
            var member = con.members.Find(transaction.MemberId);
            var trans = con.bookBorrowTransactions
                           .LastOrDefault(t => t.MemberId == transaction.MemberId && 
                           t.bookId == transaction.bookId);

                //Find(new {transaction.MemberId, transaction.bookId, transaction.BorrowDate});

            if (book == null || member == null || book.CopiesAvailable < 1 || trans == default)
            {
                return false;
            }


            using (var trx = con.Database.BeginTransaction())
            {
                try
                {
                    book.CopiesAvailable += 1;
                    trans.ReturnDate = DateTime.Now;

                    // con.bookBorrowTransactions.Remove(transaction);

                    trx.Commit();

                    return true;
                }

                catch
                {
                    trx.Rollback();
                    return false;
                }

                finally { con.SaveChanges(); }

            }
            
        }


    }
}
