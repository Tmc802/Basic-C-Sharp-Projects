using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers. 

            int[] myArray = new int[] { 1000, 874, 254, 600, 212 };



            int FindTheSum(int[] arr)
            {
                List<int> intList = new List<int>() { };

                foreach (int item in arr)
                {
                    intList.Add(item);
                }

                Console.WriteLine(intList.Sum());
                return intList.Sum();
            }
            FindTheSum(myArray);
            Console.ReadLine();
        }
    }
}
