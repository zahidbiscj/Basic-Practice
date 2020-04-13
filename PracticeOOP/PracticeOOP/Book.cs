using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOOP
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static string AuthorizedBy { get; set; }
        public static void GetBooks()
        {
            Console.WriteLine("This is Get books Function");
        }
    }
}
