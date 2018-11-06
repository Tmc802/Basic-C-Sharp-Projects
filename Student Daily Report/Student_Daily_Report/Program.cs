using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student daily Report");

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();


            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            string questionHelp = Console.ReadLine();
            bool quesHelp = Convert.ToBoolean(questionHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string questionExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string questionFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string numOfHours = Console.ReadLine();
            int numHours = Convert.ToInt32(numOfHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        }
    }
}
