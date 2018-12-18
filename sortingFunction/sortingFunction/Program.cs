using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingFunction
{
    class Program :myFunction
    {
        static void Main(string[] args)
        {
            myFunction function1 = new myFunction();
            string A = "XXoO";
            bool result = function1.SortXo(A);


            Console.WriteLine(result);
            Console.ReadLine();
        }

        
    }
}
