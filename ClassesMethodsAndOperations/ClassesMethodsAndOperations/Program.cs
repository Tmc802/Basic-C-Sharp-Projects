using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAndOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            //Method 1 Add


            //User chooses a number
            Console.WriteLine("Choose a number to add onto");
            string userSelection = Console.ReadLine();
            int userNum = Convert.ToInt32(userSelection);

            //User chooses a second number
            Console.WriteLine("Choose a second number");
            string userSelection2 = Console.ReadLine();
            int userNum2 = Convert.ToInt32(userSelection2);
         
            // user inputs enter the method and returns a result
            int result = MyNumber.Add(userNum,userNum2);
            Console.WriteLine(result);

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();







            //Method 2 Sub

            //User chooses a number
            Console.WriteLine("Choose a number to subtract from");
            string userSelection3 = Console.ReadLine();
            int userNum3 = Convert.ToInt32(userSelection3);

            //User chooses a second number
            Console.WriteLine("Choose a second number");
            string userSelection4 = Console.ReadLine();
            int userNum4 = Convert.ToInt32(userSelection4);


            // user inputs enter the method and returns a result
            int result2 = MyNumber.Sub(userNum3, userNum4);
            Console.WriteLine(result2);

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();








            //Method 3 Divide

            //User chooses a number
            Console.WriteLine("Choose a number to divide");
            string userSelection5 = Console.ReadLine();
            int userNum5 = Convert.ToInt32(userSelection5);

            //User chooses a second number
            Console.WriteLine("Choose a second number");
            string userSelection6 = Console.ReadLine();
            int userNum6 = Convert.ToInt32(userSelection6);


            // user inputs enter the method and returns a result
            int result3 = MyNumber.Divide(userNum5, userNum6);
            Console.WriteLine(result3);
            Console.ReadLine();
        }




    }
}
