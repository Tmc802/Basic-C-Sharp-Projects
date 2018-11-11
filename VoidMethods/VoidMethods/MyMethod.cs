using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    public class MyMethod
    {
        public static void Add(int a, int b) {
            a++;
            Console.WriteLine(b);
            Console.WriteLine(a);
            return;
        }
         
    }
}
