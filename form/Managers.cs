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

    public partial class Managers : Form
    {
        Branch branch;
        int current_page = 0;
        static int page_count = 0;
        Manager manager = new Manager();
        int[,] list_pages;
        public Managers()
        {
            InitializeComponent();
            Fill_AllManagers(null, null);
            Add_AllManagers(null, null);
            FillForm();
        }

        private void Managers_Load(object sender, EventArgs e)
        {

        }
        private List<Manager> Get_List(Manager obj1, Manager obj2)
        {

            var obj = manager.GetAllManagers(obj1, obj2);
            return obj;
        }
        private void FillForm()
        {
            SortingManager.Items.Add("Id");
            SortingManager.Items.Add("ФИО");
            SortingManager.Items.Add("Филиал");
        }
        private void Fill_AllManagers(Manager obj1, Manager obj2)
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

        private void Add_AllManagers(Manager obj1, Manager obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
            AllManagers.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllManagers.RowCount < 10)
                    {
                        AllManagers.RowCount++;


                    }
                    Manager item = Get_List(obj1, obj2)[list_pages[current_page, j]];
                    AllManagers.Rows[q].Cells[0].Value = item.Id;
                    AllManagers.Rows[q].Cells[1].Value = item.Fio;
                    AllManagers.Rows[q].Cells[2].Value = item.Phone;
                    AllManagers.Rows[q].Cells[3].Value = item.Branch.Id;
                    q++;

                }
                else
                {



                    break;

                }

            }

        }
        private void Filters()
        {
            Manager obj = new Manager();
            if (IDManager.Text != "")
            {
                obj.Id = int.Parse(IDManager.Text);
            }

            obj.Fio = FIOManager.Text;
            obj.Phone = PhoneManager.Text;
            if (BranchManager.Text != "")
            {
                obj.Branch = branch;
            }
            if (SalaryManagersFrom.Text != "")
            {
                obj.Salary = decimal.Parse(SalaryManagersFrom.Text);
            }

            Manager obj2 = new Manager();
            if (SalaryManagersTo.Text != "")
            {
                obj2.Salary = decimal.Parse(SalaryManagersTo.Text);
            }
            Fill_AllManagers(obj, obj2);
            Add_AllManagers(obj, obj2);

        }

        private void ApplyManager_Click(object sender, EventArgs e)
        {
            Filters();
        }

        private void ResetManager_Click(object sender, EventArgs e)
        {
            Fill_AllManagers(null, null);
            Add_AllManagers(null, null);
            SortingManager.SelectedIndex = -1;
        }

        private void SortingManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortingManager.SelectedIndex != -1)
            {

                if (SortingManager.SelectedItem.ToString() == "Id")
                {
                    this.AllManagers.Sort(this.AllManagers.Columns[0], ListSortDirection.Ascending);
                }
                if (SortingManager.SelectedItem.ToString() == "ФИО")
                {
                    this.AllManagers.Sort(this.AllManagers.Columns[1], ListSortDirection.Ascending);
                }
                if (SortingManager.SelectedItem.ToString() == "Филиал")
                {
                    this.AllManagers.Sort(this.AllManagers.Columns[3], ListSortDirection.Ascending);
                }
            }
        }

        private void SortDesc_Managers_Click(object sender, EventArgs e)
        {
            if (SortingManager.SelectedItem.ToString() == "Id")
            {
                this.AllManagers.Sort(this.AllManagers.Columns[0], ListSortDirection.Descending);
            }
            if (SortingManager.SelectedItem.ToString() == "ФИО")
            {
                this.AllManagers.Sort(this.AllManagers.Columns[1], ListSortDirection.Descending);
            }
            if (SortingManager.SelectedItem.ToString() == "Филиал")
            {
                this.AllManagers.Sort(this.AllManagers.Columns[3], ListSortDirection.Descending);
            }
        }

        private void AddManager_Click(object sender, EventArgs e)
        {
            AddManager obj = new AddManager();
            obj.ShowDialog();
        }

        private void ChooseManager_MouseEnter(object sender, EventArgs e)
        {
            ChooseManager.BackColor = Color.White;
            ChooseManager.ForeColor = Color.DarkOrange;
            ChooseManager.FlatAppearance.BorderSize = 3;
        }

        private void ChooseManager_MouseLeave(object sender, EventArgs e)
        {
            ChooseManager.BackColor = Color.DarkOrange;
            ChooseManager.ForeColor = Color.White;
            ChooseManager.FlatAppearance.BorderSize = 0;
        }

        private void AddManager_MouseEnter(object sender, EventArgs e)
        {
            AddManager.BackColor = Color.White;
            AddManager.ForeColor = Color.DarkOrange;
            AddManager.FlatAppearance.BorderSize = 3;
        }

        private void AddManager_MouseLeave(object sender, EventArgs e)
        {
            AddManager.BackColor = Color.DarkOrange;
            AddManager.ForeColor = Color.White;
            AddManager.FlatAppearance.BorderSize = 0;
        }

        private void ApplyManager_MouseEnter(object sender, EventArgs e)
        {
            ApplyManager.BackColor = Color.DarkOrange;
            ApplyManager.ForeColor = Color.White;
            ApplyManager.FlatAppearance.BorderSize = 0;
        }

        private void ApplyManager_MouseLeave(object sender, EventArgs e)
        {
            ApplyManager.BackColor = Color.White;
            ApplyManager.ForeColor = Color.DarkOrange;
            ApplyManager.FlatAppearance.BorderSize = 2;
        }

        private void ResetManager_MouseEnter(object sender, EventArgs e)
        {
            ResetManager.BackColor = Color.DarkOrange;
            ResetManager.ForeColor = Color.White;
            ResetManager.FlatAppearance.BorderSize = 0;
        }

        private void ResetManager_MouseLeave(object sender, EventArgs e)
        {
            ResetManager.BackColor = Color.White;
            ResetManager.ForeColor = Color.DarkOrange;
            ResetManager.FlatAppearance.BorderSize = 2;
        }
    }
}

