using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_VS_Composition
{
    public class Animal
    {
        public string _name { get; private set; }
        public int _howManyLegs { get; private set; }

        // setter legs
        public int howManyLegs(int legs)
        {
            _howManyLegs = legs;
            return _howManyLegs;
        }

        // getter legs
        public int legCount()
        {
            return _howManyLegs;
        }

        public string description()
        {
            string legDesc;

            if (_howManyLegs == 2)
            {
                legDesc = "This animal is bipedal ";
            }
            else if (_howManyLegs == 4)
            {
                legDesc = "This animal is a quadraped ";
            }
            else
            {
                legDesc = "This animal is probably a weird ass bug, kill it with fire";
            }

            return legDesc;
        }

        // setter name
        public string setName(string name)
        {
            _name = name;
            return _name;
        }

        // getter name
        public string getName()
        {
            return _name;
        }




        public string Classification(string animal)
        {
            string family;

            if (animal == "Homosapien")
            {
                family = " This animal is a human being";
            }
            else if (animal == "Feline")
            {
                family = " This animal is part of the feline family";
            }
            else if (animal == "K9")
            {
                family = " This animal is part of the K9 family";
            }
            else
            {
                family = " This animal must be part of the Amphibian species";
            }

            return family;
        }
    }
}
