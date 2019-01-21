using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
         
          var button = new Stopwatch();
          
          var newStartTime = button.Start();

          button.Stop(newStartTime);
          Console.ReadLine();

        }

        class Stopwatch
        {
            private DateTime startTime { get; set; }
            List<TimeSpan> Durations = new List<TimeSpan>();

            public DateTime Start()
            {
                //create new start time equal to datetime.now
                DateTime startTime = new DateTime();
                startTime = DateTime.Now;

                //take the hours and minutes from the start time and add them into a new variable
                var newStartHour = startTime.Hour;
                var newStartMinute = startTime.Minute;

                var newStartTime = newStartHour + newStartMinute;

                DateTime.TryParse(newStartTime.ToString(), out var officialStartTime);
                
                return officialStartTime;
            }

            public void Stop(DateTime ST)
            {   
                var endTime = DateTime.Now;
                var newEndHour = endTime.Hour;
                var newEndMinute = endTime.Minute;
                var newEndTime = newEndMinute + newEndHour;

                //declare a new variable inline by parsing the in int.ToString()
                // and using an out var to create the datetime object

                DateTime.TryParse(newEndTime.ToString(), out var officialEndTime);

                TimeSpan duration = officialEndTime - ST;
             
                Durations.Add(duration);

                foreach (var durationResult in Durations)
                {
                    Console.WriteLine(durationResult);
                }
            }
        }
    }
}
