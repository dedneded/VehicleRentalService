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
    public partial class SeeService : Form
    {
        Service service = new Service();

        public SeeService(int z)
        {
            InitializeComponent();
            FillForm(service.FindById(z));
        }
        private void FillForm(Service service)
        {
            IDServiceInfo.Text = $"{service.Id}";
            NameServiceInfo.Text = $"{service.Name}";
            DescriptionService.Text = $"{service.Description}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Orders obj = new Orders();
           obj.Show();
        }

        private void SeeService_Load(object sender, EventArgs e)
        {

        }
    }
}
