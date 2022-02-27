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
    public partial class AddOrder : Form
    {
        int current_page = 0;
        static int page_count = 0;
        int[,] list_pages;
        Client client;
 
        Driver driver = new Driver();
        Service service = new Service();
       
        Dictionary<Service, Vehicle> parevehicle = new Dictionary<Service, Vehicle>();
        Dictionary<Service, Employee> pareemployee = new Dictionary<Service, Employee>();
        List<ServiceInOrder> listservice = new List<ServiceInOrder>();
        List<Discount> discounts = new List<Discount>();
        public AddOrder()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void Fill_GridDiscounts(List<Discount> list)
        {
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
        private void Fill_GridServices(List<ServiceInOrder> list)
        {
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
        private void Add_Grid(DataGridView grid, bool k)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
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

                        Discount item = discounts[list_pages[current_page, j]];
                        
                        grid.Rows[q].Cells[0].Value = item.Id;

                        grid.Rows[q].Cells[1].Value = item.Name;
                        grid.Rows[q].Cells[2].Value = item.PriceModifier;
                        q++;
                    }
                    else
                    {

                        ServiceInOrder item = listservice[list_pages[current_page, j]];
                        int n;
                        if (item.ServiceId != null)
                        {
                            n = Convert.ToInt32(item.ServiceId);
                            grid.Rows[q].Cells[0].Value = service.FindById(n).Name;
                        }
                        
                        if(item.DriverId != null)
                        {
                            n = Convert.ToInt32(item.DriverId);
                       
                            grid.Rows[q].Cells[1].Value = driver.FindByIdDriver(n).Fio;
                        }
                        
                       if(item.DeliveryDriverId != null)
                       {
                            n = Convert.ToInt32(item.DeliveryDriverId);
                           
                            grid.Rows[q].Cells[3].Value = driver.FindByIdDriver(n).Fio;

                       }

                       
                        if (item.Vehicle != null)
                        {
                            grid.Rows[q].Cells[2].Value = item.Vehicle.BrandAndModel;
                        }

                        if (item.DeliveryVehicle != null)
                        {
                            grid.Rows[q].Cells[4].Value = item.DeliveryVehicle.BrandAndModel;
                        }
                        
                        grid.Rows[q].Cells[5].Value = item.Start;
                        grid.Rows[q].Cells[6].Value = item.End;
                        grid.Rows[q].Cells[7].Value = item.StartFrom;
                        grid.Rows[q].Cells[8].Value = item.EndFrom;
                    
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
        private void Add_Click(object sender, EventArgs e)
        {
            Cart obj = new Cart();
            obj.ShowDialog();
            parevehicle =  obj.GetPareVehicle();
            pareemployee = obj.GetPareEmployee();
            listservice = obj.GetServcieInOrder();
            Fill_GridServices(listservice);
            bool z = false;
            Add_Grid(Services, z);
            GetStartEnd();
        }

        private void Add_discounts_Click(object sender, EventArgs e)
        {
            bool z = true;
            Discounts obj = new Discounts(z, discounts);
            obj.ShowDialog();
            
            discounts = obj.GetDiscount();
            if(discounts.Count != 0)
            {
                Fill_GridDiscounts(discounts);
                
                Add_Grid(Discounts, z);
            }
           
        }

        private void ChooseClient_Click(object sender, EventArgs e)
        {
            Clients obj = new Clients();
            obj.ShowDialog();
            client = obj.GetResult();
            ClientName.Text = client.Fio;
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddClient obj = new AddClient();
            obj.ShowDialog();
            client = obj.GetResult();
            ClientName.Text = client.Fio;

        }

        private void Services_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Vehicle> listVehicle = new List<Vehicle>();
            List<Employee> listEmployee = new List<Employee>();
            int i = Services.CurrentRow.Index;
            SeeServiceInOrder obj = new SeeServiceInOrder(listservice[i], listVehicle, listEmployee);
            foreach (var item in parevehicle)
            {
                if (item.Key.Id == listservice[i].ServiceId)
                {

                    listVehicle.Add(item.Value);


                }
            }
            foreach (var item in pareemployee)
            {
                if (item.Key.Id == listservice[i].ServiceId)
                {

                    listEmployee.Add(item.Value);


                }
            }


        }
        private void GetStartEnd()
        {
            List<DateTime> listStart =  new List<DateTime>();
            List<DateTime> listEnd = new List<DateTime>();
            foreach(ServiceInOrder obj in listservice)
            {
                listStart.Add(obj.Start);
                listEnd.Add(obj.End);
            }
            DateTime item = listStart[0];
            foreach (DateTime obj in listStart)
            {
               
                if(obj < item)
                {
                        item = obj;
                }
            }
            
            DateTime item1 = listEnd[0];
            foreach(DateTime obj in listEnd)
            {
            if(obj > item1)
            {
                    item1 = obj;
            }
                CreateOrderDate.Value = item;
                CreateOrderTime.Value = item;
                EndOrderDate.Value = item1;
                EndOrderTime.Value = item1;
            }
        }

        private void DelService_Click(object sender, EventArgs e)
        {
            
            foreach (ServiceInOrder item in listservice)
            {
               if((Services.Rows[Services.CurrentRow.Index].Cells[0].Value).ToString() == "Аренда" && (Services.Rows[Services.CurrentRow.Index].Cells[2].Value).ToString() == item.Vehicle.BrandAndModel && Services.Rows[Services.CurrentRow.Index].Cells[5].Value.ToString() == item.Start.ToString() && Services.Rows[Services.CurrentRow.Index].Cells[6].Value.ToString() == item.End.ToString())
               {
                    listservice.Remove(item);
                    break;
               }
            }

            Fill_GridServices(listservice);
            bool m = false;
            Add_Grid(Services, m);
        }

        private void SaveOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Address = Address.Text;
            order.ClientId = client.Id;
            //order.Distance = Convert.ToInt32(Distance.Text);
            //order.Price = Convert.ToDecimal(AllPrice.Text);
            if (ByCash.Checked == true)
            {
                order.ByCash = true;
            }
            else
            {
                order.ByCash = false;
            }
            order.Comment = CommOrder.Text;
          
            DateTime k = CreateOrderDate.Value.Date;
            k = k.Add(CreateOrderTime.Value.TimeOfDay);
            order.Start  = k;
            k = EndOrderDate.Value.Date;
            k = k.Add(EndOrderTime.Value.TimeOfDay);
            order.End = k;
            order.AddOrder(listservice, discounts, parevehicle, pareemployee);
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
