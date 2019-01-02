using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Reverse(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(charArray);
                return new string(charArray);
            }

            string mySentence = "The Quick Brown Fox Jumps Over The Fence";

            Reverse(mySentence);
            Console.ReadLine();
        }
    }
}
