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
    public partial class AddDriver : Form
    {
      
        Branch branch;
        Role role;
        public AddDriver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
        {

        }

        private void BranchDriverChoose_Click(object sender, EventArgs e)
        {
            
            Branches obj = new Branches();
            obj.ShowDialog();
            branch = obj.GetResult();
            BranchDriver.Text = branch.Address;
        }

        private void All_CheckedChanged(object sender, EventArgs e)
        {
            if (All.Checked)
            {
                C.Checked = true;
                C1.Checked = true;
                CE.Checked = true;
                C1E.Checked = true;
            }
            else 
            {
                C.Checked = false;
                C1.Checked = false;
                CE.Checked = false;
                C1E.Checked = false;
            }
          
        }

        private void SaveDriver_Click(object sender, EventArgs e)
        {
            Driver item = new Driver();
            List<int> list =  new List <int>();
            item.Fio = FIODriver.Text;
            item.Phone = PhoneDriver.Text;
            item.DrivingLicense = DrivingLicense.Text;
            item.BranchId = branch.Id;
            item.RoleId = role.Id;
            
          
    

            if (All.Checked)
            {
                list.Add(0);
                list.Add(1);
                list.Add(2);
                list.Add(3);
               
            }
            else
            {
                if (C.Checked)
                {
                    list.Add(0);
                }
                if(C1.Checked)
                {
                    list.Add(2);
                }
                if(C1E.Checked)
                {
                    list.Add(3);
                }
                if(CE.Checked)
                {
                    list.Add(1);
                }
            }
            item.AddDriver(list);
        }

        private void RoleChoose_Click(object sender, EventArgs e)
        {
            Roles obj = new Roles();
            obj.ShowDialog();
            role = obj.GetResult();
            RoleName.Text = role.Name;
        }

        private void RoleName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Role_Click(object sender, EventArgs e)
        {

        }
    }
}
