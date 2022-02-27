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
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void SaveService_Click(object sender, EventArgs e)
        {
            Service obj = new Service();
            obj.Name = NameService.Text;
            obj.Description = DescriptionService.Text;
            obj.AddService();
        }
    }
}
