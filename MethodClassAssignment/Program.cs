using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathOp = new MathOperation();
            // Call the method in the class, passing in two numbers
            mathOp.MyOperation(2, 19);
            // Call the method in the class, specifying the parameters by name
            mathOp.MyOperation(num1: 3, num2: 6);
            Console.ReadLine();
        }
    }
}
