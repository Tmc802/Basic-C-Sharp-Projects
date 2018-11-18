using System;

namespace MoreExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            bool validAnswer = false;
            int userAge = 0;

            try
            {

                while (!validAnswer && userAge <= 0)
                {
                    Console.WriteLine("What is your age?");
                    validAnswer = int.TryParse(Console.ReadLine(), out userAge);
                    if (!validAnswer) Console.WriteLine("Please enter only digits and no decimals");
                }
                if (userAge < 0) {
                    throw new GeneralException();
                }

                Console.WriteLine("You are " + userAge + " years old.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter digits only.");
            }
            catch (GeneralException)
            {
                Console.WriteLine("An error has occured. Please try again.");
                return;
            }
        }
    }
}


/*1. Ask the user for his age.

2. Display the year user born.

3. Exceptions must be handled using "try .. catch".

4. Display appropriate error messages if user enters zero or negative numbers.

5. Display a general message if exception caused by anything else. */
