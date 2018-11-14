using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods
{
    public class Employee : Person
    {
        public override void SayName() {
            Console.WriteLine(FirstName + LastName);
        }

    }
}
/*
5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.
*/