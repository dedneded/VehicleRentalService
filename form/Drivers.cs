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
    public partial class Drivers : Form
    {
        Branch branch;
        int current_page = 0;
        static int page_count = 0;
        Driver driver = new Driver();
        int[,] list_pages;
        public Drivers()
        {
            InitializeComponent();
            Fill_AllDrivers(null, null);
            Add_AllDrivers(null, null);
            FillForm();
        }


        private void AddDrivers_Click(object sender, EventArgs e)
        {
            AddDriver obj = new AddDriver();
            obj.ShowDialog();
        }

        private void BranchDriversChoose_Click(object sender, EventArgs e)
        {

            Branches obj = new Branches();
            obj.ShowDialog();
            branch = obj.GetResult();
            BranchDrivers.Text = Convert.ToString(branch.Id);
            Filters();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {

        }
        private List<Driver> Get_List(Driver obj1, Driver obj2)
        {

            var obj = driver.GetAllDrivers(obj1, obj2);
            return obj;
        }
        private void FillForm()
        {
            SortingDrivers.Items.Add("Id");
            SortingDrivers.Items.Add("ФИО");
            SortingDrivers.Items.Add("Филиал");
        }

        private void Fill_AllDrivers(Driver obj1, Driver obj2)
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

        private void Add_AllDrivers(Driver obj1, Driver obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
            AllDrivers.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllDrivers.RowCount < 10)
                    {
                        AllDrivers.RowCount++;


                    }
                    Driver item = Get_List(obj1, obj2)[list_pages[current_page, j]];
                    AllDrivers.Rows[q].Cells[0].Value = item.Id;
                    AllDrivers.Rows[q].Cells[1].Value = item.Fio;
                    AllDrivers.Rows[q].Cells[2].Value = item.Phone;
                    AllDrivers.Rows[q].Cells[3].Value = item.DrivingLicense;
                    AllDrivers.Rows[q].Cells[4].Value = item.Branch.Id;

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
            Driver obj = new Driver();
            if (IDDrivers.Text != "")
            {
                obj.Id = int.Parse(IDDrivers.Text);
            }

            obj.Fio = FIODrivers.Text;
            obj.Phone = PhoneDrivers.Text;
            if (BranchDrivers.Text != "")
            {
                obj.Branch = branch;
            }
            if (SalaryDriversFrom.Text != "")
            {
                obj.Salary = decimal.Parse(SalaryDriversFrom.Text);
            }

            Driver obj2 = new Driver();
            if (SalaryDriversTo.Text != "")
            {
                obj2.Salary = decimal.Parse(SalaryDriversTo.Text);
            }
            Fill_AllDrivers(obj, obj2);
            Add_AllDrivers(obj, obj2);

        }

        private void ApplyDrivers_Click(object sender, EventArgs e)
        {
            Filters();
        }

        private void SortingDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortingDrivers.SelectedIndex != -1)
            {

                if (SortingDrivers.SelectedItem.ToString() == "Id")
                {
                    this.AllDrivers.Sort(this.AllDrivers.Columns[0], ListSortDirection.Ascending);
                }
                if (SortingDrivers.SelectedItem.ToString() == "ФИО")
                {
                    this.AllDrivers.Sort(this.AllDrivers.Columns[1], ListSortDirection.Ascending);
                }
                if (SortingDrivers.SelectedItem.ToString() == "Филиал")
                {
                    this.AllDrivers.Sort(this.AllDrivers.Columns[4], ListSortDirection.Ascending);
                }
            }
        }

        private void ResetDrivers_Click(object sender, EventArgs e)
        {
            Fill_AllDrivers(null, null);
            Add_AllDrivers(null, null);
            SortingDrivers.SelectedIndex = -1;
        }

        private void SortDesc_Drivers_Click(object sender, EventArgs e)
        {
            if (SortingDrivers.SelectedItem != null){
                if (SortingDrivers.SelectedItem.ToString() == "Id")
                {
                    this.AllDrivers.Sort(this.AllDrivers.Columns[0], ListSortDirection.Descending);
                }
                if (SortingDrivers.SelectedItem.ToString() == "ФИО")
                {
                    this.AllDrivers.Sort(this.AllDrivers.Columns[1], ListSortDirection.Descending);
                }
                if (SortingDrivers.SelectedItem.ToString() == "Филиал")
                {
                    this.AllDrivers.Sort(this.AllDrivers.Columns[4], ListSortDirection.Descending);
                }
            }
           
        }
        public Driver GetResult()
        {
            return driver;
        }
      

       

        private void ChooseDrivers_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(AllDrivers.Rows[AllDrivers.CurrentRow.Index].Cells[0].Value);
            driver = driver.FindByIdDriver(z);
            this.Close();
        }

        private void AllDrivers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = Convert.ToInt32(AllDrivers.Rows[AllDrivers.CurrentRow.Index].Cells[0].Value);
            SeeDriver obj = new SeeDriver(z);
            obj.ShowDialog();
        }

        private void ChooseDrivers_MouseEnter(object sender, EventArgs e)
        {
            ChooseDrivers.BackColor = Color.White;
            ChooseDrivers.ForeColor = Color.DarkOrange;
            ChooseDrivers.FlatAppearance.BorderSize = 3;
        }

        private void ChooseDrivers_MouseLeave(object sender, EventArgs e)
        {
            ChooseDrivers.BackColor = Color.DarkOrange;
            ChooseDrivers.ForeColor = Color.White;
            ChooseDrivers.FlatAppearance.BorderSize = 0;
        }

        private void AddDrivers_MouseEnter(object sender, EventArgs e)
        {
            AddDrivers.BackColor = Color.White;
            AddDrivers.ForeColor = Color.DarkOrange;
            AddDrivers.FlatAppearance.BorderSize = 3;
        }

        private void AddDrivers_MouseLeave(object sender, EventArgs e)
        {
            AddDrivers.BackColor = Color.DarkOrange;
            AddDrivers.ForeColor = Color.White;
            AddDrivers.FlatAppearance.BorderSize = 0;
        }

        private void ApplyDrivers_MouseEnter(object sender, EventArgs e)
        {
            ApplyDrivers.BackColor = Color.DarkOrange;
            ApplyDrivers.ForeColor = Color.White;
            ApplyDrivers.FlatAppearance.BorderSize = 0;
        }

        private void ApplyDrivers_MouseLeave(object sender, EventArgs e)
        {
            ApplyDrivers.BackColor = Color.White;
            ApplyDrivers.ForeColor = Color.DarkOrange;
            ApplyDrivers.FlatAppearance.BorderSize = 2;
        }

        private void ResetDrivers_MouseEnter(object sender, EventArgs e)
        {
            ResetDrivers.BackColor = Color.DarkOrange;
            ResetDrivers.ForeColor = Color.White;
            ResetDrivers.FlatAppearance.BorderSize = 0;
        }

        private void ResetDrivers_MouseLeave(object sender, EventArgs e)
        {
            ResetDrivers.BackColor = Color.White;
            ResetDrivers.ForeColor = Color.DarkOrange;
            ResetDrivers.FlatAppearance.BorderSize = 2;
        }
    }
}
