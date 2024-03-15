using System;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
            //Console.WriteLine("Enter a number:");
            //long number = Convert.ToInt64(Console.ReadLine());
            //long result = number * 50;
            //Console.WriteLine("Result: " + result);
            //Console.ReadLine();

            //Takes an input from the user, adds 25 to it, then prints the result to the console.
            //Console.WriteLine("Enter a number:");
            //int input = Convert.ToInt32(Console.ReadLine());
            //int result = input + 25;
            //Console.WriteLine("Result: " + result);
            //Console.ReadLine();

            //Takes an input from the user, divides it by 12.5, then prints the result to the console.
            //Console.WriteLine("Enter a number:");
            //double input = Convert.ToDouble(Console.ReadLine());
            //double result = input / 12.5;
            //Console.WriteLine("Result: " + result);
            //Console.ReadLine();


            //Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
            //Console.WriteLine("Enter a number:");
            //int input = Convert.ToInt32(Console.ReadLine());
            //bool isGreaterThan50 = input > 50;
            //Console.WriteLine("Result: " + isGreaterThan50);
            //Console.ReadLine();


            //Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).
            Console.WriteLine("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int remainder = input % 7;
            Console.WriteLine("Remainder: " + remainder);
            Console.ReadLine();
        }
    }
}
