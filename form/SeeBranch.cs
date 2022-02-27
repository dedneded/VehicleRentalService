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
    public partial class SeeBranch : Form
    {
        Vehicle vehicle = new Vehicle();
        Employee employee = new Employee();
        Branch branch = new Branch();
        List<Employee> employees = new List<Employee>();
        List<Vehicle> vehicles = new List<Vehicle>();
        public SeeBranch()
        {
            InitializeComponent();
        }
        public SeeBranch(int s)
        {

            InitializeComponent();
            branch = branch.FindById(s);
            FillForm(branch);
        }

       
        private void SeeEmployeesInfo_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees(employee);
            obj.ShowDialog();
        }
       

        private void SeeVehiclesInfo_Click(object sender, EventArgs e)
        {
            Vehicles obj = new Vehicles(vehicle);
            obj.ShowDialog();
        }

       
        private void FillForm(Branch item) // Заполнение формы 
        {
            IDBranchInfo.Text = Convert.ToString(item.Id);
            PhoneBranchInfo.Text = item.Phone;
            AddressBranchInfo.Text = item.Address;
            employee.Branch = item;
            employee.Fio = "";
            employee.Phone = "";
            employees = employee.GetAll(employee, null);
            QuantityEmployeeInfo.Text = $"{employees.Count}";
            vehicle.Branch = item;
            vehicle.GosNum = "";
            vehicles = vehicle.GetAll(vehicle, null);
            QuantityVehicleInfo.Text = $"{vehicles.Count}";
        }

        private void SeeBranch_Load(object sender, EventArgs e)
        {

        }

        private void TimeTableBranchInfo_Click(object sender, EventArgs e)
        {
            TimetablesBranch obj = new TimetablesBranch(branch);
            obj.ShowDialog();
        }
    }
}
