using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContControls.Model
{
    public class Employee
    {
        public string FirstName, LastName, Id;

        public Employee()
        {

        }

        public IEnumerable<Employee> GetInitialEmployees()
        {
            return new List<Employee>() { new Employee() { FirstName="Suraj", LastName="Dev", Id="10"},
            new Employee() { FirstName="Riya", LastName="Dev", Id="101"},
            new Employee() { FirstName="Vijay", LastName="Dev", Id="110"}
            };
        }

        public override string ToString()
        {
            return $"{FirstName} | {LastName} | {Id}";
        }
    }
}
