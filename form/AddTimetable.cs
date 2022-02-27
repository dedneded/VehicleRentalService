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
    public partial class AddTimetable : Form
    {
        public AddTimetable()
        {
            InitializeComponent();
        }

        private void Timetable_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeChoose_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
        }
    }
}
