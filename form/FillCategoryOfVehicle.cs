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
    public partial class FillCategoryOfVehicle : Form
    {
        bool check;
        CategoryOfVehicle category = new CategoryOfVehicle();
        List<string> str = new List<string>();
        public FillCategoryOfVehicle(bool m)
        {
            InitializeComponent();
            check = m;
            if(!check){
                FillForm();
            }
            else{
                Subcategory.Visible = false;
            }
           
        }

        private void FillCategoryOfVehicle_Load(object sender, EventArgs e)
        {

        }
        private void FillForm()
        {
        foreach(CategoryOfVehicle item in category.GetAll())
        {
                NewCategory.Items.Add(item.Name);
        }
       
            
        }
        public List<string> CreateCategory()
        {
            if (CategoryOfVehicleNew.Text != "" && CategoryOfVehicle.Checked)
            {
                str.Add(CategoryOfVehicleNew.Text);
            }
           
                if (CategoryOfVehicleNew.Text != "" && ChooseParent.Visible == true && NewCategory.Text != "")
                {
                    str.Add(NewCategory.SelectedItem.ToString());
                    str.Add(CategoryOfVehicleNew.Text);

                }
            
           
            return str;

        }
        public List<string> GetResult()
        {
            return str;
        }


        private void CategoryOfVehicle_CheckedChanged(object sender, EventArgs e)
        {
            if (CategoryOfVehicle.Checked)
            {
                ChooseParent.Visible = false;
                NewCategory.Visible = false;
                NameCategory.Text = "Новая категория";
            }
            else 
            {
                ChooseParent.Visible = true;
                NewCategory.Visible = true;
                NameCategory.Text = "Новая подкатегория";
            }

        }

        private void SaveCategory_Click(object sender, EventArgs e)
        {
            CreateCategory();

            this.Close();
            
        }
    }
}
