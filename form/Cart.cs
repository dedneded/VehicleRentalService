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
    public partial class Cart : Form
    {
        int current_page = 0;
        static int page_count = 0;
        int[,] list_pages;
        Driver driver;
        Driver deliverydriver;
        Vehicle deliveryvehicle;
        Vehicle vehicle = new Vehicle();
        Service service = new Service();
        List<Service> listServicesGrid = new List<Service>();
        List<Vehicle> listVehicleGrid = new List<Vehicle>();
        ServiceInOrder serviceinord = new ServiceInOrder();
        List<ServiceInOrder> listservice = new List<ServiceInOrder>();
        List<Vehicle> vehiclePareGrid = new List<Vehicle>();
        List<Employee> employeePareGrid = new List<Employee>();
        Dictionary<Service, Vehicle> parevehicle = new Dictionary<Service, Vehicle>();
        Dictionary<Service, Employee> pareemployee = new Dictionary<Service, Employee>();


        bool m = false;
        bool n = false;
        public Cart()
        {

            InitializeComponent();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void Fill_Grid(List<Vehicle> listgrid)
        {
            page_count = (listgrid.Count) / 10;
            if (listgrid.Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = listgrid.Count - 1;
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
        private void Fill_Grid(List<Service> listservices)
        {
            page_count = (listservices.Count) / 10;
            if (listservices.Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = listservices.Count - 1;
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

        public Dictionary<Service, Vehicle> GetPareVehicle()
        {
            return parevehicle;
        }
        public Dictionary<Service, Employee> GetPareEmployee()
        {
            return pareemployee;
        }
        public List<ServiceInOrder> GetServcieInOrder()
        {
            return listservice;
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
                        Vehicle item = listVehicleGrid[list_pages[current_page, j]];
                        grid.Rows[q].Cells[0].Value = item.Id;

                        grid.Rows[q].Cells[1].Value = item.CategoryOfVehicle.Name;
                        grid.Rows[q].Cells[2].Value = item.BrandAndModel;
                        grid.Rows[q].Cells[3].Value = item.GosNum;
                        grid.Rows[q].Cells[4].Value = item.PricePerHour;
                        grid.Rows[q].Cells[5].Value = item.IsNeedDelivery;

                        q++;
                    }
                    else
                    {
                        Service item = listServicesGrid[list_pages[current_page, j]];
                        grid.Rows[q].Cells[0].Value = item.Id;

                        grid.Rows[q].Cells[1].Value = item.Name;
                        q++;
                    }


                }
                else
                {

                    //grid.Rows.RemoveAt(grid.Rows.Count - 1);

                    break;

                }


            }
            m = true;


        }

        private void DriverInCartChoose_Click(object sender, EventArgs e)
        {
            Drivers obj = new Drivers();
            obj.ShowDialog();
            driver = obj.GetResult();
            DriverInCart.Text = driver.Fio;
        }

        private void DeliveryDriverCartChoose_Click(object sender, EventArgs e)
        {
            Drivers obj = new Drivers();
            obj.ShowDialog();
            deliverydriver = obj.GetResult();
            DeliveryDriverCart.Text = deliverydriver.Fio;
        }

        private void DeliveryVehicleCartChoose_Click(object sender, EventArgs e)
        {
            Vehicles obj = new Vehicles();
            obj.ShowDialog();
            deliveryvehicle = obj.GetResult();
            DeliveryVehicleCart.Text = deliveryvehicle.BrandAndModel;
        }

        private void AddVehicleCart_Click(object sender, EventArgs e)
        {
            m = false;
            Vehicles obj = new Vehicles();
            obj.ShowDialog();
            vehicle = obj.GetResult();
            listVehicleGrid.Add(vehicle);
            serviceinord = new ServiceInOrder();
            serviceinord.Vehicle = vehicle;
          
            serviceinord.ServiceId = service.GetRent()[0].Id;
            listservice.Add(serviceinord);
            bool check = true;
            Fill_Grid(listVehicleGrid);

            Add_VehiclesCart(VehiclesCart, check);
            FillInfoVehicle();




        }



        private void FillInfoVehicle()
        {
            try
            {
                StartRentDay.Value = serviceinord.Start;
                StartRentTime.Value = serviceinord.Start;
                EndRentDay.Value = serviceinord.End;
                EndRentTime.Value = serviceinord.End;
                Duration.Text = serviceinord.End.Subtract(serviceinord.Start).Hours.ToString();
                DriverInCart.Text = serviceinord.Driver.Fio;
                DeliveryDriverCart.Text = serviceinord.DeliveryDriver.Fio;
                DeliveryVehicleCart.Text = serviceinord.DeliveryVehicle.BrandAndModel;

            }
            catch
            {
                DateTime now = DateTime.Now;
                StartRentDay.Value = now;
                StartRentTime.Value = now;
                EndRentDay.Value = now;
                EndRentTime.Value = now;
                Duration.Clear();
                DriverInCart.Text = "не выбрано";
                DeliveryDriverCart.Text = "не выбрано";
                DeliveryVehicleCart.Text = "не выбрано";

            }





        }
        private void FillInfoService()
        {
            try
            {

                StartWorkDay.Value = serviceinord.Start;
                StartWorkTime.Value = serviceinord.Start;
                EndWorkDay.Value = serviceinord.End;
                EndWorkTime.Value = serviceinord.End;
                DurationWork.Text = serviceinord.End.Subtract(serviceinord.Start).Hours.ToString();


                Workers.Text = $"{vehiclePareGrid.Count}";


                Vehicles.Text = $"{employeePareGrid.Count}";
            }


            catch
            {
                DateTime now = DateTime.Now;
                StartWorkDay.Value = now;
                StartWorkTime.Value = now;
                EndWorkDay.Value = now;
                EndWorkTime.Value = now;
                DurationWork.Clear();
                Workers.Text = "";
                Vehicles.Text = "";
            }









        }

        private void AddVehicleDetails(int index)
        {

            listservice[index].DeliveryDriverId = deliverydriver.Id;
            listservice[index].DeliveryVehicle = deliveryvehicle;
            listservice[index].Vehicle = vehicle;
            listservice[index].DriverId = driver.Id;
            DateTime k = StartRentDay.Value.Date;
            k = k.Add(StartRentTime.Value.TimeOfDay);
            listservice[index].Start = k;
            k = EndRentDay.Value.Date;
            k = k.Add(EndRentTime.Value.TimeOfDay);
            listservice[index].End = k;



        }
        private void AddServiceDetails(int index)
        {

            listservice[index].ServiceId = service.Id;
            DateTime k = StartWorkDay.Value.Date;
            k = k.Add(StartWorkTime.Value.TimeOfDay);
            listservice[index].Start = k;
            k = EndWorkDay.Value.Date;
            k = k.Add(EndWorkTime.Value.TimeOfDay);
            listservice[index].End = k;
            listservice[index].Price = 100;
            


        }

        private void Choose_Click(object sender, EventArgs e)
        {

            List<Vehicle> listVehicle = new List<Vehicle>();
            List<Employee> listEmployee = new List<Employee>();
            int z = Convert.ToInt32(AddServicesCart.Rows[AddServicesCart.CurrentRow.Index].Cells[0].Value);
            foreach (var item in parevehicle)
            {
                if (item.Key.Id == z)
                {

                    listVehicle.Add(item.Value);
                }
            }
            foreach (var item in pareemployee)
            {
                if (item.Key.Id == z)
                {

                    listEmployee.Add(item.Value);
                }
            }
            ServiceDetails obj;
            if (listVehicle.Count == 0 && listEmployee.Count == 0)
            {
                obj = new ServiceDetails();
                obj.ShowDialog();
                
            }
            else
            {
                obj = new ServiceDetails(listVehicle, listEmployee);
                obj.ShowDialog();
            }

            employeePareGrid = obj.GetEmployees();
            vehiclePareGrid = obj.GetVehicle();

            foreach (Vehicle item in vehiclePareGrid)
            {
                parevehicle.Add(service.FindById(z), item);
            }
            foreach (Employee item in employeePareGrid)
            {
                pareemployee.Add(service.FindById(z), item);
            }

        }

        private void AddServiceCart_Click(object sender, EventArgs e)
        {
            bool check = true;
            Services obj = new Services(check);
            obj.ShowDialog();
            foreach (Service item in obj.GetAllServices())
            {
                listServicesGrid.Add(item);
                ServiceInOrder obj1 = new ServiceInOrder();
                obj1.ServiceId = item.Id;
                listservice.Add(obj1);
            }

            bool s = false;
            Fill_Grid(listServicesGrid);

            Add_VehiclesCart(AddServicesCart, s);
        }

        private void Duration_TextChanged(object sender, EventArgs e)
        {
            try
            {



                DateTime time = StartRentTime.Value;
                time = time.AddHours(Convert.ToInt32(Duration.Text));
                EndRentTime.Value = time;
                EndRentDay.Value = EndRentTime.Value;

            }
            catch
            {
                if (Duration.Text == "")
                {
                    EndRentDay.Value = StartRentDay.Value;
                    EndRentTime.Value = StartRentTime.Value;
                }

            }


        }

        private void Info_Enter(object sender, EventArgs e)
        {

        }

        private void InfoSave_Click(object sender, EventArgs e)
        {

            int z = Convert.ToInt32(VehiclesCart.Rows[VehiclesCart.CurrentRow.Index].Cells[0].Value);
            vehicle = vehicle.FindById(z);
            foreach (ServiceInOrder item in listservice)
            {
                if (item.Vehicle.Id == vehicle.Id)
                {
                    int index = listservice.IndexOf(item);
                    AddVehicleDetails(index);
                }
            }


            m = true;


        }

        private void VehiclesCart_SelectionChanged(object sender, EventArgs e)
        {
            if (m)
            {
                int z = Convert.ToInt32(VehiclesCart.Rows[VehiclesCart.CurrentRow.Index].Cells[0].Value);
                vehicle = vehicle.FindById(z);
                foreach (ServiceInOrder item in listservice)
                {
                    if (item.Vehicle.Id == vehicle.Id)
                    {
                        serviceinord = item;
                        FillInfoVehicle();
                        break;
                    }


                }
            }
        }

        private void DurationWork_TextChanged(object sender, EventArgs e)
        {

        }

        private void DurationWork_TextChanged_1(object sender, EventArgs e)
        {
            try
            {



                DateTime time = StartWorkTime.Value;
                time = time.AddHours(Convert.ToInt32(DurationWork.Text));
                EndWorkTime.Value = time;
                EndWorkDay.Value = EndWorkTime.Value;

            }
            catch
            {
                if (Duration.Text == "")
                {
                    EndWorkDay.Value = StartWorkDay.Value;
                    EndWorkTime.Value = StartWorkTime.Value;
                }

            }


        }

        private void AddServicesCart_SelectionChanged(object sender, EventArgs e)
        {
            if (n)
            {
                int z = Convert.ToInt32(AddServicesCart.Rows[AddServicesCart.CurrentRow.Index].Cells[0].Value);
                service = service.FindById(z);
                foreach (ServiceInOrder item in listservice)
                {
                    if (item.ServiceId == service.Id)
                    {
                        serviceinord = item;
                        FillInfoService();
                        break;
                    }


                }

            }
        }

        private void SaveInfoAddService_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(AddServicesCart.Rows[AddServicesCart.CurrentRow.Index].Cells[0].Value);

            service.Id = z;


            foreach (ServiceInOrder obj in listservice)
            {
                if (obj.ServiceId == service.Id)
                {
                    int index = listservice.IndexOf(obj);
                    AddServiceDetails(index);
                }
            }


            n = true;
        }

        private void DeleteVehicleCart_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(VehiclesCart.Rows[VehiclesCart.CurrentRow.Index].Cells[0].Value);
            Vehicle obj = vehicle.FindById(z);
            int delet = VehiclesCart.SelectedCells[0].RowIndex;
            VehiclesCart.Rows.RemoveAt(delet);
            foreach (Vehicle item in listVehicleGrid)
            {
                if (item == obj)
                {
                    listVehicleGrid.Remove(item);
                }
            }
            foreach (ServiceInOrder item in listservice)
            {
                if (item.Vehicle != null)
                {
                    if (item.Vehicle == obj)
                    {
                        item.Vehicle = null;


                    }
                }
            }
            FillInfoVehicle();




        }

        private void DeleteServiceCart_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(AddServicesCart.Rows[AddServicesCart.CurrentRow.Index].Cells[0].Value);
            Service obj = service.FindById(z);
            int delet = AddServicesCart.SelectedCells[0].RowIndex;
            AddServicesCart.Rows.RemoveAt(delet);
            foreach (Service item in listServicesGrid)
            {
                if (item.Id == obj.Id)
                {
                    if (listServicesGrid.Remove(item))
                    {
                        break;
                    }

                }
            }
            foreach (ServiceInOrder item in listservice)
            {
                if (item.ServiceId == obj.Id)
                {

                    if (listservice.Remove(item))
                    {
                        break;
                    }


                }
            }
            int k = 0;
            Dictionary<Service, Vehicle> dict = new Dictionary<Service, Vehicle>();
            foreach(var item in parevehicle)
            {
                dict.Add(item.Key, item.Value);
            }
            int i = 0;
            foreach (KeyValuePair<Service, Vehicle> valuePair in parevehicle)
            {
                if (parevehicle.ElementAt(i).Key.Id == obj.Id)
                {
                    dict.Remove(dict.ElementAt(i - k).Key);
                    k++;

                }
                i++;
                
            }
            parevehicle = dict;
            k = 0;
            Dictionary<Service, Employee> dictEmployee = new Dictionary<Service, Employee>();
            foreach (var item in pareemployee)
            {
                dictEmployee.Add(item.Key, item.Value);
            }
            i = 0;
            foreach (KeyValuePair<Service, Employee> valuePair in pareemployee)
            {
                if (pareemployee.ElementAt(i).Key.Id == obj.Id)
                {
                    dictEmployee.Remove(dictEmployee.ElementAt(i - k).Key);
                    k++;

                }
                i++;

            }
            pareemployee = dictEmployee;

            FillInfoService();
            


        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }
        
        private void PrintOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
