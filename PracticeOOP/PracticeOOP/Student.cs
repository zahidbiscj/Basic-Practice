using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeOOP
{
    public class Student
    {
        public Student()
        {
            Console.WriteLine("Welcome to Student Management System");
        }

        public Student(string name)
        {
            Console.WriteLine("{0} is my Student name ",name);
        }

        public Student(string name , int intake)
        {
            Console.WriteLine("My name is {0} and intake - {1}",name,intake);
        }

        public Student(params string[] name)
        {
            Console.WriteLine("All the Student List Are Below - ");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
