using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number");
            string userInput = Console.ReadLine();
            int num1 = Convert.ToInt32(userInput);

            Console.WriteLine("Choose a second number. You can leave it blank as well.");
            string userInput2 = Console.ReadLine();

            if (userInput2 == "")
            {
                Console.WriteLine(num1);
            }
            else
            {
                int num2 = Convert.ToInt32(userInput2);
                MyMethod.Math(num1, num2);
            }
            Console.ReadLine();
            

        }
    }
}