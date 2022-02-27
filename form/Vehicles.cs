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
    public partial class Vehicles : Form
    {
       
        Branch branch;
        CategoryOfVehicle category;
        int current_page = 0;
        static int page_count = 0;
        Vehicle vehicle = new Vehicle();
        int[,] list_pages;
        List<Vehicle> VehicleOrders = new List<Vehicle>();
        public Vehicles()
        {
            InitializeComponent();
            Fill_AllVehicles(Get_List(null,null));
            Add_AllVehicles(Get_List(null, null));
            FillForm();
        }
        public Vehicles(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            InitializeComponent();
            Fill_AllVehicles(Get_List(vehicle, null));
            Add_AllVehicles(Get_List(vehicle, null));
            FillForm();
        }
       

        private void AddVehicles_Click(object sender, EventArgs e)
        {
            AddVehicle obj = new AddVehicle();
            obj.ShowDialog();
        }

        private void ChangeOrdersVehilcles_Click(object sender, EventArgs e)
        {

            bool m = true;
            Orders obj = new Orders(m);
            obj.ShowDialog();
            Order order = obj.Get_Result();
            OrdersVehilcles.Text = order.Id.ToString();
            VehicleOrders = vehicle.GetVehicleOfOrder(order.Id);
            if(VehicleOrders.Count == 0)
            {
                MessageBox.Show("В данном заказе не используется техника!");
            }
            


        }

        private void ChangeTimeBranch_Click(object sender, EventArgs e)
        {
            Branches obj = new Branches();
            obj.ShowDialog();
            branch = obj.GetResult();
            BranchVehicles.Text = Convert.ToString(branch.Address);
            Filters();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {

        }
        private List<Vehicle> Get_List(Vehicle obj1, Vehicle obj2)
        {

            var obj = vehicle.GetAll(obj1, obj2);
            return obj;
        }
        private void FillForm()
        {
            SortingVehicles.Items.Add("Id");
            SortingVehicles.Items.Add("Категория");
            SortingVehicles.Items.Add("Марка и модель");
            SortingVehicles.Items.Add("Стоимость за час");
        }
        private void Fill_AllVehicles(List<Vehicle> vehicles)
        {
            List<Vehicle> list = vehicles;
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

        private void Add_AllVehicles(List<Vehicle> vehicles)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
            List<Vehicle> list = vehicles;
            AllVehicles.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllVehicles.RowCount < 10)
                    {
                        AllVehicles.RowCount++;


                    }
                    
                   Vehicle item = list[list_pages[current_page, j]];
                    AllVehicles.Rows[q].Cells[0].Value = item.Id;
                    CategoryOfVehicle category = new CategoryOfVehicle();
                    AllVehicles.Rows[q].Cells[1].Value = category.FindById(Convert.ToInt32(item.IdVehicleCategory)).Name;
                 
                    AllVehicles.Rows[q].Cells[2].Value = item.BrandAndModel;
                    AllVehicles.Rows[q].Cells[3].Value = item.GosNum;
                    AllVehicles.Rows[q].Cells[4].Value = item.PricePerHour;
                    AllVehicles.Rows[q].Cells[5].Value = item.IsNeedDelivery;

                    q++;

                }
                else
                {


                    AllVehicles.Rows.RemoveAt(AllVehicles.Rows.Count - 1);
                    break;

                }

            }

        }
        private void Filters()
        {
            Vehicle obj = new Vehicle();
            if (IDVehilcles.Text != "")
            {
                obj.Id = int.Parse(IDVehilcles.Text);
            }

            obj.GosNum = GosNumVehilcles.Text;
            if (BranchVehicles.Text != "")
            {
                obj.Branch = branch;
            }
            if (BranchVehicles.Text != "")
            {
                obj.Branch = branch;
            }
            
             if (CategoryVehicles.Text != "")
            {
                obj.CategoryOfVehicle = category;
            }
            if (DeliveryCheck.Checked == true)
            {
                obj.IsNeedDelivery = true;

            }
            else
            {
                obj.IsNeedDelivery = false;
            }
           
            Vehicle obj2 = new Vehicle();
            try
            {
                List<Vehicle> list =  new List<Vehicle>();
            foreach(Vehicle item in Get_List(obj, obj2))
            {
                    foreach (Vehicle item1 in VehicleOrders) 
                    {
                        if(item1.Id == item.Id)
                        {
                            list.Add(item);
                        }
                    }

            }
                
                Fill_AllVehicles(list);
                Add_AllVehicles(list);
            }
            catch
            {
                MessageBox.Show("Такой техники не существует!");
                Fill_AllVehicles(Get_List(null, null));
                Add_AllVehicles(Get_List(null, null));

            }
           
        }

        private void SortingVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortingVehicles.SelectedIndex != -1)
            {

                if (SortingVehicles.SelectedItem.ToString() == "Id")
                {
                    this.AllVehicles.Sort(this.AllVehicles.Columns[0], ListSortDirection.Ascending);
                }
                if (SortingVehicles.SelectedItem.ToString() == "Категория")
                {
                    this.AllVehicles.Sort(this.AllVehicles.Columns[1], ListSortDirection.Ascending);
                }
                if (SortingVehicles.SelectedItem.ToString() == "Марка и модель")
                {
                    this.AllVehicles.Sort(this.AllVehicles.Columns[2], ListSortDirection.Ascending);
                }
                if (SortingVehicles.SelectedItem.ToString() == "Стоимость за час")
                {
                    this.AllVehicles.Sort(this.AllVehicles.Columns[4], ListSortDirection.Ascending);
                }
            }
        }

        private void SortDescVehicles_Click(object sender, EventArgs e)
        {
            if (SortingVehicles.SelectedItem.ToString() == "Id")
            {
                this.AllVehicles.Sort(this.AllVehicles.Columns[0], ListSortDirection.Descending);
            }
            if (SortingVehicles.SelectedItem.ToString() == "Категория")
            {
                this.AllVehicles.Sort(this.AllVehicles.Columns[1], ListSortDirection.Descending);
            }
            if (SortingVehicles.SelectedItem.ToString() == "Марка и модель")
            {
                this.AllVehicles.Sort(this.AllVehicles.Columns[2], ListSortDirection.Descending);
            }
            if (SortingVehicles.SelectedItem.ToString() == "Стоимость за час")
            {
                this.AllVehicles.Sort(this.AllVehicles.Columns[4], ListSortDirection.Descending);
            }
        }

        private void DeliveryCheck_CheckedChanged(object sender, EventArgs e)
        {
          
            
        }

        private void ApplyVehicles_Click(object sender, EventArgs e)
        {
            Filters();
        }

        private void ResetVehicles_Click(object sender, EventArgs e)
        {
            Fill_AllVehicles(Get_List(null, null));
            Add_AllVehicles(Get_List(null, null));
            SortingVehicles.SelectedIndex = -1;
            CategoryVehicles.Text = "не выбрано";
            BranchVehicles.Text = "не выбрано";
            OrdersVehilcles.Text = "не выбрано";
            IDVehilcles.Clear();
            GosNumVehilcles.Clear();
            DeliveryCheck.Checked = false;
        }

        private void CategoryChoose_Click(object sender, EventArgs e)
        {
            bool z = false;
            AddCategoryOfVehicle obj = new AddCategoryOfVehicle(z);
            obj.ShowDialog();
            category = obj.GetResult();
            CategoryVehicles.Text = Convert.ToString(category.Name);
            Filters();
        }

        private void DelCategory_Click(object sender, EventArgs e)
        {
            CategoryVehicles.Text = "не выбрано";
            category = null;
            Filters();
        }

        private void DelTimeBranch_Click(object sender, EventArgs e)
        {
            BranchVehicles.Text = "не выбрано";
            branch = null;
            Filters();
        }
        public Vehicle GetResult()
        {
            return vehicle;
        }

        private void AllVehicles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = Convert.ToInt32(AllVehicles.Rows[AllVehicles.CurrentRow.Index].Cells[0].Value);
            SeeVehicle obj = new SeeVehicle(z);
            obj.ShowDialog();
        }

        private void ChooseVehicles_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(AllVehicles.Rows[AllVehicles.CurrentRow.Index].Cells[0].Value);
            vehicle = vehicle.FindById(z);
            this.Close();
        }

        private void FiltersVehicles_Enter(object sender, EventArgs e)
        {

        }

        private void IDVehilcles_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(IDVehilcles.Text, out int n))
            {
                IDVehilcles.Text = "";
                errorId.SetError(IDVehilcles, "Неверный формат!");
            }
            else
            {
                errorId.Clear();
            }
            
        }

        private void DelOrdersVehilcles_Click(object sender, EventArgs e)
        {
            OrdersVehilcles.Text = "";
        }

        private void ChooseVehicles_MouseEnter(object sender, EventArgs e)
        {
            ChooseVehicles.BackColor = Color.White;
            ChooseVehicles.ForeColor = Color.DarkOrange;
            ChooseVehicles.FlatAppearance.BorderSize = 3;

        }

        private void ChooseVehicles_MouseLeave(object sender, EventArgs e)
        {

            ChooseVehicles.BackColor = Color.DarkOrange;
            ChooseVehicles.ForeColor = Color.White;
            ChooseVehicles.FlatAppearance.BorderSize = 0;

        }

        private void AddVehicles_MouseEnter(object sender, EventArgs e)
        {
            AddVehicles.BackColor = Color.White;
            AddVehicles.ForeColor = Color.DarkOrange;
            AddVehicles.FlatAppearance.BorderSize = 3;
        }

        private void AddVehicles_MouseLeave(object sender, EventArgs e)
        {
            AddVehicles.BackColor = Color.DarkOrange;
            AddVehicles.ForeColor = Color.White;
            AddVehicles.FlatAppearance.BorderSize = 0;
        }

        private void ApplyVehicles_MouseEnter(object sender, EventArgs e)
        {
            ApplyVehicles.BackColor = Color.DarkOrange;
            ApplyVehicles.ForeColor = Color.White;
            ApplyVehicles.FlatAppearance.BorderSize = 0;
        }

        private void ApplyVehicles_MouseLeave(object sender, EventArgs e)
        {
            ApplyVehicles.BackColor = Color.White;
            ApplyVehicles.ForeColor = Color.DarkOrange;
            ApplyVehicles.FlatAppearance.BorderSize = 2;
        }

        private void ResetVehicles_MouseEnter(object sender, EventArgs e)
        {
            ResetVehicles.BackColor = Color.DarkOrange;
            ResetVehicles.ForeColor = Color.White;
            ResetVehicles.FlatAppearance.BorderSize = 0;
        }

        private void ResetVehicles_MouseLeave(object sender, EventArgs e)
        {
            ResetVehicles.BackColor = Color.White;
            ResetVehicles.ForeColor = Color.DarkOrange;
            ResetVehicles.FlatAppearance.BorderSize = 2;
        }
    }
}
