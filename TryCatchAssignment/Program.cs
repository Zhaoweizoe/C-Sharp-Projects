using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask the user for their age
                Console.WriteLine("Please enter your age:");
                int age = int.Parse(Console.ReadLine());

                // Validate if age is non-negative
                if (age <= 0)
                {
                    throw new ArgumentException("Age must be a positive number.");
                }

                // Calculate the birth year
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Display the year the user was born
                Console.WriteLine("You were born in the year: " + birthYear);
            }
            catch (FormatException)
            {
                // Display error message if the user enters invalid input
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (ArgumentException ex)
            {
                // Display error message if the user enters zero or negative numbers
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                // Display a general message if an exception was caused by anything else
                Console.WriteLine("An error occurred. Please try again.");
            }
        }
    }
}
