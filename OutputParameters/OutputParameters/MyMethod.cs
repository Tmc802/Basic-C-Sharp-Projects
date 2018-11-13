using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    public static class MyMethod
    {

        public static void Method(int a, out int res) {
            res = a / 2;
        }

        public static void Method(decimal b, out decimal res2)
        {
            res2 = b / 2;
        }

    }
}
