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
    public partial class SeeOrder : Form
    {
        Order order = new Order();
        List<ServiceInOrder> listServices = new List<ServiceInOrder>();
        Dictionary<Service, Employee> pareEmployee = new Dictionary<Service, Employee>();
        Dictionary<Service, Vehicle> pareVehicle = new Dictionary<Service, Vehicle>();
        List<Discount> discounts = new List<Discount>();

        int current_page = 0;
        static int page_count = 0;
        int[,] list_pages;
        public SeeOrder(int z)
        {
            InitializeComponent();
            order = order.FindById(z);
            listServices = order.GetServcieInOrder(z);
            pareEmployee = order.GetEmployees(z);
            pareVehicle = order.GetVehicles(z);
            discounts = order.GetDiscounts(z);
            FillForm();
        }

        private void FillForm()
        {
            IDOrderInfo.Text = order.Id.ToString();
            Client client = new Client();
            client = client.FindById(Convert.ToInt32(order.ClientId));
            ClientOrderInfo.Text = client.Fio;
            AddressOrderInfo.Text = order.Address;
            DistanceOrderInfo.Text = order.Distance.ToString();
            //Branch branch = new Branch();
            //branch = branch.FindById(Convert.ToInt32(order.BranchId));
            //BranchOrderInfo.Text = branch.Address;
            //Manager manager = new Manager();
            //manager = manager.FindByIdManager(Convert.ToInt32(order.ManagerId));
            //ManagerOrderInfo.Text = manager.Fio;
            //PriceOrderInfo.Text = order.Price/order
            AllPriceOrderInfo.Text = order.Price.ToString();
            StartOrderInfo.Text = order.Start.ToString();
            EndOrderInfo.Text = order.End.ToString();
            Comm.Text = order.Comment;
            QuantityServicesOrder.Text = listServices.Count.ToString();
            QuantityServicesOrder.Text = listServices.Count.ToString();
            bool m = true;
            FillServices();
            Add_Grid(Services, m);
            m = false;
            FillDiscounts();
            Add_Grid(Discounts, m);
        }

        private void InfoServicesOrder_Click(object sender, EventArgs e)
        {
            Services obj = new Services();
            obj.Show();
        }
        private void FillServices()
        {
            page_count = (listServices.Count) / 10;
            if (listServices.Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = listServices.Count - 1;
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
        private void FillDiscounts()
        {

            page_count = (discounts.Count) / 10;
            if (discounts.Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = discounts.Count - 1;
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
        private void Add_Grid(DataGridView grid, bool m)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
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
                    if(m)
                    {
                        ServiceInOrder item = listServices[list_pages[current_page, j]];
                        Service service = new Service();
                        service = service.FindById(Convert.ToInt32(item.ServiceId));
                        grid.Rows[q].Cells[0].Value = service.Name;
                        grid.Rows[q].Cells[1].Value = item.Start;
                        grid.Rows[q].Cells[2].Value = item.End;
                        q++;
                    }
                    else
                    {
                        Discount item = discounts[list_pages[current_page, j]];

                        grid.Rows[q].Cells[0].Value = item.Id;
                        grid.Rows[q].Cells[1].Value = item.Name;
                        grid.Rows[q].Cells[2].Value = item.PriceModifier;
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
        private void InfoVehiclesOrder_Click(object sender, EventArgs e)
        {
            Vehicles obj = new Vehicles();
            obj.Show();
        }

        private void InfoDiscountOrder_Click(object sender, EventArgs e)
        {
            Discounts obj = new Discounts();
            obj.Show();
        }

        private void Services_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceInOrder services = new ServiceInOrder();
            string name = Services.Rows[Services.CurrentRow.Index].Cells[0].Value.ToString();
           services = services.FindByName(name);
            if (services.ServiceId == 4) 
            {
                SeeRent obj = new SeeRent(services);
                obj.ShowDialog();

            }
            else
            {
                List<Employee> employees = new List<Employee>();
                List<Vehicle> vehicles = new List<Vehicle>();
                foreach (var item in pareEmployee)
                {
                   
                    if(item.Key.Id == services.ServiceId)
                    {
                                employees.Add(item.Value);
                    }
                }
                foreach(var item in pareVehicle)
                {
                    if(item.Key.Id == services.ServiceId)
                    {
                            vehicles.Add(item.Value);
                    }
                }
                SeeAddService obj = new SeeAddService(services, employees, vehicles);
                obj.ShowDialog();
            }



            
        }
    }
}
