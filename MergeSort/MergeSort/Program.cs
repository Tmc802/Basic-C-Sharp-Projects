using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMergeSort();
            Console.ReadLine();
        }

        private static void TestMergeSort()
        {
            int[] numbers = {2, 5, 6, 1};

            numbers.DoMergeSort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number + " ");
            }
        }
    }
}
