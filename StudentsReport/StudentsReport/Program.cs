using System;

namespace StudentsReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the name of the institution.
            Console.WriteLine("Academy of Learning Career College");
            // Display the title of the report.
            Console.WriteLine("Student Daily Report");
            // Prompt the user to input their name and store it in the variable 'name'.
            Console.WriteLine("What is your name?");
            string name= Console.ReadLine();
            // Prompt the user to input the course they are on and store it in the variable 'course'.
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            // Prompt the user to input the page number and convert it to an integer, storing it in 'pageNum'.
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            // Prompt the user to indicate if they need help and parse their response into a boolean value.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            // Prompt the user to share any positive experiences and store their response.
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
            string positiveExperiences = Console.ReadLine();
            // Prompt the user for any additional feedback and store their response.
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            string feedback = Console.ReadLine();
            // Prompt the user to input the number of hours they studied and convert it to an integer.
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            // Display a closing message.
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            // Wait for the user to press Enter before closing the console window.
            Console.ReadLine();
        }
    }
}
