using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassAssignment
{
    public class MathOperation
    {
        // Create a void method that takes two integers as parameters
        public void MyOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer
            int result = num1 * 5;
            // Display the result of the math operation
            Console.WriteLine("The result is" + result);
            // Display the second integer to the screen
            Console.WriteLine("The second integer is: " + num2);
        }
    }
}
