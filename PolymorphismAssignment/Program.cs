using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Create an instance of the Employee class
                Employee employee = new Employee("Ann", "White");

                // Call the Quit method using polymorphism
                IQuittable quittableEmployee = employee;
                quittableEmployee.Quit();

                // Wait for user input before closing the console window
                Console.WriteLine("Press Enter to exit");
                Console.ReadKey();
            }
        }
    }
}
