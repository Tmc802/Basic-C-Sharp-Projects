using System;
using System.Collections.Generic;

namespace LoopsAndArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array and add a users input to the array


            string[] names = new string[5];
            names[0] = "Tyler";
            names[1] = "Kyle";
            names[2] = "Mike";
            names[3] = "Paul";



            Console.WriteLine("Please enter a name here");
            string userEntry = Console.ReadLine();
            names[4] = userEntry;


            //create a loop that cycles through the array with the added user entry
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }



            Console.WriteLine("Press any key to enter an infinite loop");
            Console.ReadLine();


            /*create an infinite loop*/
            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("infinite loop");
            }

            //loop operators

            for (int j = 0; j < 100; j++)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();

            for (int k = 0; k <= 100; k++)
            {
                Console.WriteLine(k);
            }

            Console.ReadLine();

            //List loops
            List<string> fruits = new List<string>()
            { "strawberries", "banana","peaches" };



            Console.WriteLine("please enter text to search for in the list");
            string userEntry2 = Console.ReadLine();

            if (userEntry2 != "strawberries" && userEntry2 != "banana" && userEntry2 != "peaches")
            {
                Console.WriteLine("your selection was not found in the list");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                foreach (string fruit in fruits)
                {
                    Console.WriteLine(fruit + " " + fruits.IndexOf(fruit));
                    Console.WriteLine(" ");

                    if (userEntry2 == fruit)
                    {
                        Console.WriteLine("You've found the " + fruit + " " + "at index " + fruits.IndexOf(fruit));
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }



            //identical strings list

                       List<string> breeds = new List<string>()
                       { "collie", "pitbull", "collie", "lab" };



            Console.WriteLine("please enter text to search for in the list");
            string userEntry3 = Console.ReadLine();


            if (userEntry3 != "collie" && userEntry3 != "pitbull" && userEntry3 != "lab")
            {
                Console.WriteLine("your selection was not found in the list");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {

                foreach (string breed in breeds)
                {
                    Console.WriteLine(breed + " " + breeds.IndexOf(breed));
                    if (userEntry3 == breed)
                    {
                        Console.WriteLine("this entry has already appeared in the list");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
            Console.ReadLine();

            List<string> animals = new List<string>()
            { "bird", "dog", "cow", "horse", "bird" };

            foreach (string animal in animals)
            {
                            Console.WriteLine(animal.LastIndexOf("bird"));
                if(animal.IndexOf("bird") == animal.LastIndexOf(animal))
                {
                    Console.WriteLine("This animal has appeared on this list before");
                } else
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
