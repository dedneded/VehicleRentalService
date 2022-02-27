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
    public partial class Discounts : Form
    {
        Branch branch = new Branch();
        int current_page = 0;
        static int page_count = 0;
        Discount discount = new Discount();
        int[,] list_pages;
        bool check;
        List<Discount> list = new List<Discount>();
        public Discounts()
        {
            InitializeComponent();
            Fill_AllDiscounts(null, null);
            Add_AllDiscounts(null, null);
            FillForm();
        }
        public Discounts(bool m, List<Discount> list)
        {
            InitializeComponent();
            check = m;
            this.list = list;
            Fill_AllDiscounts(null, null);
            Add_AllDiscounts(null, null);
            FillForm();
            FillCheckbox();
        }

        private void AddDiscounts_Click(object sender, EventArgs e)
        {
            AddDiscount obj = new AddDiscount();
            obj.Show();
        }

        private void BranchDiscountsChoose_Click(object sender, EventArgs e)
        {
            Branches obj = new Branches();
            obj.ShowDialog();
            branch = obj.GetResult();
            BranchDiscounts.Text = Convert.ToString(branch.Address);
            Filters();
        }
        private void FillCheckbox()
        {
        if(list.Count != 0)
        {
        foreach(Discount item in list)
        {
                    for (int i = 0; i <= AllDiscounts.RowCount - 1; i++)
                    {
                        
                    
                    if(item.Id == Convert.ToInt32(AllDiscounts.Rows[i].Cells[1].Value))
                    {
                            AllDiscounts.Rows[i].Cells[0].Value = true;
                    }
                       
                    }
                }
        }
        }
       private void FillForm()
       {
            
       if (check)
       {
                AllDiscounts.Columns[0].Visible = true;
       }
       else
       {
                AllDiscounts.Columns[0].Visible = false;
            }
            SortingDiscounts.Items.Add("Id");
            SortingDiscounts.Items.Add("Название");
            SortingDiscounts.Items.Add("Начало действия");
            SortingDiscounts.Items.Add("Окончание действия");
            SortingDiscounts.Items.Add("Размер");
            SortingDiscounts.Items.Add("Филиал");
            ToDiscounts.Enabled = false;
            FromDiscounts.Enabled = false;


        }
        private List<Discount> Get_List(Discount obj1, Discount obj2)
        {

            var obj = discount.GetAll(obj1, obj2);
            return obj;
        }
        private void Fill_AllDiscounts(Discount obj1, Discount obj2)
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

        private void Add_AllDiscounts(Discount obj1, Discount obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
            AllDiscounts.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllDiscounts.RowCount < 10)
                    {
                        AllDiscounts.RowCount++;


                    }
                    Discount item = Get_List(obj1, obj2)[list_pages[current_page, j]];
                    AllDiscounts.Rows[q].Cells[1].Value = item.Id;
                    AllDiscounts.Rows[q].Cells[2].Value = item.Name;
                    AllDiscounts.Rows[q].Cells[3].Value = item.Start;
                    AllDiscounts.Rows[q].Cells[4].Value = item.End;
                    AllDiscounts.Rows[q].Cells[5].Value = item.PriceModifier;


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
            Branch item = new Branch();
            Discount obj = new Discount();
            if (IDDiscounts.Text != "")
            {
                obj.Id = int.Parse(IDDiscounts.Text);
            }
           
                obj.Name = NameDiscounts.Text;
            //if(CityDiscounts.Text != "")
            //{
            //    item.Address = CityDiscounts.Text;
            //    obj.Branch = item;
            //}
        
          
           
            if(FromDiscounts.Enabled != false)
            {
                obj.Start = FromDiscounts.Value;
            }
            if (ToDiscounts.Enabled != false)
            {
                obj.End = ToDiscounts.Value;
            }


            Discount obj2 = new Discount();
            //if (BranchDiscounts.Text != "не выбрано")
            //{
            //    obj2.Branch = branch;
            //}



            Fill_AllDiscounts(obj, obj2);
            Add_AllDiscounts(obj, obj2);
        }
        private void Discounts_Load(object sender, EventArgs e)
        {

        }

        private void SortingDiscounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortingDiscounts.SelectedIndex != -1)
            {

                if (SortingDiscounts.SelectedItem.ToString() == "Id")
                {
                    this.AllDiscounts.Sort(this.AllDiscounts.Columns[0], ListSortDirection.Ascending);
                }
                if (SortingDiscounts.SelectedItem.ToString() == "Название")
                {
                    this.AllDiscounts.Sort(this.AllDiscounts.Columns[1], ListSortDirection.Ascending);
                }
                if (SortingDiscounts.SelectedItem.ToString() == "Начало действия")
                {
                    this.AllDiscounts.Sort(this.AllDiscounts.Columns[2], ListSortDirection.Ascending);
                }
                if (SortingDiscounts.SelectedItem.ToString() == "Окончание действия")
                {
                    this.AllDiscounts.Sort(this.AllDiscounts.Columns[3], ListSortDirection.Ascending);
                }
                if (SortingDiscounts.SelectedItem.ToString() == "Размер")
                {
                    this.AllDiscounts.Sort(this.AllDiscounts.Columns[4], ListSortDirection.Ascending);
                }
                if (SortingDiscounts.SelectedItem.ToString() == "Филиал")
                {
                    this.AllDiscounts.Sort(this.AllDiscounts.Columns[5], ListSortDirection.Ascending);
                }
            }
        }

        private void ResetDiscounts_Click(object sender, EventArgs e)
        {
            Fill_AllDiscounts(null, null);
            Add_AllDiscounts(null, null);
            SortingDiscounts.SelectedIndex = -1;
            IDDiscounts.Clear();
            NameDiscounts.Clear();
            CityDiscounts.Clear();
            
        }

        private void SortDesc_Discounts_Click(object sender, EventArgs e)
        {
            if (SortingDiscounts.SelectedItem.ToString() == "Id")
            {
                this.AllDiscounts.Sort(this.AllDiscounts.Columns[0], ListSortDirection.Descending);
            }
            if (SortingDiscounts.SelectedItem.ToString() == "Название")
            {
                this.AllDiscounts.Sort(this.AllDiscounts.Columns[1], ListSortDirection.Descending);
            }
            if (SortingDiscounts.SelectedItem.ToString() == "Начало действия")
            {
                this.AllDiscounts.Sort(this.AllDiscounts.Columns[2], ListSortDirection.Descending);
            }
            if (SortingDiscounts.SelectedItem.ToString() == "Окончание действия")
            {
                this.AllDiscounts.Sort(this.AllDiscounts.Columns[3], ListSortDirection.Descending);
            }
            if (SortingDiscounts.SelectedItem.ToString() == "Размер")
            {
                this.AllDiscounts.Sort(this.AllDiscounts.Columns[4], ListSortDirection.Descending);
            }
            if (SortingDiscounts.SelectedItem.ToString() == "Филиал")
            {
                this.AllDiscounts.Sort(this.AllDiscounts.Columns[5], ListSortDirection.Descending);
            }
        }

        private void ApplyDiscounts_Click(object sender, EventArgs e)
        {
            Filters();
        }

        private void FromCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FromCheck.Checked == true)
            {
                FromDiscounts.Enabled = true;
            }
            else
            {
                FromDiscounts.Enabled = false;
            }
        }

        private void ToCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ToCheck.Checked == true)
            {
                ToDiscounts.Enabled = true;
            }
            else
            {
                ToDiscounts.Enabled = false;
            }
        }

        private void AllDiscounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = Convert.ToInt32(AllDiscounts.Rows[AllDiscounts.CurrentRow.Index].Cells[0].Value);
            SeeDiscount obj = new SeeDiscount(z);
            obj.ShowDialog();
        }
        public List<Discount> GetDiscount()
        {

            return list;
        }

        private void ChooseDiscounts_Click(object sender, EventArgs e)
        {
            int n;
            for (int i = 0; i <= AllDiscounts.RowCount - 1; i++)
            {
                n = 0;
                if (Convert.ToBoolean(AllDiscounts.Rows[i].Cells[0].Value) == true)
                {
                    foreach(Discount item in list)
                    {
                        if(item.Id == Convert.ToInt32(AllDiscounts.Rows[i].Cells[1].Value))
                        {
                            n++;
                        }
                    }
                    if(n == 0)
                    {
                        list.Add(discount.FindById(Convert.ToInt32(AllDiscounts.Rows[i].Cells[1].Value)));
                    }

                   
                }
            }
            this.Close();



            
        }

        private void ChooseDiscounts_MouseEnter(object sender, EventArgs e)
        {
            ChooseDiscounts.BackColor = Color.White;
            ChooseDiscounts.ForeColor = Color.DarkOrange;
            ChooseDiscounts.FlatAppearance.BorderSize = 3;
        }

        private void ChooseDiscounts_MouseLeave(object sender, EventArgs e)
        {
            ChooseDiscounts.BackColor = Color.DarkOrange;
            ChooseDiscounts.ForeColor = Color.White;
            ChooseDiscounts.FlatAppearance.BorderSize = 0;
        }

        private void AddDiscounts_MouseEnter(object sender, EventArgs e)
        {
            AddDiscounts.BackColor = Color.White;
            AddDiscounts.ForeColor = Color.DarkOrange;
            AddDiscounts.FlatAppearance.BorderSize = 3;
        }

        private void AddDiscounts_MouseLeave(object sender, EventArgs e)
        {
            AddDiscounts.BackColor = Color.DarkOrange;
            AddDiscounts.ForeColor = Color.White;
            AddDiscounts.FlatAppearance.BorderSize = 0;
        }

        private void ApplyDiscounts_MouseEnter(object sender, EventArgs e)
        {
            ApplyDiscounts.BackColor = Color.DarkOrange;
            ApplyDiscounts.ForeColor = Color.White;
            ApplyDiscounts.FlatAppearance.BorderSize = 0;
        }

        private void ApplyDiscounts_MouseLeave(object sender, EventArgs e)
        {
            ApplyDiscounts.BackColor = Color.White;
            ApplyDiscounts.ForeColor = Color.DarkOrange;
            ApplyDiscounts.FlatAppearance.BorderSize = 2;
        }

        private void ResetDiscounts_MouseEnter(object sender, EventArgs e)
        {
            ResetDiscounts.BackColor = Color.DarkOrange;
            ResetDiscounts.ForeColor = Color.White;
            ResetDiscounts.FlatAppearance.BorderSize = 0;
        }

        private void ResetDiscounts_MouseLeave(object sender, EventArgs e)
        {
            ResetDiscounts.BackColor = Color.White;
            ResetDiscounts.ForeColor = Color.DarkOrange;
            ResetDiscounts.FlatAppearance.BorderSize = 2;
        }
    }
}
