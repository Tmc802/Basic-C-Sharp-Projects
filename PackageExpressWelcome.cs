using System;

namespace WelcomePackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("Enter your package's weight:");
            string packageWeight = Console.ReadLine();
            int packWeight = Convert.ToInt32(packageWeight);

            if (packWeight > 50) {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            Console.WriteLine("Enter your package's width:");
            string packageWidth = Console.ReadLine();
            int packWidth = Convert.ToInt32(packageWidth);

            Console.WriteLine("Enter your package's height:");
            string packageHeight = Console.ReadLine();
            int packHeight = Convert.ToInt32(packageHeight);

            Console.WriteLine("Enter your package's Length:");
            string packageLength = Console.ReadLine();
            int packLength = Convert.ToInt32(packageLength);

            int dimensions = packLength * packHeight * packWidth / 100;

            if (packLength*packHeight*packWidth/100 > 50) {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            } else if (packLength * packHeight * packWidth / 100 <= 50) {
                Console.WriteLine("Your estimated total for shipping this package is:"+ "$" + dimensions + " Thank you.");
            }


        }
    }
}
