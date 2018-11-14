using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class Person
            Person person = new Person();
            person.FirstName = "Tyler ";
            person.LastName = "McIntyre";
            string FullName = person.FirstName + person.LastName;
            person.SayName();

            // instantiate class Employee
            Employee employee = new Employee();
            employee.FirstName = "Sample ";
            employee.LastName = "Student";
            employee.SayName();

        }
    }
}
