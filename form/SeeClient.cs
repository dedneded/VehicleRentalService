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
    public partial class SeeClient : Form
    {
        Client client = new Client();
        public SeeClient(int id)
        {
            InitializeComponent();
            client = client.FindById(id);
            FillForm(client);
            
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void FillForm(Client client)
        {
            CommClient.ReadOnly = true;
            IDClientsInfo.Text = client.Id.ToString();
            FIOClientInfo.Text = client.Fio;
            PhoneClientInfo.Text = client.Phone;
            CommClient.Text = client.Comment;
            QuantityOrders.Text = client.GetClientOrders().ToString();
        }

        private void QuantityOrdersInfo_Click(object sender, EventArgs e)
        {
        List<Order> ordersOfClient = client.GetOrderOfClient();

            Orders obj = new Orders(ordersOfClient);
            obj.ShowDialog();
        }

        private void SeeClient_Load(object sender, EventArgs e)
        {

        }

        private void DelClient_Click(object sender, EventArgs e)
        {
            client.DelClient();

        }

        private void ChangeClientInfo_Click(object sender, EventArgs e)
        {
            AddClient obj = new AddClient(client);
            obj.ShowDialog();
        }

        private void SeeClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                    "Вы действительно хотите выйти?",
                    "Выход",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
            if (dialog == DialogResult.Yes)
            {

                e.Cancel = false;

            }
            if (dialog == DialogResult.No) { e.Cancel = true; }
        }
    }
}
