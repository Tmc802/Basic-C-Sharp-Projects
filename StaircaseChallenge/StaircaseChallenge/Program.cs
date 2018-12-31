using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaircaseChallenge;

namespace StaircaseChallenge
{
    class Program
    {
        static void Main(string[] args)
        {


            void Staircase(int N)
            {
                for (int i = 0; i < N; i++)
                    Console.WriteLine(new String('#', i + 1).PadLeft(N, ' '));
            }

            int n = 100;

            Staircase(n);

            Console.ReadLine();


            Console.WriteLine(" " + " " + " " + " " + " " + "#");
            Console.WriteLine(" " + " " + " " + " " + "#" + "#");
            Console.WriteLine(" " + " " + " " + "#" + "#" + "#");
            Console.WriteLine(" " + " " + "#" + "#" + "#" + "#");
            Console.WriteLine(" " + "#" + "#" + "#" + "#" + "#");
            Console.WriteLine("#" + "#" + "#" + "#" + "#" + "#");


            Console.ReadLine();
        }
    }
}
