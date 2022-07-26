using System;
using System.Collections.Generic;
using System.Threading;

namespace cs_con_LibMgmtSys
{
    class Program
    {
        public static List<Books> booklist = new List<Books>
        { 
            new Books{bookName = "Apress", bookId = 01, bookPrice = 1000, bookCount= 3 },
            new Books{bookName = "The Diary of a Young Girl", bookId = 02, bookPrice = 520, bookCount= 2 },
            new Books{bookName = "To kill a MockingBird", bookId = 03, bookPrice = 410 , bookCount = 2},
            new Books{bookName = "Where the sidewalks ends", bookId = 04, bookPrice = 234 , bookCount = 4},
            new Books{bookName = "Valley of the dolls", bookId = 05, bookPrice = 276 , bookCount = 3},
            new Books{bookName = "The Shining", bookId = 06, bookPrice = 143 , bookCount = 2},
            new Books{bookName = "The Little Prince", bookId = 07, bookPrice = 134 , bookCount = 2},
            new Books{bookName = "The Fellowship", bookId = 08, bookPrice = 545 , bookCount = 6},
            new Books{bookName = "A wrinkle in Time", bookId = 09, bookPrice = 298 , bookCount = 3},
            new Books{bookName = "Pride and Prejudice", bookId = 10, bookPrice = 399 , bookCount = 2},
            new Books{bookName = "Beloved", bookId = 11, bookPrice = 789 , bookCount = 4},
            new Books{bookName = "In Cold Blood", bookId = 12, bookPrice = 344 , bookCount = 5}


        };
        public static List<Newspaper> newspaperlist = new List<Newspaper> 
        {
           new Newspaper{NewspaperName = "DainikJagran", NewspaperID = 01, NewspaperPrice = 5 , NewspaperCount = 5 },
           new Newspaper{NewspaperName = "AmarUjala", NewspaperID = 02, NewspaperPrice = 4 , NewspaperCount = 5},
           new Newspaper{NewspaperName = "TheTimesOfIndia", NewspaperID = 03, NewspaperPrice = 10 , NewspaperCount = 4},
           new Newspaper{NewspaperName = "TheHindu", NewspaperID = 04, NewspaperPrice = 10 , NewspaperCount = 5},
           new Newspaper{NewspaperName = "IndianExpress", NewspaperID = 05, NewspaperPrice = 10 , NewspaperCount = 4}
        };

        public static List<Borrower> borrowerslist = new List<Borrower>();
        

        public static Books book = new Books();
        static Borrower borrower = new Borrower();
        static Newspaper newspaper = new Newspaper();
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("   Welcome To Library Management System    ");
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("Are you a: ");
            Console.WriteLine("\nMenu\n"
                + "1) Librarian\n"
                + "2) Borrower");
            Console.WriteLine();
            Console.WriteLine("Choose option from menu");
            int option1 = int.Parse(Console.ReadLine());
            if (option1 == 1)
            {
                Console.WriteLine("What do you want to manage today?");
                Console.WriteLine("\nMenu\n" +
                                    "1) Book \n" +
                                    "2) Newspaper");
                Console.WriteLine();
                Console.WriteLine("Choose option from menu");
                int option2 = int.Parse(Console.ReadLine());
                if (option2 == 1) 
                {
                    Console.WriteLine("\nMenu\n" +
                                    "1) Add Book \n" +
                                    "2) Remove Book\n" +
                                    "3) Search Book\n" +
                                    "4) View the list of all books in the library\n" +
                                    "5) View BorrowersList");
                    Console.WriteLine();
                    Console.WriteLine("Choose option from menu");
                    int option3 = int.Parse (Console.ReadLine());
                    if (option3 == 1)
                    {
                        Books.AddBook();
                        
                    }

                    else if (option3 == 2)
                    {
                        Books.RemoveBook();
                    }
                    else if (option3 == 3)
                    {
                        Books.SearchBook();
                    }
                    else if (option3 == 4)
                    {
                        Books.ViewTotalBooks();
                    }
                    else if (option3 == 5)
                    {
                        Librarian.ViewBorrowerList();
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong choice.");
                    }

                }
                if (option2 == 2)
                {
                    Console.WriteLine("\nMenu\n" +
                                    "1) Add Newspaper \n" +
                                    "2) Remove Newspaper\n" +
                                    "3) Search Newspaper\n" +
                                    "4) View the list of all Newspapers in the library\n" +
                                    "5) View Borrower's Details");
                    Console.WriteLine();
                    Console.WriteLine("Choose option from menu");
                    int option3 = int.Parse(Console.ReadLine());
                    if (option3 == 1)
                    {
                        Newspaper.AddNewspaper();
                    }
                    else if (option3 == 2)
                    {
                        Newspaper.RemoveNewspaper();
                    }
                    else if (option3 == 3)
                    {
                        Newspaper.SearchNewspaper();
                    }
                    else if (option3 == 4)
                    {
                        Newspaper.ViewTotalNewspaper();
                    }
                    else if (option3 == 5)
                    {
                        Librarian.ViewBorrowerList();
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong choice.");
                    }

                }

            }
            if (option1 == 2)
            {
                Console.WriteLine("What do you want to select today?");
                Console.WriteLine("\nMenu\n" +
                                    "1) Book \n" +
                                    "2) Newspaper");
                Console.WriteLine();
                Console.WriteLine("Choose option from menu");
                int option2 = int.Parse(Console.ReadLine());
                if (option2 == 1)
                {
                    Console.WriteLine("\nMenu\n" +
                                    "1) Submit Book \n" +
                                    "2) Borrow Book\n" +
                                    "3) View the list of all books in the library");
                    Console.WriteLine();
                    Console.WriteLine("Choose option from menu");
                    int option3 = int.Parse(Console.ReadLine());
                    if (option3 == 1)
                    {
                        Borrower.ReturnBook();
                    }
                    else if (option3 == 2)
                    {
                        Borrower.bookBorrow();
                    }
                    
                    else if (option3 == 3)
                    {
                        Books.ViewTotalBooks();
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong choice.");
                    }

                }
                if (option2 == 2)
                {
                    Console.WriteLine("\nMenu\n" +
                                    "1) Borrow Newspaper \n" +
                                    "2) Return Newspaper\n" +
                                    "3) View the list of all Newspapers in the library");
                    Console.WriteLine();
                    Console.WriteLine("Choose option from menu");
                    int option3 = int.Parse(Console.ReadLine());
                    if (option3 == 1)
                    {
                        Borrower.newspaperBorrow();
                    }
                    else if (option3 == 2)
                    {
                        Borrower.ReturnNewspaper();
                    }
                    else if (option3 == 3)
                    {
                        Newspaper.ViewTotalNewspaper();
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong choice.");
                    }

                }

            }
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Let's Play It Again!!!");
            Console.WriteLine();
            Console.WriteLine();
            function();                            //For Continuously Running the Application 
        }
         public static void function()
        {
            Main(null);
        }
    }
}
