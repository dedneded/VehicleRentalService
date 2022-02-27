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
    public partial class AddBranch : Form
    {
        Branch branch;
        public AddBranch()
        {
            InitializeComponent();
            branch = new Branch();
        }
        public AddBranch(int s)
        {

            InitializeComponent();
            branch = branch.FindById(s);
        }
        

        private void SaveBranch_Click(object sender, EventArgs e)
        {
            branch.Phone = PhoneBranch.Text;
            branch.Address = $"{CityBranch.Text}, {StreetBranch.Text}, {HomeBranch.Text}";
            branch.AddBranch();
        }
        

        private void AddBranch_Load(object sender, EventArgs e)
        {

        }
    }
}
