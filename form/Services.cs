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
    public partial class Services : Form
    {
        bool check;
        int current_page = 0;
        static int page_count = 0;
        Service service = new Service();
        int[,] list_pages;
        List<Service> list = new List<Service>();
        public Services(bool m)
        {
            InitializeComponent();
            Fill_AllServices(null, null);
            Add_AllServices(null, null);
            check = m;
            FillForm();

        }
        public Services()
        {
            InitializeComponent();
            Fill_AllServices(null, null);
            Add_AllServices(null, null);
            check = false;
            FillForm();

        }

        private void Services_Load(object sender, EventArgs e)
        {

        }
        private void FillForm()
        {
            if (check)
            {

                AllServices.Columns[0].Visible = true;
            }
            else{
                AllServices.Columns[0].Visible = false;
            }
            SortingServices.Items.Add("Id");
            SortingServices.Items.Add("Название");
        }

        private void AddServices_Click(object sender, EventArgs e)
        {
            AddService obj = new AddService();
            obj.ShowDialog();
        }
        private List<Service> Get_List(Service obj1, Service obj2)
        {

            var obj =service.GetAll(obj1, obj2);
            return obj;
        }
        private void Fill_AllServices(Service obj1, Service obj2)
        {
            page_count = (Get_List(obj1, obj2).Count) / 10;
            if (Get_List(obj1, obj2).Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = Get_List(obj1, obj2).Count - 1;
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

        private void Add_AllServices(Service obj1, Service obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
            AllServices.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllServices.RowCount < 10)
                    {
                        AllServices.RowCount++;


                    }
                    Service item = Get_List(obj1, obj2)[list_pages[current_page, j]];
                    AllServices.Rows[q].Cells[1].Value = item.Id;
                    AllServices.Rows[q].Cells[2].Value = item.Name;



                    q++;

                }
                else
                {



                    break;

                }

            }

        }
        private void Filters()
        {
            Service obj = new Service();
            if (IDServices.Text != "")
            {
                obj.Id = int.Parse(IDServices.Text);
            }

            obj.Name = NameServices.Text;
           
            Service obj2 = new Service();
            Fill_AllServices(obj, obj2);
            Add_AllServices(obj, obj2);
        }

        private void SortingServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortingServices.SelectedIndex != -1)
            {

                if (SortingServices.SelectedItem.ToString() == "Id")
                {
                    this.AllServices.Sort(this.AllServices.Columns[0], ListSortDirection.Ascending);
                }
                if (SortingServices.SelectedItem.ToString() == "Название")
                {
                    this.AllServices.Sort(this.AllServices.Columns[1], ListSortDirection.Ascending);
                }
               
            }
        }

        private void SortDescServices_Click(object sender, EventArgs e)
        {
            if (SortingServices.SelectedIndex != -1)
            {
                if (SortingServices.SelectedItem.ToString() == "Id")
            {
                this.AllServices.Sort(this.AllServices.Columns[0], ListSortDirection.Descending);
            }
            if (SortingServices.SelectedItem.ToString() == "Название")
            {
                this.AllServices.Sort(this.AllServices.Columns[1], ListSortDirection.Descending);
            }
           }
        }

        private void ApplyService_Click(object sender, EventArgs e)
        {
            Filters();
        }

        private void ResetServices_Click(object sender, EventArgs e)
        {
            Fill_AllServices(null, null);
            Add_AllServices(null, null);
            SortingServices.SelectedIndex = -1;
            
        }

       
        private void ChooseServices_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= AllServices.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(AllServices.Rows[i].Cells[0].Value) == true)
                {

                    list.Add(service.FindById(Convert.ToInt32(AllServices.Rows[i].Cells[1].Value)));
                }
            }
            this.Close();
        }
        public List<Service> GetAllServices()
        {
            return list;
        }

        private void AllServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = Convert.ToInt32(AllServices.Rows[AllServices.CurrentRow.Index].Cells[1].Value);
            SeeService obj = new SeeService(z);
            obj.ShowDialog();
        }

        private void ChooseServices_MouseEnter(object sender, EventArgs e)
        {
            ChooseServices.BackColor = Color.White;
            ChooseServices.ForeColor = Color.DarkOrange;
            ChooseServices.FlatAppearance.BorderSize = 3;
        }

        private void ChooseServices_MouseLeave(object sender, EventArgs e)
        {
            ChooseServices.BackColor = Color.DarkOrange;
            ChooseServices.ForeColor = Color.White;
            ChooseServices.FlatAppearance.BorderSize = 0;
        }

        private void AddServices_MouseEnter(object sender, EventArgs e)
        {
            AddServices.BackColor = Color.White;
            AddServices.ForeColor = Color.DarkOrange;
            AddServices.FlatAppearance.BorderSize = 3;
        }

        private void AddServices_MouseLeave(object sender, EventArgs e)
        {
            AddServices.BackColor = Color.DarkOrange;
            AddServices.ForeColor = Color.White;
            AddServices.FlatAppearance.BorderSize = 0;
        }

        private void ApplyService_MouseEnter(object sender, EventArgs e)
        {
            ApplyService.BackColor = Color.DarkOrange;
            ApplyService.ForeColor = Color.White;
            ApplyService.FlatAppearance.BorderSize = 0;
        }

        private void ApplyService_MouseLeave(object sender, EventArgs e)
        {
            ApplyService.BackColor = Color.White;
            ApplyService.ForeColor = Color.DarkOrange;
            ApplyService.FlatAppearance.BorderSize = 2;
        }

        private void ResetServices_MouseEnter(object sender, EventArgs e)
        {
            ResetServices.BackColor = Color.DarkOrange;
            ResetServices.ForeColor = Color.White;
            ResetServices.FlatAppearance.BorderSize = 0;
        }

        private void ResetServices_MouseLeave(object sender, EventArgs e)
        {
            ResetServices.BackColor = Color.White;
            ResetServices.ForeColor = Color.DarkOrange;
            ResetServices.FlatAppearance.BorderSize = 2;
        }
    }
}
