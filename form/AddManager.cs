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
    public partial class AddManager : Form
    {
        Branch branch;
        Role role;
        public AddManager()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void BranchEmployeeChoose_Click(object sender, EventArgs e)
        {
            Branches obj = new Branches();
            obj.ShowDialog();
            branch = obj.GetResult();
            BranchEmployee.Text = branch.Address;
            
        }

        private void SaveEmployee_Click(object sender, EventArgs e)
        {
            Manager item = new Manager();
            item.Fio = FIOEmployee.Text;
            item.Phone = PhoneEmployee.Text;
            item.BranchId = branch.Id;
            item.RoleId = role.Id;
            item.AddManager();
        }

        private void RoleChooseManager_Click(object sender, EventArgs e)
        {
            Roles obj = new Roles();
            obj.ShowDialog();
            role = obj.GetResult();
            RoleNameManager.Text = role.Name;
        }
    }
}
