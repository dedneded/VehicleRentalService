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
    public partial class Employees : Form
    {
        Branch branch;
        int current_page = 0;
        static int page_count = 0;
        Employee employee = new Employee();
        Manager manager = new Manager();
        int[,] list_pages;

        public Employees()
        {
            InitializeComponent();
            Fill_AllEmployees(null, null);
            Add_AllEmployees(null, null);
            SortingEmployees.Items.Add("Id");
            SortingEmployees.Items.Add("ФИО");
            SortingEmployees.Items.Add("Должность");
            SortingEmployees.Items.Add("Филиал");
        }
        public Employees(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            Fill_AllEmployees(employee, null);
            Add_AllEmployees(employee, null);
            SortingEmployees.Items.Add("Id");
            SortingEmployees.Items.Add("ФИО");
            SortingEmployees.Items.Add("Должность");
            SortingEmployees.Items.Add("Филиал");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddManager em = new AddManager();
            em.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddEmployees_Click(object sender, EventArgs e)
        {
            ChooseEmployee obj = new ChooseEmployee();
            obj.ShowDialog();
        }

        private void BranchEmployeesChoose_Click(object sender, EventArgs e)
        {
            Branches obj = new Branches();
            obj.ShowDialog();
            branch = obj.GetResult();
            BranchEmployees.Text = Convert.ToString(branch.Id);
            Filters();
           

        }
        private List<Employee> Get_List(Employee obj1, Employee obj2)
        {

            var obj = employee.GetAll(obj1, obj2);
            return obj;
        }
       

        private void Fill_AllEmployees(Employee obj1, Employee obj2)
        {
            page_count = (Get_List(obj1, obj2).Count) / 10;
            if (Get_List(obj1, obj2).Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = Get_List(obj1, obj2).Count - 1;
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

        private void Add_AllEmployees(Employee obj1, Employee obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {


            AllEmployees.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllEmployees.RowCount < 10)
                    {
                        AllEmployees.RowCount++;


                    }
                    Employee item = Get_List(obj1, obj2)[list_pages[current_page, j]];
                    AllEmployees.Rows[q].Cells[0].Value = item.Id;
                    AllEmployees.Rows[q].Cells[1].Value = item.Fio;
                    AllEmployees.Rows[q].Cells[2].Value = item.Phone;
                    Role role = new Role();
                    role.FindById(Convert.ToInt32(item.RoleId));
                    AllEmployees.Rows[q].Cells[3].Value = role.Name;
                    //AllEmployees.Rows[q].Cells[4].Value = item.Branch.Address;

                    q++;

                }
                else
                {



                    break;

                }

            }



        }
       


        private void Employees_Load(object sender, EventArgs e)
        {

        }

       

        private void Filters()
        {
            Employee obj = new Employee();
            if (IDEmployees.Text != "")
            {
                obj.Id = int.Parse(IDEmployees.Text);
            }
            
            obj.Fio = FIOemployees.Text;
            obj.Phone = PhoneEmployees.Text;
            if (BranchEmployees.Text != "")
            {
                obj.Branch = branch;
            }
            if (SalaryEmployeesTo.Text != "")
            {
                obj.Salary = decimal.Parse(SalaryEmployeesFrom.Text);
            }

            Employee obj2 = new Employee();
            if (SalaryEmployeesTo.Text != "")
            {
                obj2.Salary = decimal.Parse(SalaryEmployeesTo.Text);
            }
            Fill_AllEmployees(obj, obj2);
            Add_AllEmployees(obj, obj2);

        }

        private void ApplyEmployees_Click(object sender, EventArgs e)
        {
            Filters();
            
        }

        private void ResetEmployees_Click(object sender, EventArgs e)
        {
            Fill_AllEmployees(null, null);
            Add_AllEmployees(null, null);
            SortingEmployees.SelectedIndex = -1;
        }
        private void SortingEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
        if (SortingEmployees.SelectedIndex != -1)
        { 
        
            if (SortingEmployees.SelectedItem.ToString() == "Id")
            {
                this.AllEmployees.Sort(this.AllEmployees.Columns[0], ListSortDirection.Ascending);
            }
            if (SortingEmployees.SelectedItem.ToString() == "ФИО")
            {
                this.AllEmployees.Sort(this.AllEmployees.Columns[1], ListSortDirection.Ascending);
            }
            if (SortingEmployees.SelectedItem.ToString() == "Должность")
            {
                this.AllEmployees.Sort(this.AllEmployees.Columns[3], ListSortDirection.Ascending);
            }
            if (SortingEmployees.SelectedItem.ToString() == "Филиал")
            {
                this.AllEmployees.Sort(this.AllEmployees.Columns[4], ListSortDirection.Ascending);
            }
           }
        }

        private void SortDesc_Click_1(object sender, EventArgs e)
        {
            if (SortingEmployees.SelectedItem.ToString() == "Id")
            {
                this.AllEmployees.Sort(this.AllEmployees.Columns[0], ListSortDirection.Descending);
            }
            if (SortingEmployees.SelectedItem.ToString() == "ФИО")
            {
                this.AllEmployees.Sort(this.AllEmployees.Columns[1], ListSortDirection.Descending);
            }
            if (SortingEmployees.SelectedItem.ToString() == "Должность")
            {
                this.AllEmployees.Sort(this.AllEmployees.Columns[3], ListSortDirection.Descending);
            }
            if (SortingEmployees.SelectedItem.ToString() == "Филиал")
            {
                this.AllEmployees.Sort(this.AllEmployees.Columns[4], ListSortDirection.Descending);
            }
        }

        private void AllEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = Convert.ToInt32(AllEmployees.Rows[AllEmployees.CurrentRow.Index].Cells[0].Value);
            SeeEmployee obj = new SeeEmployee(z);
            obj.ShowDialog();
        }
        public Employee GetResult()
        {
            return employee;
        }

        private void ChooseEmployees_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(AllEmployees.Rows[AllEmployees.CurrentRow.Index].Cells[0].Value);
            employee = employee.FindById(z);
            this.Close();
        }

        private void ChooseEmployees_MouseEnter(object sender, EventArgs e)
        {
            ChooseEmployees.BackColor = Color.White;
            ChooseEmployees.ForeColor = Color.DarkOrange;
            ChooseEmployees.FlatAppearance.BorderSize = 3;
        }

        private void ChooseEmployees_MouseLeave(object sender, EventArgs e)
        {
            ChooseEmployees.BackColor = Color.DarkOrange;
            ChooseEmployees.ForeColor = Color.White;
            ChooseEmployees.FlatAppearance.BorderSize = 0;
        }

        private void AddEmployees_MouseEnter(object sender, EventArgs e)
        {
            AddEmployees.BackColor = Color.White;
            AddEmployees.ForeColor = Color.DarkOrange;
            AddEmployees.FlatAppearance.BorderSize = 3;
        }

        private void AddEmployees_MouseLeave(object sender, EventArgs e)
        {
            AddEmployees.BackColor = Color.DarkOrange;
            AddEmployees.ForeColor = Color.White;
            AddEmployees.FlatAppearance.BorderSize = 0;
        }

        private void ApplyEmployees_MouseEnter(object sender, EventArgs e)
        {
            ApplyEmployees.BackColor = Color.DarkOrange;
            ApplyEmployees.ForeColor = Color.White;
            ApplyEmployees.FlatAppearance.BorderSize = 0;
        }

        private void ApplyEmployees_MouseLeave(object sender, EventArgs e)
        {
            ApplyEmployees.BackColor = Color.White;
            ApplyEmployees.ForeColor = Color.DarkOrange;
            ApplyEmployees.FlatAppearance.BorderSize = 2;
        }

        private void ResetEmployees_MouseEnter(object sender, EventArgs e)
        {
            ResetEmployees.BackColor = Color.DarkOrange;
            ResetEmployees.ForeColor = Color.White;
            ResetEmployees.FlatAppearance.BorderSize = 0;
        }

        private void ResetEmployees_MouseLeave(object sender, EventArgs e)
        {
            ResetEmployees.BackColor = Color.White;
            ResetEmployees.ForeColor = Color.DarkOrange;
            ResetEmployees.FlatAppearance.BorderSize = 2;
        }
    }
}

