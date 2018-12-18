using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingFunction
{
    class myFunction
    {
        public bool SortXo(string A)
        {
            //create counters
            int countX = 0;
            int countO = 0;

            for(int i = 0; i <= A.Length - 1; i++)
            {
                if (A[i] == 'O' || A[i] == 'o')
                {
                    countO++;
                } else if (A[i] == 'X' || A[i] == 'x')
                {
                    countX++;
                }
            }

            return (countO == countX) ? true:false;
        }
    }
}
