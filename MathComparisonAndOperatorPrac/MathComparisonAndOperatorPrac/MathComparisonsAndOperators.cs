using System;

namespace MathComparisonAndOperatorPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiple an int by 50
            Console.WriteLine("Enter a number here!: ");
            string numToMult = Console.ReadLine();
            int num1 = Convert.ToInt32(numToMult);
            int num2 = 50;
            Console.WriteLine(num1 + " multipled by 50 is....");
            int total = (num1 * num2);
            Console.WriteLine(total+ "!");

            // add 25 to the input
            Console.WriteLine("Enter a number here!: ");
            string numToAdd = Console.ReadLine();
            int num3 = Convert.ToInt32(numToAdd);
            int num4 = 25;
            Console.WriteLine(num3 + " plus 25 is....");
            int total2 = (num3 + num4);
            Console.WriteLine(total2 + "!");

            //divide by 12.5
            Console.WriteLine("Enter a number with a decimal here!: ");
            string numToDiv = Console.ReadLine();
            float num5 = Single.Parse(numToDiv);
            float num6 = 12.5f;
            Console.WriteLine(num5 + " divided by 12.5 is....");
            float total3 = (num5 / num6);
            Console.WriteLine(total3 + "!");

            //Check if the input is greater than 50
            Console.WriteLine("Enter a number here and i'll tell you if it's greater than 50!: ");
            string numToCheck = Console.ReadLine();
            int num7 = Convert.ToInt32(numToCheck);
            int num8 = 50;
            bool trueOrFalse = num7 > num8;
            Console.WriteLine(trueOrFalse);

            //print the remainder
            Console.WriteLine("Enter a number here!: ");
            string numToDiv2 = Console.ReadLine();
            float num9 = Single.Parse(numToDiv2);
            float num10 = 7;
            Console.WriteLine("The remainder of " + num9 + " divided by 7 is....");
            float total4 = (num9 % num10);
            Console.WriteLine(total4 + "!");

        }
    }
}
