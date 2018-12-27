using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostRecurringNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[]
            {
                1,3,4,6,7,9
            };

            int[] B = new int[]
            {
                1,2,4,5,9,10
            };

            int p1 = 0;
            int p2 = 0;

            var result = new List<int>();

            while (p1 < A.Length && p2 < B.Length)
            {
                if (A[p1] == B[p2])
                {
                    result.Add(p1);
                    p1+=1;
                    p2+=1;
                }
                else if (A[p1] > B[p2])
                {
                    p2 += 1;
                }
                else
                {
                    p1 += 1;
                }
            }
            foreach(int item in result)
            {
                Console.WriteLine(result.Contains(0));
            }
            
            Console.ReadLine();
            
        }
    }
}
