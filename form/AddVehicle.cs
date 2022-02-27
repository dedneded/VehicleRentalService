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
    public partial class AddVehicle : Form
    {
        Branch branch = new Branch();
        CategoryOfVehicle category = new CategoryOfVehicle();
        Vehicle vehicle = new Vehicle();
        bool checkEdit = false;
        bool checkClose = false;
        public AddVehicle()
        {
            InitializeComponent();
            FillForm();
            IDVehicle.Visible = false;
            IDVehicle_name.Visible = false;


        }
        public AddVehicle(Vehicle vehicle)
        {
            InitializeComponent();
            IDVehicle.Visible = true ;
            IDVehicle_name.Visible = true;
            FillForm();
            this.vehicle = vehicle;
            FillVehicle();
            checkEdit = true;

        }

        private void Vehicle_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void FillForm()
        {
            DrivingCategories.Items.Add("C");
            DrivingCategories.Items.Add("CE");
            DrivingCategories.Items.Add("C1");
            DrivingCategories.Items.Add("C1E");
           
        }
        private void FillVehicle()
        {
            IDVehicle.Text = vehicle.Id.ToString();
            BranchInfoVehicle.Text = branch.FindById(Convert.ToInt32(vehicle.BranchId)).Address;
            CategoryText.Text = category.FindById(Convert.ToInt32(vehicle.IdVehicleCategory)).Name;
            GosNum.Text = vehicle.GosNum;
            BrandModel.Text = vehicle.BrandAndModel;
            YearOfIssue.Text = vehicle.YearOfIssue.ToString();
            
            DrivingCategories.Text = vehicle.DrivingCategory.ToString();
            if (vehicle.DrivingCategory.ToString() == "C")
            {
                DrivingCategories.SelectedItem = 0;
            }
            if (vehicle.DrivingCategory.ToString() == "CE")
            {
                DrivingCategories.SelectedItem = 1;
            }
            if (vehicle.DrivingCategory.ToString() == "C1")
            {
                DrivingCategories.SelectedItem = 2;
            }
            if (vehicle.DrivingCategory.ToString() == "C1E")
            {
                DrivingCategories.SelectedItem = 3;
            }
            PricePerHour.Text = vehicle.PricePerHour.ToString();
            Mass.Text = vehicle.Mass.ToString();
            AvgSpeed.Text = vehicle.AvgSpeed.ToString();
            AvgGas.Text = vehicle.AvgGas.ToString();
            ShipmentTime.Text = vehicle.ShipmentTime.ToString();
            if(vehicle.IsNeedDelivery)
            {
                IsBig.Checked = true;
            }
            CommVehicle.Text = vehicle.Comment;



        }
        private void CategoryChoose_Click(object sender, EventArgs e)
        {
            bool z = false;
            AddCategoryOfVehicle obj = new AddCategoryOfVehicle(z);
            obj.ShowDialog();
            category = obj.GetResult();
            CategoryText.Text = category.Name;
        }

        private void SaveVehicle_Click(object sender, EventArgs e)
        {
            Vehicle obj = new Vehicle();
            obj.GosNum = GosNum.Text;
            obj.BrandAndModel = BrandModel.Text;
            obj.YearOfIssue = Convert.ToInt32(YearOfIssue.Text);
            if (DrivingCategories.SelectedItem.ToString() == "C")
            {
                obj.DrivingCategory = DrivingCaregories.C;
            }
            if (DrivingCategories.SelectedItem.ToString() == "CE")
            {
                obj.DrivingCategory = DrivingCaregories.CE;
            }
            if (DrivingCategories.SelectedItem.ToString() == "C1")
            {
                obj.DrivingCategory = DrivingCaregories.C1;
            }
            if (DrivingCategories.SelectedItem.ToString() == "C1E")
            {
                obj.DrivingCategory = DrivingCaregories.C1E;
            }
            //if (Decimal.TryParse(PricePerHour.Text, out decimal m))
            //{
                obj.PricePerHour = Convert.ToDecimal(PricePerHour.Text);
            //}
            //if (Int32.TryParse(Mass.Text, out int z))
            //{
                obj.Mass = Convert.ToInt32(Mass.Text);
           // }
            //if (Int32.TryParse(AvgSpeed.Text, out int k))
            //{
                obj.AvgSpeed = Convert.ToInt32(AvgSpeed.Text);

            //}
          // if (Double.TryParse(AvgGas.Text, out double r))
            //{
                obj.AvgGas = Convert.ToDouble(AvgGas.Text);
            //  }
            //if (Int32.TryParse(ShipmentTime.Text, out int c))
            // {
            obj.ShipmentTime = Convert.ToInt32(ShipmentTime.Text);
            //}
            if (IsBig.Checked)
            {
                obj.IsNeedDelivery = true;
            }
            else
            {
                obj.IsNeedDelivery = false;
            }
            obj.Comment = CommVehicle.Text;
            obj.IdVehicleCategory = category.Id;
            obj.BranchId = branch.Id;
            if (checkEdit)
            {
                DialogResult dialog = MessageBox.Show(
                                "Завершить изменение техники?",
                                "Изменение",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                                );
                if (dialog == DialogResult.Yes)
                {
                    if (obj.EditVehicle())
                    {
                        MessageBox.Show(
                          "Изменения успешно внесены!",
                          "Сообщение",
                          MessageBoxButtons.OK);
                        checkClose = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля корректно!");
                    }


                }
                obj.AddVehicle();

            }
            else
            {
                DialogResult dialog = MessageBox.Show(
                                 "Завершить добавление техники?",
                                 "Добавление",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning
                                 );

                if (dialog == DialogResult.Yes)
                {
                    if (vehicle.AddVehicle())
                    {
                        MessageBox.Show(
                          "Техника успешно добавлена!",
                          "Сообщение",
                          MessageBoxButtons.OK);
                        checkClose = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля корректно!");
                    }


                }

            }

            this.Close();









        }

        private void ChooseBranchVehicle_Click(object sender, EventArgs e)
        {
            Branches obj = new Branches();
            obj.ShowDialog();
            branch = obj.GetResult();
            BranchInfoVehicle.Text = branch.Address;
        }

        private void AddVehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
        
                DialogResult dialog = MessageBox.Show(
                           "Вы действительно хотите выйти?",
                           "Выход",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning
                           );
                if (dialog == DialogResult.Yes)
                {

                    e.Cancel = false;

                }
                if (dialog == DialogResult.No) { e.Cancel = true; }
        }
           
        

        private void CancelVehicle_Click(object sender, EventArgs e)
        {
            
            if (checkEdit)
            {


                DialogResult dialog = MessageBox.Show(
                          "Отменить изменение техники?",
                          "Отмена",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Warning
                          );
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else

            {
                DialogResult dialog = MessageBox.Show(
                             "Отменить создание техники?",
                             "Отмена",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning
                             );
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void YearOfIssue_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(YearOfIssue.Text, out int n))
            {
                YearOfIssue.Text = "";
                error.SetError(YearOfIssue, "Неверный формат!");
            }
            else
            {
                error.Clear();
            }
        }

        private void PricePerHour_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(PricePerHour.Text, out int n))
            {
                PricePerHour.Text = "";
                error.SetError(PricePerHour, "Неверный формат!");
            }
            else
            {
                error.Clear();
            }
        }

        private void Mass_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Mass.Text, out int n))
            {
                Mass.Text = "";
                error.SetError(Mass, "Неверный формат!");
            }
            else
            {
                error.Clear();
            }
        }

        private void AvgSpeed_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(AvgSpeed.Text, out int n))
            {
                AvgSpeed.Text = "";
                error.SetError(AvgSpeed, "Неверный формат!");
            }
            else
            {
                error.Clear();
            }
        }

        private void AvgGas_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(AvgGas.Text, out int n))
            {
                AvgGas.Text = "";
                error.SetError(AvgGas, "Неверный формат!");
            }
            else
            {
                error.Clear();
            }
        }

        private void ShipmentTime_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(ShipmentTime.Text, out int n))
            {
                ShipmentTime.Text = "";
                error.SetError(ShipmentTime, "Неверный формат!");
            }
            else
            {
                error.Clear();
            }
        }
    }
}
