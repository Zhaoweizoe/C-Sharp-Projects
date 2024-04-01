using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the main method,instantiate an Employee object
            Employee sam = new Employee() { firstname = "Sample", lastname = "Student" };
            //Call the SayName method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
