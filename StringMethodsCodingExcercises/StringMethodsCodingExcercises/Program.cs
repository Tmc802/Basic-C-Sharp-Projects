using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
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

            //var stringListInput = "12-11-10-9-8-7-6-10-4-3-2-1-0";
            //Consecutive.ConsecutiveNums(stringListInput);

            // 2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            // If the user simply presses Enter, without supplying an input, exit immediately;
            // otherwise, check to see if there are duplicates. If so,
            // display "Duplicate" on the console.




        Console.WriteLine("Please enter a few numbers separated by hyphen");
        var userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                    Environment.Exit((0));
            }
            else
            {
                
                var inputArr = userInput.Split('-').ToArray();
                var duplicate = " ";

                for (var i = 0; i <= inputArr.Length - 1; i++)
                {
                    var j = i + 1;

                    while (j < inputArr.Length - 1)
                    {
                        if (inputArr[i] != inputArr[j] && j <= inputArr.Length - 1)
                        {
                            Console.WriteLine(j + "\n");
                            j++;
                        }

                        

                        if (inputArr[i] == inputArr[j])
                        {
                            duplicate += "This set contains duplicates";
                            break;
                        }
                        else if (i == inputArr.Length - 1)
                        {
                            duplicate += "This set does not contain duplicates";
                            break;
                        }
                            
                    }
                }

                Console.WriteLine(duplicate);
                Console.ReadLine();
            }
        }
    }
}

