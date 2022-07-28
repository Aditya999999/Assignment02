using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    internal class Borrower
    {
        public int BorrowerID;
        public string BorrowerName;
        public int borrowBookId;
        public int borrowNewspaperId;
        public DateTime BorrowDate;
        public int BorrowBooksCount;
        public int BorrowNewspaperCount;


        public static void bookBorrow()
        {
            Books book = new Books();
            Borrower borrow = new Borrower();
            Console.WriteLine("Borrower id : {0}", borrow.BorrowerID = Program.borrowerslist.Count + 1);
            Console.Write("Name :");

            borrow.BorrowerName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.BorrowBooksCount = int.Parse(Console.ReadLine());
            borrow.BorrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.BorrowDate.ToShortDateString(), borrow.BorrowDate.ToShortTimeString());

            if (Library.booklist.Exists(x => x.BookId == borrow.borrowBookId))
            {
                foreach (Books searchId in Library.booklist)
                {
                    if (searchId.NumCopies >= searchId.NumCopies - borrow.BorrowBooksCount && searchId.NumCopies - borrow.BorrowBooksCount >= 0)
                    {
                        if (searchId.BookId == borrow.borrowBookId)
                        {
                            searchId.NumCopies = searchId.NumCopies - borrow.BorrowBooksCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.NumCopies);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            Program.borrowerslist.Add(borrow);
        }

        public static void ReturnBook()
        {
            Books book = new Books();
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (Library.booklist.Exists(y => y.BookId == returnId))
            {
                foreach (Books addReturnBookCount in Library.booklist)
                {
                    if (addReturnBookCount.Num <= returnCount + addReturnBookCount.NumCopies)
                    {
                        if (addReturnBookCount.BookId == returnId)
                        {
                            addReturnBookCount.NumCopies = addReturnBookCount.NumCopies + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }

        public static void newspaperBorrow()
        {
            Newspaper newspaper = new Newspaper();
            Borrower borrow = new Borrower();
            Console.WriteLine("Borrower id : {0}", (borrow.BorrowerID = Program.borrowerslist.Count + 1));
            Console.Write("Your Name Please:");

            borrow.BorrowerName = Console.ReadLine();

            Console.Write("Newspaper id :");
            borrow.borrowNewspaperId = int.Parse(Console.ReadLine());
            Console.Write("Number of Newspapers : ");
            borrow.BorrowNewspaperCount = int.Parse(Console.ReadLine());
            borrow.BorrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.BorrowDate.ToShortDateString(), borrow.BorrowDate.ToShortTimeString());

            if (Library.newspaperlist.Exists(x => x.NewspaperID == borrow.borrowNewspaperId))
            {
                foreach (Newspaper searchId in Library.newspaperlist)
                {
                    if (searchId.NewspaperCount >= searchId.NewspaperCount - borrow.BorrowNewspaperCount && searchId.NewspaperCount - borrow.BorrowNewspaperCount >= 0)
                    {
                        if (searchId.NewspaperID == borrow.borrowNewspaperId)
                        {
                            searchId.NewspaperCount = searchId.NewspaperCount - borrow.BorrowNewspaperCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} newspaper are found", searchId.NewspaperCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", borrow.borrowNewspaperId);
            }
            Program.borrowerslist.Add(borrow);
        }

        public static void ReturnNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.WriteLine("Enter following details :");

            Console.Write("Newspaper id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Newspaper:");
            int returnCount = int.Parse(Console.ReadLine());

            if (Library.newspaperlist.Exists(y => y.NewspaperID == returnId))
            {
                foreach (Newspaper addReturnNewspaperCount in Library.newspaperlist)
                {
                    if (addReturnNewspaperCount.x <= returnCount + addReturnNewspaperCount.NewspaperCount)
                    {
                        if (addReturnNewspaperCount.NewspaperID == returnId)
                        {
                            addReturnNewspaperCount.NewspaperCount = addReturnNewspaperCount.NewspaperCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", returnId);
            }
        }

    }

}
