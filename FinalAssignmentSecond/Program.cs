using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the custom database initializer
            Database.SetInitializer(new SchoolInitializer());

            using (var db = new SchoolContext())
            {
                // Create and save a new Student
                Console.Write("Enter the first name for a new Student: ");
                var firstName = Console.ReadLine();

                Console.Write("Enter the last name for a new Student: ");
                var lastName = Console.ReadLine();

                var student = new Student { FirstName = firstName, LastName = lastName };
                db.Students.Add(student);
                db.SaveChanges();

                // Display all Students from the database
                var query = from s in db.Students
                            orderby s.FirstName
                            select s;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine("ID: {0}, Name: {1} {2}", item.Id, item.FirstName, item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True")
        {
        }

        public DbSet<Student> Students { get; set; }
    }

    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student { FirstName = "Joe", LastName = "White" }
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }
    }
}