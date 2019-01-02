using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

                                // FizzBuzz! \\

            // Write a function that returns the numbers 1-100
            // if the number is divisible by 3 the function should write fizz
            // if the number is divisible by 5 the function should write buzz
            // If it is a multiple of both 3 and 5 the function should return FizzBuzz!

            int a = 3;
            int b = 5;

            FizzBuzz(a,b);

            int FizzBuzz(int c, int d)
            {
                for(int i = 1; i <= 100; i++)
                {
                    if (i % c == 0 && i % d == 0)
                    {
                        Console.WriteLine("FizzBuzz!");
                    }
                    else if (i % c == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % d == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                return 0;
            }
            Console.ReadLine();
        }
    }
}
