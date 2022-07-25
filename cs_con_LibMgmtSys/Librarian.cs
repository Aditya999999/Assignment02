using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    public class Librarian
    {
        public string LibrarianID;
        public string LibrarianName;

        public static void ViewBorrowerList()
        {
            if (Program.borrowerslist.Count == 0)
            {
                Console.WriteLine("No Borrowers available.");
            }
            else
            {
                foreach (Borrower bor in Program.borrowerslist)
                {
                    Console.WriteLine("Borrower's ID - {0}  Borrower's Name-{1} Books Count-{2} Newspapaer Count-{3}", bor.BorrowerID, bor.BorrowerName, bor.BorrowBooksCount, bor.BorrowNewspaperCount);
                }
            }
        }

    }
    
 

}
