using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // begin exception handling try/catch block
            try
            {
                // List creation of integers
                List<int> intList = new List<int>() { 2, 4, 6, 8, 10 };

                // Ask the user to select a number to divide by
                Console.WriteLine("Select a number to divide into each number in the list by entering it in the line below");

                //Convert the user input into an integer so it can divde the list series by the user input
                string userNum = Console.ReadLine();
                int userInput = Convert.ToInt32(userNum);

                // use foreach loop to run through the list
                foreach (int num in intList)
                {
                    // this line displays the listed number divded by the user input
                    Console.WriteLine(num / userInput);
                }
                // exception to divding by zero
            } catch (DivideByZeroException) {
                Console.WriteLine("Please don't divide by zero");
                // exception to dividing by a string or improper format
            } catch (FormatException) {
                Console.WriteLine("Please type a whole number");
            } finally {
                Console.ReadLine();
            }
        }
    }
}
