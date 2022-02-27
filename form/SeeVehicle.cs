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
    public partial class SeeVehicle : Form
    {
        Vehicle vehicle = new Vehicle();
        List<Order> orders = new List<Order>();
        public SeeVehicle(int z)
        {
            InitializeComponent();
            vehicle = vehicle.FindById(z);
            FillForm(vehicle);
        }
        private void FillForm(Vehicle vehicle)
        {
            CommVehicle.ReadOnly = true;
            IDVehicleInfo.Text = $"{vehicle.Id}";
            GosNumVehicleInfo.Text = $"{vehicle.GosNum}";
            CategoryVehicleInfo.Text = $"{vehicle.CategoryOfVehicle.Name}";
            DrivingCatVehicleInfo.Text = $"{vehicle.DrivingCategory}";
            PrivePerHourVehicleInfo.Text = $"{vehicle.PricePerHour}";
            if (vehicle.IsNeedDelivery)
            {
                IsNeedDelivery_name.Checked = true;
            }
            BrandVehicle.Text = $"{vehicle.BrandAndModel}";
            YearOfIssueVehicleInfo.Text = $"{vehicle.YearOfIssue}";
            AngSpeedVehicle.Text = $"{vehicle.AvgSpeed}";
            MassVehicle.Text = $"{vehicle.Mass}";
            AvgGas.Text = $"{vehicle.AvgGas}";
            ShipmentTimeVehicle.Text = $"{vehicle.ShipmentTime}";
            CommVehicle.Text = $"{vehicle.Comment}";
            BranchVehicle.Text = $"{vehicle.Branch.Address}";
            orders = vehicle.GetOrdersOfVehicle(vehicle.Id);
            QuantityOrdersVehicle.Text = orders.Count.ToString();



        }
        private void InfoOrdersVehicle_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
        }

        private void SeeVehicle_Load(object sender, EventArgs e)
        {

        }

        private void CommVehicle_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void InfoOrdersVehicle_Click_1(object sender, EventArgs e)
        {
            
            Orders obj = new Orders(orders);
            obj.ShowDialog();

        }

        private void DelVehicle_Click(object sender, EventArgs e)
        {
            vehicle.DelVehicle();
        }

        private void ChangeVehicle_Click(object sender, EventArgs e)
        {
            AddVehicle obj = new AddVehicle(vehicle);
            obj.ShowDialog();
        }
    }
}
