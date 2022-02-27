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
    public partial class Branches : Form
    {
        bool check;
        int current_page = 0;
        static int page_count = 0;
        Branch branch = new Branch();
        int[,] list_pages;
        List<Branch> list;
        public Branches(bool m)
        {
            InitializeComponent();
            Fill_AllBranches(null, null);
            Add_AllBranches(null, null);
            check = m;
            FillForm();

        }
        public Branches(List<Branch> list)
        {
            InitializeComponent();
            this.list = list;
            AllBranches.Columns[0].Visible = false;
            Fill_AllBranches(null, null);
            Add_AllBranches(null, null);
            check = false;
            FillForm();

        }
        public Branches()
        {
            InitializeComponent();
            AllBranches.Columns[0].Visible = false;
            Fill_AllBranches(null, null);
            Add_AllBranches(null, null);
            check = false;
            FillForm();

        }




        private void Add_branch_Click(object sender, EventArgs e)
        {
            AddBranch obj = new AddBranch();
            obj.Show();
        }

        private void Branches_Load(object sender, EventArgs e)
        {

        }
        private List<Branch> Get_List(Branch obj1, Branch obj2)
        {

            var obj = branch.GetAll(obj1, obj2);
            return obj;
        }
        private void Fill_AllBranches(Branch obj1, Branch obj2)
        {
            if (list == null)
            {
                 list = Get_List(obj1, obj2);
            }
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

        private void Add_AllBranches(Branch obj1, Branch obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
            
            AllBranches.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllBranches.RowCount < 10)
                    {
                        AllBranches.RowCount++;

                    }
                    Branch item = list[list_pages[current_page, j]];
                    AllBranches.Rows[q].Cells[1].Value = item.Id;
                    AllBranches.Rows[q].Cells[2].Value = item.Phone;
                    AllBranches.Rows[q].Cells[3].Value = item.Address;


                    q++;

                }
                else
                {



                    break;

                }

            }

        }
        private void FillForm()
        {
        if(check)
        {
               
                    AllBranches.Columns[0].Visible = true;               
        }
            Sorting_branch.Items.Add("Id");
            Sorting_branch.Items.Add("Город");
            
        }
        private void Choose_branch_Click(object sender, EventArgs e)
        {
            if(check)
            {
                for (int i = 0; i <= AllBranches.RowCount - 1; i++)
                {
                    if (Convert.ToBoolean(AllBranches.Rows[i].Cells[0].Value) == true)
                    {

                        list.Add(branch.FindById(Convert.ToInt32(AllBranches.Rows[i].Cells[1].Value)));
                    }
                }
            }
            else
            {
                int index = AllBranches.CurrentRow.Index;
              
                        int m = Convert.ToInt32(AllBranches.Rows[index].Cells[1].Value);
                        branch = branch.FindById(m);
            }
          
            this.Close();
        }

        public Branch GetResult()
        {
            return branch;
        }

       
        private void Filters()
        {
            Branch obj = new Branch();
            if (ID_branch.Text != "")
            {
                obj.Id = int.Parse(ID_branch.Text);
            }
            obj.Address = CityBranches.Text;


            Branch obj2 = new Branch();
            obj2.Address = StreetBranches.Text;
            Fill_AllBranches(obj, obj2);
            Add_AllBranches(obj, obj2);

        }



      

        private void ApplyBranch_Click(object sender, EventArgs e)
        {
            Filters();
        }

        private void ResetBranch_Click(object sender, EventArgs e)
        {
            Fill_AllBranches(null, null);
            Add_AllBranches(null, null);
            Sorting_branch.SelectedIndex = -1;
        }

        private void Sorting_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sorting_branch.SelectedIndex != -1)
            {

                if (Sorting_branch.SelectedItem.ToString() == "Id")
                {
                    this.AllBranches.Sort(this.AllBranches.Columns[0], ListSortDirection.Ascending);
                }
                if (Sorting_branch.SelectedItem.ToString() == "Город")
                {
                    this.AllBranches.Sort(this.AllBranches.Columns[2], ListSortDirection.Ascending);
                }

            }
        }

        private void SortDesc_Branch_Click(object sender, EventArgs e)
        {
            if (Sorting_branch.SelectedItem.ToString() == "Id")
            {
                this.AllBranches.Sort(this.AllBranches.Columns[0], ListSortDirection.Descending);
            }
            if (Sorting_branch.SelectedItem.ToString() == "Город")
            {
                this.AllBranches.Sort(this.AllBranches.Columns[2], ListSortDirection.Descending);
            }
        }
        public List<Branch> GetAllBranches()
        {
            
            return list;
        }

       

        private void AllBranches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = Convert.ToInt32(AllBranches.Rows[AllBranches.CurrentRow.Index].Cells[1].Value);
            SeeBranch obj = new SeeBranch(z);
            obj.ShowDialog();
        }

        private void ID_branch_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(ID_branch.Text, out int n))
            {
                ID_branch.Text = "";
                error.SetError(ID_branch, "Неверный формат!");
            }
            else
            {
                error.Clear();
            }
        }

        private void CityBranches_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(CityBranches.Text, out int n))
            {
                CityBranches.Text = "";
                error.SetError(CityBranches, "Неверный формат!");
            }
            else
            {

                error.Clear();
            }
        }

        private void StreetBranches_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(StreetBranches.Text, out int n))
            {
                StreetBranches.Text = "";
                error.SetError(StreetBranches, "Неверный формат!");
            }
            else
            {

                error.Clear();
            }
        }

        private void Choose_branch_MouseEnter(object sender, EventArgs e)
        {
            Choose_branch.BackColor = Color.White;
            Choose_branch.ForeColor = Color.DarkOrange;
            Choose_branch.FlatAppearance.BorderSize = 3;
        }

        private void Choose_branch_MouseLeave(object sender, EventArgs e)
        {
            Choose_branch.BackColor = Color.DarkOrange;
            Choose_branch.ForeColor = Color.White;
            Choose_branch.FlatAppearance.BorderSize = 0;
        }

        private void Add_branch_MouseEnter(object sender, EventArgs e)
        {
            Add_branch.BackColor = Color.White;
            Add_branch.ForeColor = Color.DarkOrange;
            Add_branch.FlatAppearance.BorderSize = 3;
        }

        private void Add_branch_MouseLeave(object sender, EventArgs e)
        {
            Add_branch.BackColor = Color.DarkOrange;
            Add_branch.ForeColor = Color.White;
            Add_branch.FlatAppearance.BorderSize = 0;
        }

        private void ApplyBranch_MouseEnter(object sender, EventArgs e)
        {
            ApplyBranch.BackColor = Color.DarkOrange;
            ApplyBranch.ForeColor = Color.White;
            ApplyBranch.FlatAppearance.BorderSize = 0;
        }

        private void ApplyBranch_MouseLeave(object sender, EventArgs e)
        {
            ApplyBranch.BackColor = Color.White;
            ApplyBranch.ForeColor = Color.DarkOrange;
            ApplyBranch.FlatAppearance.BorderSize = 2;
        }

        private void ResetBranch_MouseEnter(object sender, EventArgs e)
        {
            ResetBranch.BackColor = Color.DarkOrange;
            ResetBranch.ForeColor = Color.White;
            ResetBranch.FlatAppearance.BorderSize = 0;
        }

        private void ResetBranch_MouseLeave(object sender, EventArgs e)
        {
            ResetBranch.BackColor = Color.White;
            ResetBranch.ForeColor = Color.DarkOrange;
            ResetBranch.FlatAppearance.BorderSize = 2;
        }
    }
}
