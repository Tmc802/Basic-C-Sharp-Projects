using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengesConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            var userInput5 = Console.ReadLine();
            int input = Convert.ToInt32(userInput5);
            var howManyNums = new HowManyNumbers(input);

            List<int> total = new List<int>();
            int exitCount = 0;
            while (exitCount == 0)
            {
                Console.WriteLine("Enter a number. Enter Ok to exit the program and view the total of the entered digits.");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "ok")
                {
                    var result = total.Sum();
                    Console.WriteLine("Your final value is " + result + " Press any key to finish the program");
                    Console.ReadLine();
                    exitCount++;
                }
                else
                {
                    int userNum = Convert.ToInt32(userInput);
                    total.Add(userNum);
                }
            }

            Console.WriteLine("Please enter a number");
            string userInput2 = Console.ReadLine();
            int userNum2 = Convert.ToInt32(userInput2);
            var fact = userNum2;

            for (var i = userNum2 - 1; i >= 1; i--)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);
            Console.ReadLine();


            int guessAttempts = 4;
            int correctGuesses = 0;
            var randomNum = new Random();
            int randomNumber = randomNum.Next(10);

            while (correctGuesses < 1 && guessAttempts != 0)
            {
                Console.WriteLine("Pick a number between 1 and 10");
                string userInput3 = Console.ReadLine();
                int userNum3 = Convert.ToInt32(userInput3);

                if (userNum3 == randomNumber)
                {
                    Console.WriteLine("\n Correct! You've won!!! \n");
                    correctGuesses++;
                }
                else if (userNum3 != randomNumber)
                {
                    guessAttempts--;
                    Console.WriteLine("Sorry, that is incorrect. You now have " + guessAttempts + " guess attempts remaining... \n");

                    if (guessAttempts == 0)
                    {
                        Console.WriteLine("\n You've Lost!! \n");
                    }
                }
            }

            Console.WriteLine("Please enter a series of numbers separated by comma's");
            var input4 = Console.ReadLine();

            var numbers = input4.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("Max is " + max);
            Console.ReadLine();
        }   
    }
}

    class HowManyNumbers
    {
        public HowManyNumbers(int a)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % a == 0)
                {
                    Console.WriteLine(i + " is dividable by " + a);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    

