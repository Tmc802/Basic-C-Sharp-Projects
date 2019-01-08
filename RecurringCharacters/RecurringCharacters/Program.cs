using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurringCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLetterD = 2;
            int countLetterB = 2;
            int countLetterC = 2;

            //Write a function that sends back the first recurring character
            string[] setOne = new string[] { "D", "D", "C", "C" };

            // Should be C in this case, will change when order is switched


            //iterates through the array
            for (int i = 0; i < setOne.Length; i++)
            {
                if (setOne[i] == setOne[0])
                {
                    countLetterD--;
                    //Console.WriteLine("The Letter D has occured " + countLetterD + " time(s)");
                }
                else if (setOne[i] == setOne[1])
                {
                    countLetterB--;
                    //Console.WriteLine("The Letter B has occured " + countLetterB + " time(s)");
                }
                else if (setOne[i] == setOne[2])
                {
                    countLetterC--;
                    //Console.WriteLine("The Letter C has occured " + countLetterC + " time(s)");
                }

   
               
                    
            }

            //checks if the letter count is equal to 2
            if (countLetterB == 0)
            {
                Console.WriteLine("B is the First Recurring Character");
            }
            else if (countLetterC == 0)
            {
                Console.WriteLine("C is the First Recurring Character");
            }
            else if (countLetterD == 0)
            {
                Console.WriteLine("D is the First Recurring Character");
            }
            else
            {
                Console.WriteLine("There is no recurring character");
            }
            Console.ReadLine();
        }
    }
}

