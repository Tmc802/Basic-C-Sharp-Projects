using System;

namespace CarInsuranceApprovalForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageAnswer = Console.ReadLine();
            int ageAnswer1 = Convert.ToInt32(ageAnswer);

            // applicant must be over 15 years old

            Console.WriteLine("Have you ever had a DUI? (Please answer True or False)");
            string trueOrFalse = Console.ReadLine();
            bool hadDui = Convert.ToBoolean(trueOrFalse);

            // applicants must not have any DUI's

            Console.WriteLine("How many speeding tickets do you have?");
            string numOfSpeedingTix = Console.ReadLine();
            int numOfSpeedtix = Convert.ToInt32(numOfSpeedingTix);

            // applicants must no more than 3 speeding tickets

            Console.WriteLine("Qualified?");
            Console.WriteLine(ageAnswer1 > 15 && hadDui == false && numOfSpeedtix <= 3);

        }
    }
}
