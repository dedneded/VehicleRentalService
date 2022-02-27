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
    public partial class Clients : Form
    {
        int current_page = 0;
        static int page_count = 0;
        Client client = new Client();
        int[,] list_pages;
        public Clients()
        {
            InitializeComponent();
            Fill_AllClients(null, null, 0, 0);
            Add_AllClients(null, null, 0, 0);
            ClientsSorting.Items.Add("Id");
            ClientsSorting.Items.Add("ФИО");
          


        }


        private void AddClinets_Click(object sender, EventArgs e)
        {
            AddClient obj = new AddClient();
            obj.Show();
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private List<Client> Get_List(Client obj1, Client obj2, int From, int To)
        {

            var obj = client.GetAll(obj1, obj2, From, To);
            return obj;
        }

        private void Fill_AllClients(Client obj1, Client obj2, int From, int To)
        {
            page_count = (Get_List(obj1, obj2, From, To).Count) / 10;
            if (Get_List(obj1, obj2, From, To).Count % 10 > 0)
            {
                page_count++;
            }
            list_pages = new int[page_count, 10];
            int y = Get_List(obj1, obj2, From, To).Count - 1;
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

        private void Add_AllClients(Client obj1, Client obj2, int From, int To)//Заполнение таблицы элементами листа по индексам, взятым из матрицы
        {
            AllClients.RowCount = 1;
            int q = 0;
            int i = current_page;
            for (int j = 0; j <= 9; j++)
            {
                if (list_pages[i, j] != -1 && q < 10)
                {

                    if (AllClients.RowCount < 10)
                    {
                        AllClients.RowCount++;


                    }
                    Client item = Get_List(obj1, obj2, From, To)[list_pages[current_page, j]];
                    AllClients.Rows[q].Cells[0].Value = item.Id;
                    AllClients.Rows[q].Cells[1].Value = item.Fio;
                    AllClients.Rows[q].Cells[2].Value = item.Phone;


                    q++;

                }
                else
                {

                    AllClients.Rows.RemoveAt(AllClients.Rows.Count-1);

                    break;

                }

            }

        }

        

        private void Filters()
        {

        try
        {
                Client obj = new Client();
                if (IDClients.Text != "")
                {
                    obj.Id = int.Parse(IDClients.Text);
                }
                if (FIOClients.Text != "")
                {
                    obj.Fio = FIOClients.Text;
                }
                if (PhoneClients.Text != "")
                {
                    obj.Phone = PhoneClients.Text;
                }

                Client obj2 = new Client();
                if (From.Text != "" && ToClients.Text != "")
                {
                    Fill_AllClients(obj, obj2, Convert.ToInt32(From.Text), Convert.ToInt32(ToClients.Text));
                    Add_AllClients(obj, obj2, Convert.ToInt32(From.Text), Convert.ToInt32(ToClients.Text));
                }
                if (From.Text == "" && ToClients.Text == "")
                {
                    Fill_AllClients(obj, obj2, 0, 0);
                    Add_AllClients(obj, obj2, 0, 0);
                }
                if (From.Text == "" && ToClients.Text != "")
                {
                    Fill_AllClients(obj, obj2, 0, Convert.ToInt32(ToClients.Text));
                    Add_AllClients(obj, obj2, 0, Convert.ToInt32(ToClients.Text));
                }
                if (From.Text != "" && ToClients.Text == "")
                {
                    Fill_AllClients(obj, obj2, Convert.ToInt32(From.Text), 0);
                    Add_AllClients(obj, obj2, Convert.ToInt32(From.Text), 0);
                }
            }
            catch
            {
                MessageBox.Show("Такого клиента не существует!");

                Fill_AllClients(null, null, 0, 0);
                Add_AllClients(null, null, 0, 0);
            }
           


        }

        private void ApplyFilters_Click(object sender, EventArgs e)
        {
            Filters();
        }

        private void SortDesc_Clients_Click(object sender, EventArgs e)
        {
            if (ClientsSorting.SelectedItem.ToString() == "Id")
            {
                this.AllClients.Sort(this.AllClients.Columns[0], ListSortDirection.Descending);
            }
            if (ClientsSorting.SelectedItem.ToString() == "ФИО")
            {
                this.AllClients.Sort(this.AllClients.Columns[1], ListSortDirection.Descending);
            }
        }

        private void ClientsSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientsSorting.SelectedIndex != -1)
            {

                if (ClientsSorting.SelectedItem.ToString() == "Id")
                {
                    this.AllClients.Sort(this.AllClients.Columns[0], ListSortDirection.Ascending);
                }
                if (ClientsSorting.SelectedItem.ToString() == "ФИО")
                {
                    this.AllClients.Sort(this.AllClients.Columns[1], ListSortDirection.Ascending);
                }
                
            }
        }

        private void ResetFilters_Click(object sender, EventArgs e)
        {
            Fill_AllClients(null, null, 0, 0);
            Add_AllClients(null, null, 0, 0);
            ClientsSorting.SelectedIndex = -1;
            IDClients.Clear();
            FIOClients.Clear();
            PhoneClients.Clear();
            From.Clear();
            ToClients.Clear();
        }
        public Client GetResult()
        {
            return client;
        }

        private void AllClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int z = Convert.ToInt32(AllClients.Rows[AllClients.CurrentRow.Index].Cells[0].Value);
            SeeClient obj = new SeeClient(z);
            obj.ShowDialog();
        }

        

        private void ChooseClinets_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(AllClients.Rows[AllClients.CurrentRow.Index].Cells[0].Value);
            client = client.FindById(z);
            this.Close();
        }

        private void IDClients_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(IDClients.Text, out int n))
            {
                IDClients.Text = "";
                ErrorId.SetError(IDClients, "Неверный формат!");
            }
            else
            {
                ErrorId.Clear();
            }
            ErrorFrom.Clear();
            ErrorTo.Clear();
            ErrorFio.Clear();

        }

        private void FIOClients_TextChanged(object sender, EventArgs e)
        {
           
            if (int.TryParse(FIOClients.Text, out int n))
            {
                FIOClients.Text = "";
                ErrorFio.SetError(FIOClients, "Неверный формат!");
            }
            else
            {

                ErrorFio.Clear();
            }
            ErrorId.Clear();
            ErrorFrom.Clear();
            ErrorTo.Clear();


        }

        private void From_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(From.Text, out int n))
            {
                From.Text = "";
                ErrorFrom.SetError(From, "Неверный формат!");
            }
            else
            {
                ErrorFrom.Clear();

            }
            ErrorId.Clear();
            ErrorTo.Clear();
            ErrorFio.Clear();

        }

        private void ToClients_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(ToClients.Text, out int n))
            {
                ToClients.Text = "";
                ErrorTo.SetError(ToClients, "Неверный формат!");
            }
            else
            {
                ErrorTo.Clear();
            }
            ErrorId.Clear();
            ErrorFio.Clear();
            ErrorFrom.Clear();
        }

        private void ChooseClinets_MouseEnter(object sender, EventArgs e)
        {
           
            ChooseClinets.BackColor = Color.White;
            ChooseClinets.ForeColor = Color.DarkOrange;
            ChooseClinets.FlatAppearance.BorderSize = 3;
            

        }

        private void ChooseClinets_MouseLeave(object sender, EventArgs e)
        {
            ChooseClinets.BackColor = Color.DarkOrange;
            ChooseClinets.ForeColor = Color.White;
            ChooseClinets.FlatAppearance.BorderSize = 0;
            

        }

        private void AddClinets_MouseEnter(object sender, EventArgs e)
        {
            AddClinets.BackColor = Color.White;
            AddClinets.ForeColor = Color.DarkOrange;
            AddClinets.FlatAppearance.BorderSize = 3;
        }

        private void AddClinets_MouseLeave(object sender, EventArgs e)
        {
            AddClinets.BackColor = Color.DarkOrange;
            AddClinets.ForeColor = Color.White;
            AddClinets.FlatAppearance.BorderSize = 0;
        }

        private void ApplyFilters_MouseEnter(object sender, EventArgs e)
        {
            ApplyFilters.BackColor = Color.DarkOrange;
            ApplyFilters.ForeColor = Color.White;
            ApplyFilters.FlatAppearance.BorderSize = 0;

            
        }

        private void ApplyFilters_MouseLeave(object sender, EventArgs e)
        {
            ApplyFilters.BackColor = Color.White;
            ApplyFilters.ForeColor = Color.DarkOrange;
            ApplyFilters.FlatAppearance.BorderSize = 2;
        }

        private void ResetFilters_MouseEnter(object sender, EventArgs e)
        {
            ResetFilters.BackColor = Color.DarkOrange;
            ResetFilters.ForeColor = Color.White;
            ResetFilters.FlatAppearance.BorderSize = 0;
        }

        private void ResetFilters_MouseLeave(object sender, EventArgs e)
        {
            ResetFilters.BackColor = Color.White;
            ResetFilters.ForeColor = Color.DarkOrange;
            ResetFilters.FlatAppearance.BorderSize = 2;

            
        }
    }
}
