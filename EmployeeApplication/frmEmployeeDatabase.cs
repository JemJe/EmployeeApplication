using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(employeeID.Text, employeeFirstName.Text, employeeLastName.Text, employeePosition.Text);

            dataGridView1.Rows.Add(emp.emp_id, emp.emp_firstName, emp.emp_lastName, emp.emp_position);

            employeeID.Clear();
            employeeFirstName.Clear();
            employeeLastName.Clear();
            employeePosition.Clear();
        }
    }
}
