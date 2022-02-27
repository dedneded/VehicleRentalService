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
    public partial class AddClient : Form
    {
        Client client;
        bool checkEdit = false;
        public AddClient()
        {
            InitializeComponent();
            client = new Client();
            ID.Visible = false;
            ID_name.Visible = false;
        }
        public AddClient(Client client)
        {
            checkEdit = true;
            InitializeComponent();
            this.client = client;
            ID.Visible = true;
            ID_name.Visible = true;
            FillForm();
        }
        private void FillForm()
        {
            ID.Text = client.Id.ToString();
            FIO.Text = client.Fio;
            PhoneNumber.Text = client.Phone;
            QuantityOrders.Text = client.GetClientOrders().ToString();
            Comm.Text = client.Comment;
        }


        private void Save_Click(object sender, EventArgs e)
        {
           
                client.Fio = FIO.Text;
            
            
            client.Phone = PhoneNumber.Text;
            client.Comment = Comm.Text;
            if(checkEdit)
            {
               
                    DialogResult dialog = MessageBox.Show(
                              "Завершить изменение клиента?",
                              "Изменение",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning
                              );
                    if (dialog == DialogResult.Yes)
                    {
                         if(client.EditClient())
                         {
                            MessageBox.Show(
                              "Изменения успешно внесены!",
                              "Сообщение",
                              MessageBoxButtons.OK);
                              this.Close();
                         }
                         else
                         {
                            MessageBox.Show("Заполните все поля корректно!");
                         }


                    }
                 


               
            }
            else
            {
                DialogResult dialog = MessageBox.Show(
                                 "Завершить добавление клиента?",
                                 "Добавление",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning
                                 );

                if (dialog == DialogResult.Yes)
                {
                    if (client.AddClient())
                    {
                        MessageBox.Show(
                          "Клиент успешно добавлен!",
                          "Сообщение",
                          MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля корректно!");
                    }


                }
                
            }
           
        }
        public Client GetResult()
        {
            return client.FindByFio(client.Fio);
        }
        private void AddClient_Load(object sender, EventArgs e)
        {

        }

        private void FIO_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(FIO.Text, out int n))
            {
                FIO.Text = "";
                errorFio.SetError(FIO, "Неверный формат!");
            }
            else
            {
                errorFio.Clear();
            }
        }

        private void CancelClient_Click(object sender, EventArgs e)
        {
            if (checkEdit)
            {


                DialogResult dialog = MessageBox.Show(
                          "Отменить изменение клиента?",
                          "Отмена",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Warning
                          );
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            
            {
                DialogResult dialog = MessageBox.Show(
                             "Отменить создание клиента?",
                             "Отмена",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning
                             );
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                     "Вы действительно хотите выйти?",
                     "Выход",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning
                     );
            if (dialog == DialogResult.Yes)
            {

                e.Cancel = false;
                
            }
            if (dialog == DialogResult.No) { e.Cancel = true; }
        }
    }
}
