using System;
using System.Collections.Generic;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Array

            string[] nameArray = new string[] { "Tyler", "Kyle", "Roger", "Rick" };

            Console.WriteLine("Select an item from the array using number 0-3");
            // assign the user entry to a variable
            string userSelection = Console.ReadLine();

            // convert the string variable to an int so it will pass through the if statement
            int elementSelection = Convert.ToInt32(userSelection);

            // if statement reads the entry and passes back the list selection
            if (elementSelection > 0 && elementSelection <= 3) {
                // Select string value using input value
                string stringSelection = nameArray[elementSelection];
                Console.WriteLine("You've chosen the name " + stringSelection);
            } else {
                Console.WriteLine("You've chosen an invalid number. Please try again.");
            }

            // end string array


            // int array

            int[] intArray = new int[] { 25, 16, 15, 10 };

            Console.WriteLine("Select an item from the array using number 0-3");

            // assign the user entry to a variable
            string userSelection2 = Console.ReadLine();

            // convert the string variable to an int so it will pass through the if statement
            int elementSelection2 = Convert.ToInt32(userSelection2);

            // if statement reads the entry and passes back the list selection
            if (elementSelection2 >= 0 && elementSelection2 <= 3) {
                // Select string value using input value
                int stringSelection2 = intArray[elementSelection2];

                Console.WriteLine("You've chosen the number " + stringSelection2);
            } else {
                Console.WriteLine("You've chosen an invalid number! Please try again.");
            }

            // End int array


            // List/Generic query

            List<string> stringList = new List<string>() { "grapes", "apples", "bananas", "apricots", "cherries" };

            Console.WriteLine("Select an item from your grocery list using number 1-4");

            //assign the user entry to a variable
            string userSelection3 = Console.ReadLine();

            // convert the string variable to an int so it will pass through the if statement
            int elementSelection3 = Convert.ToInt32(userSelection3);

            // if statemenet reads the entry and passes back the list selection
            if (elementSelection3 > 0 && elementSelection3 <= 3) {

                // pass the int into the block pass back the list selection
                string stringSelection3 = stringList[elementSelection3];
                Console.WriteLine("Don't forget the " + stringSelection3 + "!");
            } else {
                Console.WriteLine("You've chosen an invalid number. Please try again.");
            }

            // End list/generic query

        }
    }
}
