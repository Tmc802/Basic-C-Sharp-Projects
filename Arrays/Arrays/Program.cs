using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 4, 1, 10, 3, 5, 7, 3};

            Console.WriteLine("Length: " + numbers.Length);

            //indexOf
            var index = Array.IndexOf(numbers, 7);
            Console.WriteLine("Index of 7: " + index);

            //Array.Clear(numbers, 0, 0);

            Console.WriteLine("Effect of clear()");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            //copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy() \n");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n");

            //Sort
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
