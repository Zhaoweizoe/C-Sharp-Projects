using System;

namespace StructAssignment
{
    // Define a struct called Number to represent a decimal number.
    public struct Number
    {
        // Property to hold the amount of type decimal.
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Number struct.
            Number number = new Number();

            // Assign an amount to the Amount property of the Number struct.
            number.Amount = 155m;

            // Print the amount to the console.
            Console.WriteLine("Amount: " + number.Amount);
        }
    }
}
