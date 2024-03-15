using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End program if weight is more than 50 
                return; 
            }

            // Prompt user for package dimensions
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Calculate total dimensions
            int dimensionsTotal = width + height + length;

            // Check if dimensions total greater than 50
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // End program if dimensions total greater than 50
                return; 
            }

            // The result of that calculation is the quote
            decimal quote = (width * height * length * weight) / 100.0m;

            // Display the quote to the user as a dollar amount
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
        }
    }
}
