using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tyler";
            string phrase = "Welcome to the Tech Academy ";
            int age = 25;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("My name is Tyler");

            Console.WriteLine("Hello What is your name?");
            Console.WriteLine(sb);
            Console.WriteLine(phrase + name);
            name = name.ToUpper();
            Console.WriteLine("Hello " + name + " Can you tell me how old you are?");
            Console.WriteLine("Sure! I am " + age + " Years old.");


            Console.ReadLine();




        }
    }
}
