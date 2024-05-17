using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalAssignment
{
    class Progrom
    {
        static void Main(string[] args)
        {

            Student student = new Student
            {
                Id = 1,
                FirstName = "Joe",
                LastName = "White"
            };

            Console.WriteLine("Student ID: " + student.Id);
            Console.WriteLine("First Name: " + student.FirstName);
            Console.WriteLine("Last Name: " + student.LastName);
        }
        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        public class BloggingContext : DbContext
        {
            public DbSet<Student> Student { get; set; }
            
        }
    }
}



