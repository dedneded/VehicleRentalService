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
            PanelService.Visible = false;
           
        }
        public int m;

        private void hideSubMenu()
        {
            PanelEmployees.Visible = false;
            PanelVehicle.Visible = false;
            PanelService.Visible = false;
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
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelEmployees);

        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void AllEmployees_Click(object sender, EventArgs e)
        {
            m = 0;
            Employee_CreateObj();
        }
        public void Employee(Employees obj)
        {
            obj.MdiParent = this;
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.BringToFront();
            obj.Show();
        }
        public void Employee_CreateObj()
        {
            Employees obj = new Employees();
            Employee(obj);
        }

        private void Managers_Click(object sender, EventArgs e)
        {
            Managers obj = new Managers();
            obj.MdiParent = this;
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.BringToFront();
            obj.Show();
        }

        private void Drivers_Click(object sender, EventArgs e)
        {
            Drivers em = new Drivers();
            em.MdiParent = this;
            em.TopLevel = false;
            em.FormBorderStyle = FormBorderStyle.None;
            em.Dock = DockStyle.Fill;
            em.BringToFront();
            em.Show();
        }

        private void AllServices_Click(object sender, EventArgs e)
        {
            Service_CreateObj();
        }

        public void Service(Services obj)
        {
            obj.MdiParent = this;
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.BringToFront();
            obj.Show();
        }
        public void Service_CreateObj()
        {
            Services obj = new Services();
            Service(obj);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Services_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelService);
        }

       

        private void AllVehicle_Click(object sender, EventArgs e)
        {
            m = 0;
            Vehicle_CreateObj();
        }

        public void Vehicle(Vehicles obj)
        {
            obj.MdiParent = this;
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.BringToFront();
            obj.Show();
        }

        private void Earthmoving_Click(object sender, EventArgs e)
        {
            m = 1;
            Vehicle_CreateObj();
        }

        private void Municipal_Click(object sender, EventArgs e)
        {
            m = 2;
            Vehicle_CreateObj();
        }

        private void Handling_Click(object sender, EventArgs e)
        {
            m = 3;
            Vehicle_CreateObj();
        }

        private void Delivery_Click(object sender, EventArgs e)
        {
            m = 4;
            Vehicle_CreateObj();
        }

        private void Road_Click(object sender, EventArgs e)
        {
            m = 5;
            Vehicle_CreateObj();
        }
        public void Vehicle_CreateObj()
        {
            Vehicles obj = new Vehicles();
            Vehicle(obj);
        }

        private void ButtonDiscounts_Click(object sender, EventArgs e)
        {
            Discounts obj = new Discounts();
            obj.MdiParent = this;
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.BringToFront();
            obj.Show();
        }

        private void Rent_Click(object sender, EventArgs e)
        {
            m = 0;
            Vehicle_CreateObj();
        }

        private void Drivers_Service_Click(object sender, EventArgs e)
        {
            m = 1;
            Employee_CreateObj();
        }

        private void Delivery_Service_Click(object sender, EventArgs e)
        {
            m = 2;
            Employee_CreateObj();
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            m = 3;
            Employee_CreateObj();
        }

        private void ButtonBranches_Click(object sender, EventArgs e)
        {
            Branches cl = new Branches();
            cl.MdiParent = this;
            cl.TopLevel = false;
            cl.FormBorderStyle = FormBorderStyle.None;
            cl.Dock = DockStyle.Fill;
            cl.BringToFront();
            cl.Show();
        }
    }
}

