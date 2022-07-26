using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    public class Books
    {
        public int bookId;
        public string bookName;
        public int bookCount;
        public int bookPrice;
        public int x;

        public static void AddBook()
        {
            Books book = new Books();
            Console.WriteLine("Book Id:{0}", book.bookId = Program.booklist.Count + 1);
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
           
            Program.booklist.Add(book);
            Console.WriteLine($"Now, total number of books available is: {Program.booklist.Count}");
            foreach (Books b in Program.booklist)
            {
                Console.WriteLine("ID- {0, -10}   Name- {1, -25}   Price- {2} Count- {3, -25}", b.bookId, b.bookName, b.bookPrice, b.bookCount);
            }
        }
        public static void RemoveBook()
        {
            Books book = new Books();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (Program.booklist.Exists(x => x.bookId == Del))
            {
                Program.booklist.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
                Console.WriteLine("Now, Collection of Books remains: ");
                foreach (Books b in Program.booklist)
                {
                    Console.WriteLine("ID- {0, -10}   Name- {1, -25}   Price- {2} Count- {3, -10}", b.bookId, b.bookName, b.bookPrice, b.bookCount);
                }
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            Program.booklist.Add(book);
        }
        public static void SearchBook()
        {
            Books book = new Books();
            Console.Write("Search by Book id :");
            int find = int.Parse(Console.ReadLine());

            if (Program.booklist.Exists(x => x.bookId == find))
            {
                foreach (Books searchId in Program.booklist)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
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
            if (Program.booklist.Count == 0)
            {
                Console.WriteLine("No Books available.");
            }
            else
            {
                foreach (Books b in Program.booklist)
                {
                    Console.WriteLine("ID- {0, -10}   Name- {1, -25}   Price- {2}   Count - {3, -25}", b.bookId, b.bookName, b.bookPrice, b.bookCount);
                }
            }
        }
    }
}
