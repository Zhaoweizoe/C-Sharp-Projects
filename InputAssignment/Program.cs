using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Please enter a number:");

            // Read the user input
            string userInput = Console.ReadLine();

            // Log the number to a text file
            LogNumberToFile(userInput);

            // Print the contents of the text file back to the user
            PrintLogFileContents();
        }

        // Function to log the number to a text file
        static void LogNumberToFile(string number)
        {
            // Define the path for the text file (you can change this to your desired path)
            string filePath = "number_log.txt";

            // Open the file in append mode and write the number to it
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(number);
            }

            Console.WriteLine("Number logged to file successfully.");
        }

        // Function to print the contents of the text file back to the user
        static void PrintLogFileContents()
        {
            // Define the path for the text file
            string filePath = "number_log.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the file and print them to the console
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("Contents of the log file:");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Log file not found.");
            }
        }
    }
}
