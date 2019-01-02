using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCcountTheOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, write a method to total the odd numbers. 

            int[] myArr = new int[] { 20, 40, 4, 2, 103, 407, 27, 35 };

            int CountOdds(int[] x)
            {
                List<int> emptyList = new List<int> { };

                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] % 2 > 0)
                    {
                        emptyList.Add(i);
                    }
                }             

                Console.WriteLine(emptyList.Count);
                return emptyList.Count;
            }

            CountOdds(myArr);

            Console.ReadLine();
        }
    }
}
