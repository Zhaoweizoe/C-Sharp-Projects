using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating some employee objects for demonstration
            Employee emp1 = new Employee(1, "Ann", "Red");
            Employee emp2 = new Employee(2, "Lily", "Green");
            Employee emp3 = emp1; // Assigning emp1 to emp3, so they refer to the same object
            Employee emp4 = emp2; // Assigning emp4 to emp2, so they refer to the same object

            // Comparing employee objects using the overloaded "==" operator
            Console.WriteLine("Comparing emp1 and emp2: " + (emp1 == emp2)); // Should be false
            Console.WriteLine("Comparing emp1 and emp3: " + (emp1 == emp3)); // Should be true
            Console.WriteLine("Comparing emp2 and emp4: " + (emp2 == emp4)); // Should be true
            Console.WriteLine("Comparing emp2 and emp3: " + (emp2 == emp3)); // Should be false
            Console.WriteLine("Comparing emp1 and emp4: " + (emp1 == emp4)); // Should be false

            Console.ReadLine();
        }
    }
}
