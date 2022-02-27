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
    public partial class Roles : Form
    {
        int current_page = 0;
        static int page_count = 0;
        Role role = new Role();
        int[,] list_pages;
        public Roles()
        {
            InitializeComponent();
            Fill_AllRoles(null, null);
            Add_AllClients(null, null);
            SortingRoles.Items.Add("Id");
            SortingRoles.Items.Add("Название");
        }

        private void Roles_Load(object sender, EventArgs e)
        {

        }
        private List<Role> Get_List(Role obj1, Role obj2)
        {

            var obj = role.GetAll(obj1, obj2);
            return obj;
        }

        private void Fill_AllRoles(Role obj1, Role obj2)
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

        private void Add_AllClients(Role obj1, Role obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
            AllRoles.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllRoles.RowCount < 10)
                    {
                        AllRoles.RowCount++;


                    }
                    Role item = Get_List(obj1, obj2)[list_pages[current_page, j]];
                    AllRoles.Rows[q].Cells[0].Value = item.Id;
                    AllRoles.Rows[q].Cells[1].Value = item.Name;
                    


                    q++;

                }
                else
                {



                    break;

                }

            }

        }

        private void ApplyRoles_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            Int32.TryParse(IDRoles.Text, out int m);
            role.Id = m;
            role.Name = RolesName.Text;
            Fill_AllRoles(role, null);
            Add_AllClients(role, null);

        }

        private void ResetRoles_Click(object sender, EventArgs e)
        {
            IDRoles.Clear();
            RolesName.Clear();
            SortingRoles.SelectedIndex = -1;
            Fill_AllRoles(null, null);
            Add_AllClients(null, null);
        }

        private void SortingRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortingRoles.SelectedIndex != -1)
            {

                if (SortingRoles.SelectedItem.ToString() == "Id")
                {
                    this.AllRoles.Sort(this.AllRoles.Columns[0], ListSortDirection.Ascending);
                }
                if (SortingRoles.SelectedItem.ToString() == "Название")
                {
                    this.AllRoles.Sort(this.AllRoles.Columns[1], ListSortDirection.Ascending);
                }

            }
        }

        private void SortDescRole_Click(object sender, EventArgs e)
        {
            if (SortingRoles.SelectedIndex != -1)
            {
                if (SortingRoles.SelectedItem.ToString() == "Id")
                {
                    this.AllRoles.Sort(this.AllRoles.Columns[0], ListSortDirection.Descending);
                }
                if (SortingRoles.SelectedItem.ToString() == "Название")
                {
                    this.AllRoles.Sort(this.AllRoles.Columns[1], ListSortDirection.Descending);
                }
            }
        }
        public Role GetResult()
        {
            return role;
        }
        private void AllRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = Convert.ToInt32(AllRoles.Rows[AllRoles.CurrentRow.Index].Cells[0].Value);
            role = role.FindById(z);
            this.Close();
            
        }
    }
}
