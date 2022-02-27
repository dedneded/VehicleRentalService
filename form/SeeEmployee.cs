using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class SeeEmployee : Form
    {
        Employee employee = new Employee();
        public SeeEmployee(int z)
        {
            InitializeComponent();
            FillForm(employee.FindById(z));
        }
        private void FillForm(Employee employee)
        {
            IDEmployeeInfo.Text = $"{employee.Id}";
            FIOEmployeeInfo.Text = $"{employee.Fio}";
            PhoneEmployeeInfo.Text = $"{employee.Phone}";
            RoleEmployeeInfo.Text = $"{employee.Role.Name}";
            BranchEmployeeInfo.Text = $"{employee.Branch.Address}";

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void InfoOrdersEmployee_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
        }

        private void SeeEmployee_Load(object sender, EventArgs e)
        {

        }

        private void TimeTableEmployee_Click(object sender, EventArgs e)
        {
            //TimeTables obj = new TimeTables();
            //obj.ShowDialog();
        }
    }
}
