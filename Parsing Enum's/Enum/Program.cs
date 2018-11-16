using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prompt user for current day
            Console.WriteLine("Please enter the current day of the week");
            string userDay = Console.ReadLine();

            try
            {
                //enum parse to user entry
                Enum.Parse(typeof(DayOfWeek), userDay);
                Console.WriteLine("Correct! today is " + userDay);
            }   

            // initiate catch exceptions
            catch (FormatException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            } 
            catch (ArgumentException) 
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
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
