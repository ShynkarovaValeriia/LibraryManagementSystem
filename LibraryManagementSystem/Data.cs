using System;

namespace LibraryManagementSystem
{
    internal class Data
    {
        public class Book
        {
            public string BookID { get; set; }
            public string BookName { get; set; }
            public string Genre { get; set; }
            public string Author { get; set; }
        }

        public class Reader
        {
            public string ReaderID { get; set; }
            public string ReaderName { get; set; }
            public string Contacts { get; set; }
        }

        public class IssueReturn
        {
            public string BookID { get; set; }
            public string ReaderID { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public string ReturnStatus { get; set; }
        }
    }
}
