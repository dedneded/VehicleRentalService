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
    public partial class SeeServiceInOrder : Form
    {
        ServiceInOrder service;
        List<Vehicle> listVehicle;
        List<Employee> listEmployee;
        public SeeServiceInOrder(ServiceInOrder item, List<Vehicle> listVehicle, List<Employee> listEmployee)
        {
            InitializeComponent();
            service = item;
            this.listVehicle = listVehicle;
            this.listEmployee = listEmployee;
        }
        private void FillForm()
        {
           // Name.Text = service.Service.Name;
            StartWork.Text = service.Start.ToString();
            End.Text = service.End.ToString();
            DurationService.Text = (service.Start - service.End).Duration().ToString();
            Workers.Text = listEmployee.Count.ToString();
            Vehicles.Text = listVehicle.Count.ToString();
        }
        

        private void SeeServiceInOrder_Load(object sender, EventArgs e)
        {

        }

        private void Choose_Click(object sender, EventArgs e)
        {
            ServiceDetails obj = new ServiceDetails(listVehicle, listEmployee);
            listVehicle = obj.GetVehicle();
            listEmployee = obj.GetEmployees();
        }
    }
}
