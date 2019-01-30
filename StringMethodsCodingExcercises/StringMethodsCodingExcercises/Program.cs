using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethodsCodingExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a few numbers separated 
            //by a hyphen.Work out if the numbers are consecutive.
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            //display a message: "Consecutive"; otherwise, display "Not Consecutive".

            var stringListInput = "12-11-10-9-8-7-6-10-4-3-2-1-0";
            Consecutive.ConsecutiveNums(stringListInput);
        }
    }

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
                if (numList[i] - 1 == numList[i + 1]  && numList[i + 1] < numList.Count)
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
