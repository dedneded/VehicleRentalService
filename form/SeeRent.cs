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
    public partial class SeeRent : Form
    {
        ServiceInOrder services = new ServiceInOrder();
        public SeeRent(ServiceInOrder service)
        {
            InitializeComponent();
            this.services = service;
            FillForm();
        }
        private void FillForm()
        {
            VehicleId.Text = services.VehicleId.ToString();
            StartRent.Text = services.Start.ToString();
            Duration.Text = services.End.Subtract(services.Start).ToString();
            EndRent.Text = services.End.ToString();
            Driver driver = new Driver();
            driver = driver.FindByIdDriver(Convert.ToInt32(services.DriverId));
            DriverInCart.Text = driver.Fio;
            driver = driver.FindByIdDriver(Convert.ToInt32(services.DeliveryDriverId));
            DeliveryDriverCart.Text = driver.Fio;
            Vehicle vehicle = new Vehicle();
            vehicle = vehicle.FindById(Convert.ToInt32(services.DeliveryVehicleId));
            DeliveryVehicleCart.Text = vehicle.BrandAndModel;
        }
        private void SeeRent_Load(object sender, EventArgs e)
        {

        }

       
    }
}
