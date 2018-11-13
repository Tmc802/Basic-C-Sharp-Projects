using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = 2;

            // user chooses a number to divide by
            Console.WriteLine("Choose a number.");
            // string conversion to int to pass through method
            string userInput = Console.ReadLine();
            int userNum = Convert.ToInt32(userInput);

            // call method on user choosen number
            MyMethod.Method(userNum, out res);
            //log result to console
            Console.WriteLine(res);
            Console.ReadLine();


            // methoded was overloaded. Call the second method.
            decimal res2 = 2;

            // user chooses another number to divide by
            Console.WriteLine("Choose a number.");
            // string conversion to int to pass through method
            string userInput2 = Console.ReadLine();
            int userNum2 = Convert.ToInt32(userInput);

            // call method on user choosen number
            MyMethod.Method(userNum2, out res2);
            //log result 2 to console
            Console.WriteLine(res2);
            Console.ReadLine();
        }
    }
}

