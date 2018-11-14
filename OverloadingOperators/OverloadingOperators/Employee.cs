using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    public class Employee
    {
        public int Id { get; set; }

        public static Employee operator== (Employee employee, Employee employee2)
        {
            return employee == employee2;
        }

        public static Employee operator !=(Employee employee, Employee employee2)
        {
            return employee != employee2;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
