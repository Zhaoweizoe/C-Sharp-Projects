using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable.
            const string const1 = "Your name is:";
            const string const2 = "Your favourite number is:";
            Console.WriteLine("Enter your name of favourite number:");
            //Create a variable using the keyword “var.”
            var answer = Console.ReadLine();
            if (float.TryParse(answer,out float x))
            {
                Console.WriteLine(const2);
                Chain newChain = new Chain(x);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}
