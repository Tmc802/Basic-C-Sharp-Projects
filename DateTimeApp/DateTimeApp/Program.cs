using System;
using System.IO;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("It is currently " + DateTime.Now);

            //prompt user for a number to add onto current DateTime
            Console.WriteLine("Please enter a number");
            string userEntry = Console.ReadLine();

            // Convert the string to an int
            int time = Convert.ToInt32(userEntry);
            
            // set current date to variable
            DateTime date = DateTime.Now;

            // set timespan to new variable and add user entry to new timespan
            TimeSpan userHour = new TimeSpan (0,time,0,0);

            // combine current date and user entry
            DateTime result = date + userHour;

            // log result
            Console.WriteLine(result);
        }
    }
}
