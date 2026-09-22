using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public class Employee
    {
        private string empId;
        private string firstName;
        private string lastName;   
        private string position;

        public Employee(string epmId, string firstName, string lastName, string position)
        {
            this.empId = epmId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }

        public string emp_id
        {
            get
            {
                return this.empId;
            }
            set
            {
                this.emp_id = value;
            }
        }
        public string emp_firstName {
            get
            {
                return this.firstName;
            }
            set   
            { 
                this.emp_firstName = value;
            } 
        }
        public string emp_lastName { 
            get 
            {
                return this.lastName;      
            }
            set
            {
                this.emp_lastName = value;
            } 

        }
        public string emp_position 
        { 
            get
            {
                return this.position;
            }
            set
            {
                this.emp_position = value;
            } 
        }
    }
}
