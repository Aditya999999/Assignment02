using System;
using System.Collections.Generic;
using System.Threading;

namespace cs_con_LibMgmtSys
{
    class Program

    {


        public static List<Borrower> borrowerslist = new List<Borrower>();
        

        public static Books book = new Books();
        static Borrower borrower = new Borrower();
        static Newspaper newspaper = new Newspaper();
        static void Main(string[] args)
        {
            Library library = new Library("Social Club");
           
            while (true)
            {
                Console.WriteLine("-------------------------------------------");
                library.DisplayLibraryItems();
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
                        int option3 = int.Parse(Console.ReadLine());
                        if (option3 == 1)
                        {
                            Books.AddBook();
                            Console.WriteLine("Your Book is Added Successfully!!!\n It can seen above in BookList.\n");
                            

                        }

                        else if (option3 == 2)
                        {
                            Books.RemoveBook();
                            Console.WriteLine("Your Book is Removed Successfully!!!\n It can seen above in BookList.\n");
                            
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
                else if (option1 == 2)
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
                else 
                {
                    Console.WriteLine("Sorry, You have chosen wrong option, Please try again by carefully looking options..");
                }
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Let's Play It Again!!!");
                Console.WriteLine(":::::::::::::::::::::::");
                Console.WriteLine();
                function();                            //For Continuously Running the Application 
            }
        }
         public static void function()
        {
            Main(null);
        }
    }
}
