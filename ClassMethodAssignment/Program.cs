using System;

namespace ClassMethodAssignment
{
    // Declare a class to be static
    static class Program
    {
        
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathMethods mathOp = new MathMethods();

            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call the method on the entered number
            
            mathOp.DivideByTwo(userInput);



            // Call the overloaded method with a double input
            
            mathOp.DivideByTwo(10.5);
            


            // Call the method with output parameters
            int output;
            mathOp.DivideByTwoWithOutput(userInput, out output);
            Console.WriteLine("The result of dividing " + userInput + " by 2 using output parameters is: " + output);

            Console.ReadLine();
        }
    }
}
