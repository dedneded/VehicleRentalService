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
    public partial class Orders : Form
    {
        int current_page = 0;
        static int page_count = 0;
        Order order = new Order();
        int[,] list_pages;
        bool checkOrdersOfClient = false;
        List<Order> listOrdersOfCleint = new List<Order>();
        public Orders(bool m)
        {
        if(m)
        {
                InitializeComponent();
               
                Fill_AllOrders(null, null);
                Add_AllOrders(null, null);
            }
           
        }
        public Orders()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Fill_AllOrders(null, null);
            Add_AllOrders(null, null);
        }
        public Orders(List<Order> listOdrersOfClients)
        {
            this.listOrdersOfCleint = listOdrersOfClients;
            InitializeComponent();
            checkOrdersOfClient = true;
            Fill_AllOrders(null, null);
            Add_AllOrders(null, null);
            
        }






        private void AddOrders_Click(object sender, EventArgs e)
        {
            AddOrder obj = new AddOrder();
            obj.Show();
        }

        private void ChangeClientOrders_Click(object sender, EventArgs e)
        {
            Clients obj = new Clients();
            obj.Show();
        }

        private void ChangeDriverOrders_Click(object sender, EventArgs e)
        {
            Drivers obj = new Drivers();
            obj.Show();
        }

        private void ChangeVehicleOrders_Click(object sender, EventArgs e)
        {
            Vehicles obj = new Vehicles();
            obj.Show();
        }

        private void ChangeBranchOrders_Click(object sender, EventArgs e)
        {
            Branches obj = new Branches();
            obj.Show();
        }

        private List<Order> Get_List(Order obj1, Order obj2)
        {

            var obj = order.GetAll(obj1, obj2);
            return obj;
        }

        private void Fill_AllOrders(Order obj1, Order obj2)
        {
            List<Order> list = new List<Order>();
        if(checkOrdersOfClient)
        {
                list = listOrdersOfCleint;
        }
        else
        {
                list = Get_List(obj1, obj2);
        }
            page_count = (list.Count) / 10;
            if (list.Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = list.Count - 1;
            for (int i = 0; i <= page_count - 1; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (y >= 0)
                    {

                        list_pages[i, j] = y;
                        y--;

                    }
                    else
                    {
                        list_pages[i, j] = -1;
                        i = page_count - 1;
                        break;
                    }
                }
            }

        }

        private void Add_AllOrders(Order obj1, Order obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
            List<Order> list = new List<Order>();
            if (checkOrdersOfClient)
            {
                list = listOrdersOfCleint;
            }
            else
            {
                list = Get_List(obj1, obj2);
            }
            AllOrders.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllOrders.RowCount < 10)
                    {
                        AllOrders.RowCount++;


                    }
                    Order item = list[list_pages[current_page, j]];
                    AllOrders.Rows[q].Cells[0].Value = item.Id;
                    AllOrders.Rows[q].Cells[1].Value = item.Start;
                    AllOrders.Rows[q].Cells[2].Value = item.End;
                    AllOrders.Rows[q].Cells[3].Value = item.Client.Fio;
                    AllOrders.Rows[q].Cells[4].Value = item.Price;
                    // AllOrders.Rows[q].Cells[3].Value = item.Status;


                    q++;

                }
                else
                {

                    AllOrders.Rows.RemoveAt(AllOrders.Rows.Count - 1);

                    break;

                }

            }

        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void AllOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = Convert.ToInt32(AllOrders.Rows[AllOrders.CurrentRow.Index].Cells[0].Value);
            SeeOrder obj = new SeeOrder(z);
            obj.ShowDialog();
        }
        public Order Get_Result()
        {
            return order;
        }

        private void ChooseOrders_Click(object sender, EventArgs e)
        {
            
            int z = Convert.ToInt32(AllOrders.Rows[AllOrders.CurrentRow.Index].Cells[0].Value);
            order = order.FindById(z);
            this.Close();
        }

        private void FiltersOrders_Enter(object sender, EventArgs e)
        {

        }

        private void ChooseOrders_MouseEnter(object sender, EventArgs e)
        {
            ChooseOrders.BackColor = Color.White;
            ChooseOrders.ForeColor = Color.DarkOrange;
            ChooseOrders.FlatAppearance.BorderSize = 3;
        }

        private void ChooseOrders_MouseLeave(object sender, EventArgs e)
        {
            ChooseOrders.BackColor = Color.DarkOrange;
            ChooseOrders.ForeColor = Color.White;
            ChooseOrders.FlatAppearance.BorderSize = 0;
        }

        private void AddOrders_MouseEnter(object sender, EventArgs e)
        {
            AddOrders.BackColor = Color.White;
            AddOrders.ForeColor = Color.DarkOrange;
            AddOrders.FlatAppearance.BorderSize = 3;
        }

        private void AddOrders_MouseLeave(object sender, EventArgs e)
        {
            AddOrders.BackColor = Color.DarkOrange;
            AddOrders.ForeColor = Color.White;
            AddOrders.FlatAppearance.BorderSize = 0;
        }

        private void AllFilters_MouseEnter(object sender, EventArgs e)
        {
            AllFilters.BackColor = Color.DarkOrange;
            AllFilters.ForeColor = Color.White;
            AllFilters.FlatAppearance.BorderSize = 0;
        }

        private void AllFilters_MouseLeave(object sender, EventArgs e)
        {
            AllFilters.BackColor = Color.White;
            AllFilters.ForeColor = Color.DarkOrange;
            AllFilters.FlatAppearance.BorderSize = 2;
        }

        private void ApplyOrders_MouseEnter(object sender, EventArgs e)
        {
            ApplyOrders.BackColor = Color.DarkOrange;
            ApplyOrders.ForeColor = Color.White;
            ApplyOrders.FlatAppearance.BorderSize = 0;
        }

        private void ApplyOrders_MouseLeave(object sender, EventArgs e)
        {
            ApplyOrders.BackColor = Color.White;
            ApplyOrders.ForeColor = Color.DarkOrange;
            ApplyOrders.FlatAppearance.BorderSize = 2;
        }

        private void ResetOrders_MouseEnter(object sender, EventArgs e)
        {
            ResetOrders.BackColor = Color.DarkOrange;
            ResetOrders.ForeColor = Color.White;
            ResetOrders.FlatAppearance.BorderSize = 0;
        }

        private void ResetOrders_MouseLeave(object sender, EventArgs e)
        {
            ResetOrders.BackColor = Color.White;
            ResetOrders.ForeColor = Color.DarkOrange;
            ResetOrders.FlatAppearance.BorderSize = 2;
        }
    }
}
