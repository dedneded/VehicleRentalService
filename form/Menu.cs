using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace form
{
    public partial class Menu : Form
    {

        private int borderSize = 2;
        private Size formSize;
        int currentForm = -1;
        int previousForm = -1;
        Orders ord;
        Clients clients;
        Employees employees;
        Managers managers;
        Drivers drivers;
        Vehicles vehicles;
        Discounts discounts;
        Services services;
        Branches branches;


        public int m;
        public Menu()
        {
            InitializeComponent();
            CollapseMenu();
            FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
        
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
           // Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
            
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
          
          
        }

            private void Menu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.PanelMenu.Width > 200) //Collapse menu
            {
                PanelMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                PanelMenu.Width = 230;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in PanelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        
        private void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
            => DropdownMenu_VisibleChanges(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);

        }
        private void DropdownMenu_VisibleChanges(object sender, EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if(!DesignMode)
            {
                if (dropdownMenu.Visible)
                    ctrl.BackColor = Color.FromArgb(255, 235, 205);
                else ctrl.BackColor = Color.FromArgb(255, 140, 0);
            }
        }
        private void iconWorkers_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(rjDropdownMenu1, sender);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(rjDropdownMenu2, sender);
        }

        private void rjDropdownMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void iconOrders_Click(object sender, EventArgs e)
        {
            previousForm = currentForm;
            currentForm = 0;
            CheckFormClose();
            ord = new Orders();
            ord.MdiParent = this;
            ord.TopLevel = false;
            ord.Dock = DockStyle.Fill;
            ord.FormBorderStyle = FormBorderStyle.None;
            ord.BringToFront();
            this.Height = 900;
            this.Width = 1538; 
            ord.Show();
            
        }

        private void iconClients_Click(object sender, EventArgs e)
        {
            previousForm = currentForm;
            currentForm = 1;
            CheckFormClose();
            clients = new Clients();
            clients.MdiParent = this;
            clients.TopLevel = false;
            clients.Dock = DockStyle.Fill;
            clients.FormBorderStyle = FormBorderStyle.None;
            clients.BringToFront();
            this.Height = 704;
            this.Width = 1062;
            clients.Show();
        }

        private void всеСотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = 0;
            Employee_CreateObj();
        }
        public void Employee_CreateObj()
        {
            employees = new Employees();
            Employee(employees);
        }
        public void Employee(Employees obj)
        {
            previousForm = currentForm;
            currentForm = 2;
            CheckFormClose();
            obj.MdiParent = this;
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.BringToFront();
            this.Height = 888;
            this.Width = 1340;
            obj.Show();
        }

        private void менеджерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previousForm = currentForm;
            currentForm = 3;
            CheckFormClose();
            managers = new Managers();
            managers.MdiParent = this;
            managers.TopLevel = false;
            managers.FormBorderStyle = FormBorderStyle.None;
            managers.Dock = DockStyle.Fill;
            managers.BringToFront();
            this.Height = 861;
            this.Width = 1338;
            managers.Show();
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previousForm = currentForm;
            currentForm = 4;
            CheckFormClose();
            drivers = new Drivers();
            drivers.MdiParent = this;
            drivers.TopLevel = false;
            drivers.FormBorderStyle = FormBorderStyle.None;
            drivers.Dock = DockStyle.Fill;
            drivers.BringToFront();
            this.Height = 827;
            this.Width = 1433;
            drivers.Show();
        }

        private void всяТехникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = 0;
            Vehicle_CreateObj();
        }
        public void Vehicle_CreateObj()
        {
            vehicles = new Vehicles();
            Vehicle(vehicles);
        }
        public void Vehicle(Vehicles obj)
        {
            previousForm = currentForm;
            currentForm = 5;
            CheckFormClose();
            obj.MdiParent = this;
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            obj.BringToFront();
            this.Height = 846;
            this.Width = 1212;
            obj.Show();
        }

        private void землеройнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = 1;
            Vehicle_CreateObj();
        }

        private void дорожноремонтнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = 2;
            Vehicle_CreateObj();
        }

        private void дляВысотныхРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = 3;
            Vehicle_CreateObj();
        }

        private void погрузочнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = 4;
            Vehicle_CreateObj();
        }

        private void дляПеревозкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = 5;
            Vehicle_CreateObj();
        }

        private void коммунальнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = 6;
            Vehicle_CreateObj();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            previousForm = currentForm;
            currentForm = 6;
            CheckFormClose();
            discounts = new Discounts();
            discounts.MdiParent = this;
            discounts.TopLevel = false;
            discounts.FormBorderStyle = FormBorderStyle.None;
            discounts.Dock = DockStyle.Fill;
            discounts.BringToFront();
            this.Height = 766;
            this.Width = 1428;
            discounts.Show();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            previousForm = currentForm;
            currentForm = 7;
            CheckFormClose();
            services = new Services();
            services.MdiParent = this;
            services.TopLevel = false;
            services.FormBorderStyle = FormBorderStyle.None;
            services.Dock = DockStyle.Fill;
            services.BringToFront();
            this.Height = 758;
            this.Width = 1028;
            services.Show();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            previousForm = currentForm;
            currentForm = 8;
            CheckFormClose();
            branches = new Branches();
            branches.MdiParent = this;
            branches.TopLevel = false;
            branches.FormBorderStyle = FormBorderStyle.None;
            branches.Dock = DockStyle.Fill;
            branches.BringToFront();
            this.Height = 669;
            this.Width = 1005;
            branches.Show();
        }
        private void CheckFormClose()
        {
            if(previousForm == 0)
            {
                ord.Close();
            }
            if(previousForm == 1)
            {
                clients.Close();


            }
            if(previousForm == 2)
            {
                employees.Close();
            }
            if(previousForm == 3)
            {
                managers.Close();
            }
            if(previousForm == 4)
            {
                drivers.Close();
            }
            if(previousForm == 5)
            {
                vehicles.Close();
            }
            if(previousForm == 6)
            {
                discounts.Close();
            }
            if(previousForm == 7)
            {
                services.Close();
            }
            if(previousForm == 8)
            {
                branches.Close();
            }
        }
    }
    }
