using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    public class MyNumber
    {

        public int A { get; set; }
        public int B { get; set; }
        public decimal C { get; set; }
        public decimal D { get; set; }
        public string E { get; set; }
        public string F { get; set; }

        public int Math(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public int Math(decimal a, decimal b)
        {
            // Convert var a from decimal to int
            int num1 = Convert.ToInt32(a);

            // Convert var b from decimal to int
            int num2 = Convert.ToInt32(b);
           
            Console.WriteLine(num1 - num2);
            return num1 - num2;
        }

        public int Math(string a, string b) 
        {
            // Convert var a from string to int
            int num1 = Convert.ToInt32(a);

            // Convert var a from string to int
            int num2 = Convert.ToInt32(b);

            Console.WriteLine(num1 / num2);
            return num1 / num2;


        }


    }
}
