using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOOP
{
    public class StudentClass : Student, IStudent, IStudent1
    {
        public void AddBook()
        {
            new Book().Id = 1121;
            new Book().Name = "Pro Haunted";
            Console.WriteLine("Book Added Successfully");
        }

        public List<Book> GetBooks()
        {
            var books = new List<Book>()
            {
                new Book
                {
                    Id = 121,
                    Name = "Competitive Programming"
                },
                new Book
                {
                    Id = 122,
                    Name = "Advanced Programming"
                }
            };
            return books;
        }
    }

    public interface IStudent
    {
        void AddBook();
    }

    public interface IStudent1
    {
        List<Book> GetBooks();
    }
}
