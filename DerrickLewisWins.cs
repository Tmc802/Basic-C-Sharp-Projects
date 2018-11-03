using System;

namespace WhileWithBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("As of November 2nd 2018 how many career wins does Derrick Lewis have as a professional mixed martial artist?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool winsGuessed = number == 21;

            do
            {
                switch (number)
                {
                    case 15:
                        Console.WriteLine("You're close!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 30:
                        Console.WriteLine("You're way over!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 21:
                        Console.WriteLine("You're right! Derrick Lewis is currently 21-5-0 & 1 NC in the UFC!");
                        winsGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Nope! Keep guessing!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!winsGuessed);

            Console.Read();
        }
    }
}
