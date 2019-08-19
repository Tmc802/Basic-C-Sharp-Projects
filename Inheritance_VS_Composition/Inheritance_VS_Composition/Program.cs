using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_VS_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tyler = new Animal();
            Tyler.howManyLegs(2);
            Tyler.setName("Tyler");

            Console.WriteLine(Tyler.description() + $"{"(" + Tyler.legCount() + " legs)"}" + Tyler.Classification("Homosapien") + $"{", His name is " + Tyler.getName()}");
            Console.ReadLine();

            var Brady = new Animal();
            Brady.howManyLegs(4);
            Brady.setName("Brady");

            Console.WriteLine(Brady.description() + $"{"(" + Brady.legCount() + " legs)"}" + Brady.Classification("K9") + $"{", His name is " + Brady.getName()}");
            Console.WriteLine();

            var centipede = new Animal();

            Console.ReadLine();
        }
    }
}
