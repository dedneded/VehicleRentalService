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
    public partial class SeeDriver : Form
    {
        Driver driver = new Driver();
        public SeeDriver(int z)
        {
            InitializeComponent();
            driver = driver.FindByIdDriver(z);
            FillForm(driver);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FillForm(Driver driver)
        {
            List<int> list;
            IDDriverInfo.Text = $"{driver.Id}";
            FIODriverInfo.Text = $"{driver.Fio}";
            PhoneDriverInfo.Text = $"{driver.Phone}";
            LisenceDriverInfo.Text = $"{driver.DrivingLicense}";
            list = driver.FindDrivingCaregories(driver);
            foreach (int item in list)
            {
                if (list.Count == 3)
                {
                    All.Checked = true;
                    break;
                }
                else
                {
                if(item == 0)
                {
                        C.Checked = true;
                }
                if(item == 1)
                {
                        CE.Checked = true;

                }
                if(item == 2)
                {
                        C1.Checked = true;
                }
                if(item == 3)
                {
                        C1E.Checked = true;
                }
                }
            }
            BranchDriverInfo.Text = $"{driver.Branch.Address}";
        }

        private void InfoOrderDriver_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
        }

        private void SeeDriver_Load(object sender, EventArgs e)
        {

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

        private void TimeTableDriver_Click(object sender, EventArgs e)
        {

            TimeTables obj = new TimeTables(driver);
            obj.ShowDialog();
        }
    }
}
