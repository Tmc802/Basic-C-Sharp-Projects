using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveRepeatedLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string RemoveDuplicates(string input)
            {
                string Result = new string(input.ToCharArray().Distinct().ToArray());
                Console.WriteLine(Result); 
                return Result;
            }

            string removeLetters = "Mississippi";

            RemoveDuplicates(removeLetters);
            Console.ReadLine();
        }
    }
}
