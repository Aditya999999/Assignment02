using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    public class Newspaper
    {
        public string NewspaperName;
        public int NewspaperID;
        public int NewspaperCount;
        public int NewspaperPrice;
        public int x;

    
        public static void AddNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.WriteLine("Newspaper Id:{0}", newspaper.NewspaperID = Program.newspaperlist.Count + 1);
            Console.Write("Newspaper Name:");
            newspaper.NewspaperName = Console.ReadLine();
            Console.Write("Newspaper Price:");
            newspaper.NewspaperPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Newspaper:");
            newspaper.x = newspaper.NewspaperCount = int.Parse(Console.ReadLine());
            Program.newspaperlist.Add(newspaper);
            Console.WriteLine($"Now, total number of Newspapers available is: {Program.newspaperlist.Count}");
            foreach (Newspaper N in Program.newspaperlist)
            {
                Console.WriteLine("ID- {0}   Name- {1, -25}   Price- {2}", N.NewspaperID, N.NewspaperName, N.NewspaperPrice);
            }
        }
        public static void RemoveNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.Write("Enter Newspaper id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (Program.newspaperlist.Exists(x => x.NewspaperID == Del))
            {
                Program.booklist.RemoveAt(Del - 1);
                Console.WriteLine("Newspaper id - {0} has been deleted", Del);
                Console.WriteLine("Newspaper collection :");
                foreach (Newspaper N in Program.newspaperlist)
                {
                    Console.WriteLine("ID- {0}   Name- {1, -25}   Price- {2}", N.NewspaperID, N.NewspaperName, N.NewspaperPrice);
                }
            }
            else
            {
                Console.WriteLine("Invalid Newspaper id");
            }

            Program.newspaperlist.Add(newspaper);
        }
        public static void SearchNewspaper()
        {
            Newspaper newspaper = new Newspaper();
            Console.Write("Search by Newspaper id :");
            int find = int.Parse(Console.ReadLine());

            if (Program.newspaperlist.Exists(x => x.NewspaperID == find))
            {
                foreach (Newspaper searchId in Program.newspaperlist)
                {
                    if (searchId.NewspaperID == find)
                    {
                        Console.WriteLine("Newspaper id :{0}\n" +
                        "Newspaper name :{1}\n" +
                        "Newspaper price :{2}\n" +
                        "Newspaper Count :{3}", searchId.NewspaperID, searchId.NewspaperName, searchId.NewspaperPrice, searchId.NewspaperCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", find);
            }
        }
        public static void ViewTotalNewspaper()
        {
            if (Program.newspaperlist.Count == 0)
            {
                Console.WriteLine("No Newspaper available.");
            }
            else
            {
                foreach (Newspaper N in Program.newspaperlist)
                {
                    Console.WriteLine("ID- {0}   Name- {1, -25}   Price- {2}", N.NewspaperID, N.NewspaperName, N.NewspaperPrice);
                }
            }
        }
    }
}
