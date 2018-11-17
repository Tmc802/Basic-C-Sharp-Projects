using System;
using System.IO;

namespace filesInsOuts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string text = Console.ReadLine();

            File.WriteAllText(@"/Users/tmc802/Desktop/Step\ 154\ drill", text);

            Console.WriteLine(@"/Users/tmc802/Desktop/Step\ 154\ drill");
        }
    }
}