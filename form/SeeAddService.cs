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
    public partial class SeeAddService : Form
    {
        ServiceInOrder service = new ServiceInOrder();
        List<Employee> employees;
        List<Vehicle> vehicles;
        public SeeAddService(ServiceInOrder service, List<Employee> employees, List<Vehicle> vehicles)
        {
            InitializeComponent();
            this.service = service;
            this.employees = employees;
            this.vehicles = vehicles;
            FillForm();
        }
        private void FillForm()
        {
            ServiceId.Text = service.ServiceId.ToString();
            StartWork.Text = service.Start.ToString();
            EndWork.Text = service.End.ToString();
            Workers.Text = employees.Count.ToString();
            Vehicles.Text = vehicles.Count.ToString();
            Duration.Text = service.End.Subtract(service.End).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ServiceDetails obj = new ServiceDetails(vehicles, employees);
            obj.ShowDialog();
        }
    }
}
