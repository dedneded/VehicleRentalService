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
    public partial class FormMainMenu : Form
    {
        
        public FormMainMenu()
        {
            InitializeComponent();
            
            WindowState = FormWindowState.Maximized;
            PanelEmployees.Visible = false;
            PanelVehicle.Visible = false;
      

    }
        
        private void hideSubMenu()
        {
            PanelEmployees.Visible = false;
            PanelVehicle.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
       
        private void buttonOrders_Click(object sender, EventArgs e)
            {

            Orders ord = new Orders();
            ord.MdiParent = this;
            ord.TopLevel = false;
            ord.FormBorderStyle = FormBorderStyle.None;
            ord.Dock = DockStyle.Fill;
            ord.BringToFront();
            ord.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.MdiParent = this;
            cl.TopLevel = false;
            cl.FormBorderStyle = FormBorderStyle.None;
            cl.Dock = DockStyle.Fill;
            cl.BringToFront();
            cl.Show();
        }

        private void buttonVehicle_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelVehicle);
            //Vehicles vh = new Vehicles();
            //vh.MdiParent = this;
            //vh.TopLevel = false;
            //vh.FormBorderStyle = FormBorderStyle.None;
            //vh.Dock = DockStyle.Fill;
            //vh.BringToFront();
            //vh.Show();



        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelEmployees);
            //Employees em = new Employees();
            //em.MdiParent = this;
            //em.TopLevel = false;
            //em.FormBorderStyle = FormBorderStyle.None;
            //em.Dock = DockStyle.Fill;
            //em.BringToFront();
            //em.Show();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees em = new Employees();
            em.MdiParent = this;
            em.TopLevel = false;
            em.FormBorderStyle = FormBorderStyle.None;
            em.Dock = DockStyle.Fill;
            em.BringToFront();
            em.Show();

        }
    }
    }

