using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print program title
            Console.WriteLine("Car Insurance Application");
            // Prompt the user to input their age
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            // Prompt the user to input whether they have had a DUI
            Console.WriteLine("Have you ever had a DUI?(Yes or No)");
            // Read user input and convert it to lowercase
            string answer = Console.ReadLine().ToLower();
            // Check if the answer is "yes" and assign the result to the boolean variable 'dui'
            bool dui = answer == "yes";
            // Prompt the user to input the number of speeding tickets they have
            Console.WriteLine("How many speeding tickets do you have?");
            // Read and convert the number of speeding tickets to an integer
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified for insurance?");
            // Check if the user qualifies for insurance based on their age, DUI history, and number of speeding tickets
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            // Print whether the user is qualified for insurance
            Console.WriteLine(qualified);
        }
    }
}
