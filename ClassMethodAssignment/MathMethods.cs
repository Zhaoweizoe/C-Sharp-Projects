using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodAssignment
{
    class MathMethods
    {
        //create a void method that outputs an integer. Have the method divide the data passed to it by 2.
        public void DivideByTwo(int number)
        {
        double result = number / 2;
        Console.WriteLine("The result of dividing by 2 is:"+result);
        }
        // Create a method with output parameters
        public void DivideByTwoWithOutput(int number, out int result)
        {
            // Divide the data passed to the method by 2 and assign the result to the output parameter
            result = number / 2;
        }
        // Overload the method to handle a double input
        public void DivideByTwo(double number)
        {
            // Divide the data passed to the method by 2 and output the result
            double result = number / 2;
            Console.WriteLine("The result of dividing by 2 is:"+result);
        }
    }
}
