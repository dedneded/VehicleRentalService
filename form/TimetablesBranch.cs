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
    public partial class TimetablesBranch : Form
    {
        int current_page = 0;
        static int page_count = 0;
        TimetableBranch timetable = new TimetableBranch();
        int[,] list_pages;
        Branch branch;
        bool m;
        List<TimetableBranch> list;
        public TimetablesBranch(Branch branch)
        {
            InitializeComponent();
            DateTimeBranch.CustomFormat = " ";
            ToDateTimeBranch.CustomFormat = " ";
            SortingTimeBtanch.Items.Add("Начало работы");
            SortingTimeBtanch.Items.Add("Завершение работы");
            SortingTimeBtanch.Items.Add("Актуально с");
            SortingTimeBtanch.Items.Add("Актуально до");
            this.branch = branch;
            FillForm();
            Fill_AllTimeBranch(null, null);
            Add_AllTimeBranch(null, null);

        }

        private void AddTimeBranch_Click(object sender, EventArgs e)
        {
            AddTimeTableBranch obj = new AddTimeTableBranch();
            obj.Show();
        }
        private void FillForm()
        {
            m = false;
            list = timetable.GetAll(branch);
        }

        private void ChangeTimeBranch_Click(object sender, EventArgs e)
        {
            Branches obj = new Branches();
            obj.Show();
        }

        private void FiltersTimeBtanch_Enter(object sender, EventArgs e)
        {

        }
        private List<TimetableBranch> Get_List(TimetableBranch obj1, TimetableBranch obj2)
        {
            return timetable.GetAll(obj1, obj2, branch);
        }

        private void Fill_AllTimeBranch(TimetableBranch obj1, TimetableBranch obj2)
        {
            if (m)
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
        private void Add_AllTimeBranch(TimetableBranch obj1, TimetableBranch obj2)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {

            AllTimeBranch.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllTimeBranch.RowCount < 10)
                    {
                        AllTimeBranch.RowCount++;

                    }
                    TimetableBranch item = list[list_pages[current_page, j]];
                    AllTimeBranch.Rows[q].Cells[0].Value = item.StartDay;
                    AllTimeBranch.Rows[q].Cells[1].Value = item.EndDay;
                    AllTimeBranch.Rows[q].Cells[2].Value = item.RelevantFrom;
                    AllTimeBranch.Rows[q].Cells[2].Value = item.RelevantUntil;
                    q++;

                }
                else
                {



                    break;

                }

            }

        }

        private void TimetablesBranch_Load(object sender, EventArgs e)
        {

        }

        private void DateTimeBranch_ValueChanged(object sender, EventArgs e)
        {
            DateTimeBranch.CustomFormat = "dd-MM-yyyy";
        }

        private void ToDateTimeBranch_ValueChanged(object sender, EventArgs e)
        {
            ToDateTimeBranch.CustomFormat = "dd-MM-yyyy";
        }

        private void ApplyTimeBranch_Click(object sender, EventArgs e)
        {
            m = true;
            TimetableBranch item = new TimetableBranch();
            if (DateTimeBranch.CustomFormat != " " && ToDateTimeBranch.CustomFormat != " ")
            {
                item.RelevantFrom = Convert.ToDateTime(DateTimeBranch.Value.ToShortDateString());
                item.RelevantUntil = Convert.ToDateTime(ToDateTimeBranch.Value.ToShortDateString());

            }
            if (DateTimeBranch.CustomFormat != " " && ToDateTimeBranch.CustomFormat == " ")
            {
                item.RelevantFrom = Convert.ToDateTime(DateTimeBranch.Value.ToShortDateString());
            }
            if (DateTimeBranch.CustomFormat == " " && ToDateTimeBranch.CustomFormat != " ")
            {
                item.RelevantUntil = Convert.ToDateTime(ToDateTimeBranch.Value.ToShortDateString());
            }
            Fill_AllTimeBranch(item, null);
            Add_AllTimeBranch(item, null);
        }

        private void ResetTimeBranch_Click(object sender, EventArgs e)
        {
            FillForm();
            Fill_AllTimeBranch(null, null);
            Add_AllTimeBranch(null, null);
            SortingTimeBtanch.SelectedIndex = -1;
            DateTimeBranch.CustomFormat = " ";
            ToDateTimeBranch.CustomFormat = " ";
        }

        private void SortingTimeBtanch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortingTimeBtanch.SelectedIndex != -1)
            {

                if (SortingTimeBtanch.SelectedItem.ToString() == "Начало работы")
                {
                    this.AllTimeBranch.Sort(this.AllTimeBranch.Columns[0], ListSortDirection.Ascending);
                }
                if (SortingTimeBtanch.SelectedItem.ToString() == "Завершение работы")
                {
                    this.AllTimeBranch.Sort(this.AllTimeBranch.Columns[1], ListSortDirection.Ascending);
                }
                if (SortingTimeBtanch.SelectedItem.ToString() == "Актуально с")
                {
                    this.AllTimeBranch.Sort(this.AllTimeBranch.Columns[2], ListSortDirection.Ascending);
                }
                if (SortingTimeBtanch.SelectedItem.ToString() == "Актуально до")
                {
                    this.AllTimeBranch.Sort(this.AllTimeBranch.Columns[3], ListSortDirection.Ascending);
                }

            }
        }

        private void SortDescTime_Click(object sender, EventArgs e)
        {
            if (SortingTimeBtanch.SelectedItem.ToString() == "Начало работы")
            {
                this.AllTimeBranch.Sort(this.AllTimeBranch.Columns[0], ListSortDirection.Descending);
            }
            if (SortingTimeBtanch.SelectedItem.ToString() == "Завершение работы")
            {
                this.AllTimeBranch.Sort(this.AllTimeBranch.Columns[1], ListSortDirection.Descending);
            }
            if (SortingTimeBtanch.SelectedItem.ToString() == "Актуально с")
            {
                this.AllTimeBranch.Sort(this.AllTimeBranch.Columns[2], ListSortDirection.Descending);
            }
            if (SortingTimeBtanch.SelectedItem.ToString() == "Актуально до")
            {
                this.AllTimeBranch.Sort(this.AllTimeBranch.Columns[3], ListSortDirection.Descending);
            }
        }
    }
}
