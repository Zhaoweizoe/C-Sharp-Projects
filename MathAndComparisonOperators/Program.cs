using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print program title
            Console.WriteLine("Anonymous Income Comparison Program");
            // Gather information for Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;
            // Gather information for Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;
            // Display annual salary of Person 1
            Console.WriteLine("Annual salary of Person1:");
            Console.WriteLine(salary1);
            // Display annual salary of Person 2
            Console.WriteLine("Annual salary of Person2:");
            Console.WriteLine(salary2);
            // Check if Person 1 makes more money than Person 2
            Console.WriteLine("Dose Person 1 make more money than Person 2?");
            // Compare salaries of Person 1 and Person 2
            bool isMore = salary1 > salary2;
            // Print the result of the comparison
            Console.WriteLine(isMore);
            // Pause the console so the result can be seen before the program exits
            Console.ReadLine();

        }
    }
}
