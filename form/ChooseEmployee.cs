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
    public partial class ChooseEmployee : Form
    {
        public ChooseEmployee()
        {
            InitializeComponent();
        }

        private void DriverAdd_Click(object sender, EventArgs e)
        {
            AddDriver obj = new AddDriver();
            obj.ShowDialog();
        }

        private void ManagerAdd_Click(object sender, EventArgs e)
        {
            AddManager obj = new AddManager();
            obj.ShowDialog();
        }
    }
}
