using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class MyClass
    {
       
        public enum DaysOfTheWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        public static void Day(DayOfWeek day)
        {
            switch (day)
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
                    break;
            }
        }
    }
}
