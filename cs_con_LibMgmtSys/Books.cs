using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    public class Books
    {
        public int BookId;
        public string BookName;
        public int NumCopies;
        public int BookPrice;
        public int Num;
        public string Authors;






        



        public static void AddBook()
        {
            Books book = new Books();
            Console.WriteLine("Book Id:{0}", book.BookId = Library.booklist.Count + 1);
            Console.Write("Book Name:");
            book.BookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.BookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.Num = book.NumCopies = int.Parse(Console.ReadLine());
            Console.Write("Author: ");
            book.Authors = Console.ReadLine();
            
           
            Library.booklist.Add(book);
            Console.WriteLine($"Now, total number of books available is: {Library.booklist.Count}");
            foreach (Books b in Library.booklist)
            {
                Console.WriteLine("ID- {0, -10}   Name- {1, -25}   Price- {2, -10} Count- {3, -10}  Author(s)- {4, -10} ", b.BookId, b.BookName, b.BookPrice, b.NumCopies, b.Authors);
            }
        }
        public static void RemoveBook()
        {
            Books book = new Books();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (Library.booklist.Exists(Num => Num.BookId == Del))
            {
                Library.booklist.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
                Console.WriteLine("Now, Collection of Books remains: ");
                foreach (Books b in Library.booklist)
                {
                    Console.WriteLine("ID- {0, -10}   Name- {1, -25}   Price- {2, -10} Count- {3, -10}  Author(s)- {4, -10} ", b.BookId, b.BookName, b.BookPrice, b.NumCopies, b.Authors);
                }
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            Library.booklist.Add(book);
        }
        public override string ToString()
        {
            return $"Book Title: {this.BookName}\n"
                   + $"Book ID: {this.BookId}\n"
                   + $"Book Price: {this.BookPrice}\n"
                   + $"Number of Copies: {this.NumCopies}\n"
                   + $"Author(s): {string.Join(", ", this.Authors)}";
        }
        public static void SearchBook()
        {
            Books book = new Books();
            Console.Write("Search by Book id :");
            int find = int.Parse(Console.ReadLine());

            if (Library.booklist.Exists(num => num.BookId == find))
            {
                foreach (Books searchId in Library.booklist)
                {
                    if (searchId.BookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Copies :{3}", searchId.BookId, searchId.BookName, searchId.BookPrice, searchId.NumCopies);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }
        public static void ViewTotalBooks()
        {
            if (Library.booklist.Count == 0)
            {
                Console.WriteLine("No Books available.");
            }
            else
            {
                Console.WriteLine("=========================================================================================================");
                foreach (Books b in Library.booklist)
                {
                    Console.WriteLine("ID- {0, -10}   Name- {1, -25}   Price- {2, -10} Count- {3, -10}  Author(s)- {4, -10} ", b.BookId, b.BookName, b.BookPrice, b.NumCopies, b.Authors);

                }
                Console.WriteLine("=========================================================================================================");
            }
        }
    }
}
