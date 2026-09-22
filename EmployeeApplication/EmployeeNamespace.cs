using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public class Employee
    {
        public string empId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string position { get; set; }

        public Employee(string epmId, string firstName, string lastName, string position)
        {
            this.empId = epmId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
    }
}
