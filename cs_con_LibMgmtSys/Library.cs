using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_LibMgmtSys
{
    public class Library
    {
        public string LibraryName { get; private set; }
        public Library(string name)
        {
            this.LibraryName = name;
        }
        public void DisplayLibraryItems()
        {
            Console.WriteLine($":::::Welcome to {this.LibraryName} Library::::::::");
        }
        public static List<Books> booklist = new List<Books>
        {
            new Books{BookName = "Head First C#", BookId = 01, BookPrice = 1000, NumCopies= 3 , Authors = "Andrew Stellman"},
            new Books{BookName = "The Diary of a Young Girl", BookId = 02, BookPrice = 520, NumCopies= 2 , Authors = "Anne Frank"},
            new Books{BookName = "To kill a MockingBird", BookId = 03, BookPrice = 410 , NumCopies = 2, Authors = "Harper Lee"},
            new Books{BookName = "Where the sidewalks ends", BookId = 04, BookPrice = 234 , NumCopies = 4, Authors = "Shel Silverstein"},
            new Books{BookName = "Valley of the dolls", BookId = 05, BookPrice = 276 , NumCopies = 3, Authors = "Jacqueline Susann"},
            new Books{BookName = "The Shining", BookId = 06, BookPrice = 143 , NumCopies = 2, Authors = "Stephen King"},
            new Books{BookName = "The Little Prince", BookId = 07, BookPrice = 134 , NumCopies = 2, Authors = "Antoine"},
            new Books{BookName = "The Fellowship", BookId = 08, BookPrice = 545 , NumCopies = 6, Authors = "Tolkien"},
            new Books{BookName = "A wrinkle in Time", BookId = 09, BookPrice = 298 , NumCopies = 3, Authors = "Madeleine"},
            new Books{BookName = "Pride and Prejudice", BookId = 10, BookPrice = 399 , NumCopies = 2, Authors = "Jane Austen"},
            new Books{BookName = "Beloved", BookId = 11, BookPrice = 789 , NumCopies = 4, Authors = "Toni Marson"},
            new Books{BookName = "In Cold Blood", BookId = 12, BookPrice = 344 , NumCopies = 5, Authors = "Truman Capote"}


        };
        public static List<Newspaper> newspaperlist = new List<Newspaper>
        {
           new Newspaper{NewspaperName = "DainikJagran", NewspaperID = 01, NewspaperPrice = 5 , NewspaperCount = 5 },
           new Newspaper{NewspaperName = "AmarUjala", NewspaperID = 02, NewspaperPrice = 4 , NewspaperCount = 5},
           new Newspaper{NewspaperName = "TheTimesOfIndia", NewspaperID = 03, NewspaperPrice = 10 , NewspaperCount = 4},
           new Newspaper{NewspaperName = "TheHindu", NewspaperID = 04, NewspaperPrice = 10 , NewspaperCount = 5},
           new Newspaper{NewspaperName = "IndianExpress", NewspaperID = 05, NewspaperPrice = 10 , NewspaperCount = 4}
        };
    }
}
