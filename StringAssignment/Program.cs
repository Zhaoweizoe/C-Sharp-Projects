using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenating three strings
            string str1 = "Hello, ";
            string str2 = "good morning!";
            string str3 = " how are you?";
            string concatenatedString = str1 + str2 + str3;
            Console.WriteLine("Concatenated string: " + concatenatedString);

            // Converting a string to uppercase
            string originalString = "hello world";
            string upperCaseString = originalString.ToUpper();
            Console.WriteLine("Uppercase string: " + upperCaseString);

            // Creating a StringBuilder and building a paragraph of text
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("This is the first sentence. ");
            paragraph.Append("This is the second sentence. ");
            paragraph.Append("This is the third sentence.");
            Console.WriteLine("Paragraph of text:");
            Console.WriteLine(paragraph.ToString());
        }
    }
}
