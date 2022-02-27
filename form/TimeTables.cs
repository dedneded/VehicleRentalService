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

    public partial class TimeTables : Form
    {
        TimetableEmployee timetable = new TimetableEmployee();
        int current_page = 0;
        static int page_count = 0;
        int[,] list_pages;
        Driver driver;
        List<TimetableEmployee> list;
        bool m = false;
        public TimeTables(Driver driver)
        {
            InitializeComponent();
            SortingTimeTables.Items.Add("Id");
            SortingTimeTables.Items.Add("Начало смены");
            SortingTimeTables.Items.Add("Окончание смены");
            BranchTimeTablesDay.CustomFormat = " ";
            ToDayBranchTimeTables.CustomFormat = " ";
            this.driver = driver;
            list = timetable.GetAll(driver);
            Fill_AllEmployees(null, null);
            Add_AllDiscounts(null, null);
           
            

        }
        private void FillForm()
        {
            m = false;
            list = timetable.GetAll(driver);
            
        }
      
        private void TimeTables_Load(object sender, EventArgs e)
        {

        }
        private List<TimetableEmployee> Get_List(TimetableEmployee obj1, TimetableEmployee obj2)
        {

            var obj = timetable.GetAll(obj1, obj2, driver);
            return obj;
        }
        private void Fill_AllEmployees(TimetableEmployee obj1, TimetableEmployee obj2)
        {
        if(m)
        {
                list = Get_List(obj1, obj2);
        }
            page_count = list.Count / 10;
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

        private void Add_AllDiscounts(TimetableEmployee obj1, TimetableEmployee obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
        
            AllTimeTables.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllTimeTables.RowCount < 10)
                    {
                        AllTimeTables.RowCount++;


                    }
                    TimetableEmployee item = list[list_pages[current_page, j]];
                    AllTimeTables.Rows[q].Cells[0].Value = item.Id;
                    AllTimeTables.Rows[q].Cells[1].Value = item.StartDay;
                    AllTimeTables.Rows[q].Cells[2].Value = item.EndDay;
                    
                    


                    q++;

                }
                else
                {



                    break;

                }

            }

        }

        private void AddTimeTables_Click(object sender, EventArgs e)
        {
            AddTimetable obj = new AddTimetable();
            obj.Show();
        }

        private void ChangeEmployeeTimeTables_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
        }

        private void ChangeBranchTimeTables_Click(object sender, EventArgs e)
        {
           
            Branches obj = new Branches();
            obj.Show();
        }

        private void ApplyTimeTable_Click(object sender, EventArgs e)
        {
            m = true;
            TimetableEmployee item = new TimetableEmployee();
            TimetableEmployee item1 = new TimetableEmployee();
            int z;
            Int32.TryParse(IDTimeTables.Text, out z);
            item.Id = z;
            if(BranchTimeTablesDay.CustomFormat != " " && ToDayBranchTimeTables.CustomFormat != " ")
            {
                item.StartDay = Convert.ToDateTime(BranchTimeTablesDay.Value.ToShortDateString());
                item1.StartDay = Convert.ToDateTime(ToDayBranchTimeTables.Value.ToShortDateString());
            }
            if (BranchTimeTablesDay.CustomFormat != " " )
            {
                item.StartDay = Convert.ToDateTime(BranchTimeTablesDay.Value.ToShortDateString());
            }
            if (ToDayBranchTimeTables.CustomFormat != " ")
            {
                item1.StartDay = Convert.ToDateTime(ToDayBranchTimeTables.Value.ToShortDateString());
            }


            Fill_AllEmployees(item, item1);
            Add_AllDiscounts(item, item1);
        }

        private void BranchTimeTablesDay_ValueChanged(object sender, EventArgs e)
        {
            BranchTimeTablesDay.CustomFormat = "dd-MM-yyyy"; 
        }

        private void ToDayBranchTimeTables_ValueChanged(object sender, EventArgs e)
        {
            ToDayBranchTimeTables.CustomFormat = "dd-MM-yyyy";
        }

        private void SortingTimeTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortingTimeTables.SelectedIndex != -1)
            {

                if (SortingTimeTables.SelectedItem.ToString() == "Id")
                {
                    this.AllTimeTables.Sort(this.AllTimeTables.Columns[0], ListSortDirection.Ascending);
                }
                if (SortingTimeTables.SelectedItem.ToString() == "Начало смены")
                {
                    this.AllTimeTables.Sort(this.AllTimeTables.Columns[1], ListSortDirection.Ascending);
                }
                if (SortingTimeTables.SelectedItem.ToString() == "Окончание смены")
                {
                    this.AllTimeTables.Sort(this.AllTimeTables.Columns[2], ListSortDirection.Ascending);
                }
                
            }
        }

        private void SortDescTime_Click(object sender, EventArgs e)
        {
            if (SortingTimeTables.SelectedItem.ToString() == "Id")
            {
                this.AllTimeTables.Sort(this.AllTimeTables.Columns[0], ListSortDirection.Descending);
            }
            if (SortingTimeTables.SelectedItem.ToString() == "Начало смены")
            {
                this.AllTimeTables.Sort(this.AllTimeTables.Columns[1], ListSortDirection.Descending);
            }
            if (SortingTimeTables.SelectedItem.ToString() == "Окончание смены")
            {
                this.AllTimeTables.Sort(this.AllTimeTables.Columns[2], ListSortDirection.Descending);
            }
        }

        private void ResetTimeTable_Click(object sender, EventArgs e)
        {
            FillForm();
            Fill_AllEmployees(null, null);
            Add_AllDiscounts(null, null);
            SortingTimeTables.SelectedIndex = -1;
            IDTimeTables.Clear();
            BranchTimeTablesDay.CustomFormat = " ";
            ToDayBranchTimeTables.CustomFormat = " ";
        }
    }
}
