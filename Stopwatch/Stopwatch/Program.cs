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


          
            

        }

        class Stopwatch
        {
            private DateTime startTime { get; set; }
            List<TimeSpan> Durations = new List<TimeSpan>();

            public DateTime Start()
            {
                DateTime startTime = new DateTime();
                var newStartHour = startTime.Hour;
                var newStartMinute = startTime.Minute;
                var newStartTime = newStartHour + newStartMinute;
                DateTime officialStartTime = Convert.ToDateTime(newStartTime);
                return officialStartTime;
            }

            public void Stop(DateTime ST)
            {   
                var endTime = DateTime.Now;
                var newEndHour = endTime.Hour;
                var newEndMinute = endTime.Minute;
                var newEndTime = newEndMinute + newEndHour;

                
                DateTime timeEnd = Convert.ToDateTime(endTime);

                TimeSpan duration = timeEnd - ST;
             
                Durations.Add(duration);

                foreach (var durationResult in Durations)
                {
                    Console.WriteLine(durationResult);
                }
            }
        }
    }
}
