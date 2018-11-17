using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // create initial list of employees to search through
            List<Employee> employeeList = new List<Employee>();

                employeeList.Add(new Employee
                {
                    FirstName = "Joe",
                    LastName = "Jonas",
                    Id = 1
                });

                employeeList.Add(new Employee
                {
                    FirstName = "Benni",
                    LastName = "Benassi",
                    Id = 2
                });

                employeeList.Add(new Employee
                {
                    FirstName = "Rick",
                    LastName = "Ricardo",
                    Id = 3
                });

                employeeList.Add(new Employee
                {
                    FirstName = "Ethan",
                    LastName = "Allen",
                    Id = 4
                });

                employeeList.Add(new Employee
                {
                    FirstName = "Tiger",
                    LastName = "Woods",
                    Id = 5
                });

                employeeList.Add(new Employee
                {
                    FirstName = "Conor",
                    LastName = "McGregor",
                    Id = 6
                });

                employeeList.Add(new Employee
                {
                    FirstName = "Ryan",
                    LastName = "Renyolds",
                    Id = 7
                });

                employeeList.Add(new Employee
                {
                    FirstName = "Joe",
                    LastName = "McCarthy",
                    Id = 8
                });

                employeeList.Add(new Employee
                {
                    FirstName = "Joe",
                    LastName = "Right",
                    Id = 9
                });

                employeeList.Add(new Employee
                {
                    FirstName = "Allen",
                    LastName = "Iverson",
                    Id = 10
                });





            // Create a new list with employees that have the first name Joe
            List<Employee> employeeJoe = new List<Employee>();

            // use a foreach loop to instantiate a new list
            foreach (Employee employee in employeeList) {
                if (employee.FirstName == "Joe") {
                    employeeJoe.Add(new Employee{FirstName = employee.FirstName, 
                        LastName = employee.LastName, Id = employee.Id});
                }
            }

            Console.WriteLine("Press a key to continue");
            Console.ReadLine();






            // instead use a lambda expression to find the employees with the name Joe

            List<Employee> newList = employeeList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }









            // create a list with employee id's greater than 5
            List<Employee> listIdGreaterThan5 = employeeList.Where(x => x.Id >= 5).ToList();

            //run through list printing them to the console 
            foreach (Employee employee in listIdGreaterThan5)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
            }



            Console.WriteLine("Press a key to continue");
            Console.ReadLine();
            
        }
    }
}
