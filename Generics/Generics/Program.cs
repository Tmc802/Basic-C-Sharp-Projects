using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            // instantiate list type string
            Employee<string> employee = new Employee<string>();

             employee.Things = new List<string> {"List" , "Of", "strings"};


             // instantiate list type int
             Employee<int> employee2 = new Employee<int>();

             employee2.Things = new List<int> {12, 30, 15, 25 };


            // iterates string list of things
            foreach (string item in employee.Things)
            {
                Console.WriteLine(item);
            }

            // iterate int list of things
            foreach (int item in employee2.Things) {
                Console.WriteLine(item);
            }
        }
     }
}
