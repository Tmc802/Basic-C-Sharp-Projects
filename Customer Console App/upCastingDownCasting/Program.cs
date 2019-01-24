using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace upCastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            var quitCount = 0;
            while (quitCount == 0)
            {
                Console.WriteLine("Please enter an item(s) you'd like to order");
                var itemOrdered = Console.ReadLine();

                if (itemOrdered == "quit")
                {
                    quitCount++;
                }


                List<string> newOrder = new List<string> { itemOrdered };
                foreach (var item in newOrder)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You've ordered " + item);
                }

                Console.ReadLine();
            }
           

        }

        class Customer
        {
            public string Order { get; set; }
            public string FirstName { get; set; }
            public int OrderId { get; set; }
            public string Address { get; set; }
            readonly List<string> _allOrders = new List<string>();

            public void Customers(string order)
            {
                if (order != null)
                {
                    _allOrders.Add(order);
                }

                foreach (var Order in _allOrders)
                {
                    Console.WriteLine(Order);
                }
            }
        }
    }
}
