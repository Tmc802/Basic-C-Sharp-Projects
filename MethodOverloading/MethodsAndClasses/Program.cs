using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNumber num = new MyNumber();

            //Method Add
            num.A = 3;
            num.B = 9;

            num.Math(num.A,num.B);

            //Method Subtract
            num.C = 3;
            num.D = 7;
            num.Math(num.C, num.D);

            //Method Divide
            num.C = 3;
            num.D = 7;
            num.Math(num.C, num.D);
        }
    }
}

