using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    public static class MyNumber
    {
        public static int Math(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public static int Math(decimal a, decimal b)
        {
            // Convert var a from decimal to int
            int num1 = Convert.ToInt32(a);

            // Convert var b from decimal to int
            int num2 = Convert.ToInt32(b);
           
            return num1 - num2;

        }

        public static int Math(string a, string b) 
        {
            string a = Console.ReadLine();
            int num1 = Convert.ToInt32(a);

            string b = Console.ReadLine();
            int num2 = Convert.ToInt32(b);


            return num1 / num2;
        }


    }
}
