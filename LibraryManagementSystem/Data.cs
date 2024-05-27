using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class LibraryData
    {
        public static List<Book> Books { get; set; } = new List<Book>();
        public static List<Reader> Readers { get; set; } = new List<Reader>();
        public static List<IssueBook> IssueBooks { get; set; } = new List<IssueBook>();
    }

    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }

    public class Reader
    {
        public int ReaderID { get; set; }
        public string ReaderName { get; set; }
        public string Contacts { get; set; }
    }

    public class IssueBook
    {
        public int IssueID { get; set; }
        public int BookID { get; set; }
        public int ReaderID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
