using EF_core_demo;
using EF_core_demo.ControlIntLayer;
using EF_core_demo.Data;
using EF_core_demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace MyApp
{
    public partial class Program
    {
       
       
        static void Main(string[] args)
        {

            appDbContext con = new appDbContext();         

            char operation;

            do
            {
                Console.WriteLine("-----------------------------------------------------------\n");

                Console.WriteLine("Type 1 for Display service or 2 for Manipulation service or 3 to exit");
                int c = int.Parse(Console.ReadLine());

                
                Console.WriteLine("-----------------------------------------------------------\n");

                if (c == 1)
                {
                    Console.WriteLine("Enter letter A for Displaying all books");
                    Console.WriteLine("Enter letter B for Displaying all Authors");
                    Console.WriteLine("Enter letter C for Displaying all Members");
                    Console.WriteLine("Enter letter D for Displaying all Categories");
                    Console.WriteLine("Enter letter X for Displaying all Borrow Operations");
                }

                else if (c == 2)
                {
                    Console.WriteLine("Enter letter Y for Borrowing a book");
                    Console.WriteLine("Enter letter Z for Returning a book");
                    Console.WriteLine("Enter letter U for Adding a book");
                    Console.WriteLine("Enter letter V for Deleting a book");
                }

                else break;
                

                Console.WriteLine("\n");

                Console.WriteLine("Enter letter E to Exit\n");

                Console.WriteLine("-----------------------------------------------------------\n");


                operation = char.Parse(Console.ReadLine());

                if (operation >= 'A' && operation <= 'Z') operation = char.ToLower(operation);

                Console.WriteLine("-----------------------------------------------------------\n");


                switch (operation)
                {
                    case 'a':
                        show<Book>(con.Books.ToList());
                        break;

                    case 'b':
                        show<Author>(con.authors.ToList());
                        break;

                    case 'c':
                        show<Member>(con.members.ToList());
                        break;

                    case 'd':
                        show<Category>(con.categories.ToList());
                        break;

                    case 'x':
                        GetAllBorrows(con);
                        break;

                    case 'y':
                        BorrowService service3 = new BorrowService(con);

                        if (service3.BorrowBook(GetBorrowDetails()))
                            Console.WriteLine("@@ Done successfully ♥ @@");

                        else Console.WriteLine("** Try Again :( **");

                        break;

                    case 'z':
                        BorrowService service4 = new BorrowService(con);

                        if(service4.returnBook(ReturnBookDetails()))
                            Console.WriteLine("@@ Done successfully ♥ @@");

                        else Console.WriteLine("** Try Again :( **");

                        break;

                    case 'u':
                        BookServiceConfiguration service1 = new BookServiceConfiguration(con);      
                        
                        if(service1.AddNewBook(GetBook())) Console.WriteLine("@@ Done successfully ♥ @@");
                        else Console.WriteLine("** Try Again :( **");

                        break;

                    case 'v':
                        BookServiceConfiguration service2 = new BookServiceConfiguration(con);

                        Console.WriteLine(" #BookId? ");
                        if (service2.RemoveBook(int.Parse(Console.ReadLine())))
                            Console.WriteLine("@@ Done successfully ♥ @@");

                        else Console.WriteLine("** Try Again :( **");

                        break;

                    case 'e':
                        break;

                }         
                
                Thread.Sleep(1500);

            } while (true);

        }
    }
}