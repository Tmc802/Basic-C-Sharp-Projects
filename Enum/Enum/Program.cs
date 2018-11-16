using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch for format exception handling
            try
            {
                //Prompt user for current day
                Console.WriteLine("Please enter the current day of the week");
                string day = Console.ReadLine();
                int currentDay = Convert.ToInt32(day);

                int Day = (int)DayOfWeek.Friday;
                Console.WriteLine(currentDay);

                switch (currentDay)
                {
                    case DayOfWeek.Monday:
                        Console.WriteLine("It is Monday.");
                        break;
                    case DayOfWeek.Tuesday:
                        Console.WriteLine("It is Tuesday.");
                        break;
                    case DayOfWeek.Wednesday:
                        Console.WriteLine("It is Wednesday.");
                        break;
                    case DayOfWeek.Thursday:
                        Console.WriteLine("It is Thursday.");
                        break;
                    case DayOfWeek.Friday:
                        Console.WriteLine("It is Friday.");
                        break;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("It is Saturday.");
                        break;
                    case DayOfWeek.Sunday:
                        Console.WriteLine("It is Sunday.");
                        break; */
            }



            } catch (FormatException) 
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
           
            // day method to return the entry to the user
        }
    }
}


/*

1. Create an enum for the days of the week.

2. Prompt the user to enter the current day of the week.

3. Assign the value to a variable of that enum data type you just created.

4. Wrap the above statement in a try/catch block and have it print 
"Please enter an actual day of the week." to the console if an error occurs.

*/
