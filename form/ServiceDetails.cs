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
    public partial class ServiceDetails : Form
    {
        Vehicle vehicle;
        Employee employee;
        List<Vehicle> listvehicles = new List<Vehicle>();
        List<Employee> listemployees = new List<Employee>();
        
        bool k;
        int current_page = 0;
        static int page_count = 0;
        int[,] list_pages;
        public ServiceDetails()
        {
            InitializeComponent();
        }
        public ServiceDetails(List<Vehicle> listVehicle, List<Employee> listEmployee)
        {
            InitializeComponent();
            listvehicles = listVehicle;
            listemployees = listEmployee;
            bool n;
            if(listVehicle.Count != 0)
            {
                Fill_Grid(listvehicles);
                 n = true;
                Add_VehiclesCart(VehiclesDetails, n);
            }
           if(listEmployee.Count != 0)
           {
                Fill_Grid(listEmployee);
                n = false;
                Add_VehiclesCart(Workers, n);
            }
           
           
        }

        private void ChangeOrdersVehicle_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
        }

        private void ChangeBranchWorkers_Click(object sender, EventArgs e)
        {
            bool z = false;
            Branches obj = new Branches(z);
            obj.Show();
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {

            Employees obj = new Employees();
            obj.ShowDialog();
           
            employee = obj.GetResult();
            listemployees.Add(employee);
            k = false;
            Fill_Grid(listemployees);
            Add_VehiclesCart(Workers, k);
        }

        private void AddVehiclesDetails_Click(object sender, EventArgs e)
        {
            Vehicles obj = new Vehicles();
            obj.ShowDialog();
            vehicle = obj.GetResult();
            listvehicles.Add(vehicle);
            k = true;
            Fill_Grid(listvehicles);
            Add_VehiclesCart(VehiclesDetails, k);
        }
        private void Fill_Grid(List<Vehicle> listvehicles)
        {
            page_count = (listvehicles.Count) / 10;
            if (listvehicles.Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = listvehicles.Count - 1;
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
        private void Fill_Grid(List<Employee> listemployees)
        {
            page_count = (listemployees.Count) / 10;
            if (listemployees.Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = listemployees.Count - 1;
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


        private void Add_VehiclesCart(DataGridView grid, bool k)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {

            grid.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (grid.RowCount < 10)
                    {
                        grid.RowCount++;


                    }
                    if (k)
                    {
                        Vehicle item = listvehicles[list_pages[current_page, j]];
                        grid.Rows[q].Cells[0].Value = item.Id;
                        CategoryOfVehicle category = new CategoryOfVehicle();
                        category = category.FindById(Convert.ToInt32(item.IdVehicleCategory));
                        grid.Rows[q].Cells[1].Value = category.Name;
                        grid.Rows[q].Cells[2].Value = item.BrandAndModel;
                        grid.Rows[q].Cells[3].Value = item.GosNum;
                        grid.Rows[q].Cells[4].Value = item.PricePerHour;
                        grid.Rows[q].Cells[5].Value = item.IsNeedDelivery;

                        q++;
                    }
                    else
                    {
                        Employee item = listemployees[list_pages[current_page, j]];
                        grid.Rows[q].Cells[0].Value = item.Id;

                        grid.Rows[q].Cells[1].Value = item.Fio;
                        grid.Rows[q].Cells[2].Value = item.Phone;
                        grid.Rows[q].Cells[3].Value = item.Role;
                        q++;
                    }


                }
                else
                {

                    //grid.Rows.RemoveAt(grid.Rows.Count - 1);

                    break;

                }


            }
            


        }
        public List<Employee> GetEmployees()
        {
            return listemployees;
        }
        public List<Vehicle> GetVehicle()
        {
            return listvehicles;
        }

        private void SaveDetails_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
