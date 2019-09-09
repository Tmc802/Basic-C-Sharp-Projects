using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_C.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Palindrome */
            string wordOne = "APPLE";
            string wordTwo = "ROTAVATOR";
            string wordThree = "SERRES";

            bool palindrome(string word)
            {
                var result = word.SequenceEqual(word.Reverse());
                return result;
            }

            Console.WriteLine(palindrome(wordOne));
            Console.WriteLine(palindrome(wordTwo));
            Console.WriteLine(palindrome(wordThree));

            Console.ReadLine();
        }
    }
}
