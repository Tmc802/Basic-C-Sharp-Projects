using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethodsCodingExcercises
{
    public class Consecutive
    {
        public static void ConsecutiveNums(string input)
        {
            var userInput = input.Split('-');
            var arr = userInput.ToArray();
            List<int> numList = new List<int>();
            var result = new StringBuilder(" ");

            foreach (var num in arr)
            {
                var item = Convert.ToInt32(num);
                numList.Add(item);
            }

            var stringCount = numList.Count - 1;


            for (int i = 0; i < numList.Count - 1; i++)
                
                if (numList[i] - 1 == numList[i + 1] && numList[i + 1] < numList.Count)
                    stringCount--;
                else
                    break;

            if (stringCount == 0)
                result.Append("These are consecutive numbers");
            else
                result.Append("These are not consecutive numbers");


            Console.WriteLine(result);
        }
    }
}
