using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAssignment
{
    // Define an Employee class
    class Employee : IQuittable
    {
        // Properties of the Employee class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Behavior:Constructor for Employee class
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quite the job.");
        }
    }
}
