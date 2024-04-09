using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the current date and time to the console.
            Console.WriteLine("The current time is:" + DateTime.Now);
            //Asks the user for a number.
            Console.WriteLine("\nEnter a number to see what the time will be in that many hours:");
            float answer = float.Parse(Console.ReadLine());
            //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("{0}+{1}hour(s)={2}", DateTime.Now, answer, DateTime.Now.AddHours(answer));
        }
    }
}
