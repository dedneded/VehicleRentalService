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
    public partial class AddCategoryOfVehicle : Form
    {
        bool check;
        List<string> str;
            CategoryOfVehicle category;
        List<CategoryOfVehicle> list = new List<CategoryOfVehicle>();
        public AddCategoryOfVehicle(bool m)
        {
            InitializeComponent();
            category = new CategoryOfVehicle();
            CategoriesOfVehicle.CheckBoxes = false;
            check = m;
            FillForm(check);
        }
        private void FillForm(bool m)
        {
            CategoriesOfVehicle.Nodes.Clear();
            list = category.GetAll();
            foreach(CategoryOfVehicle item in list)
            {
                if(item.Parent == null)
                {
                    CategoriesOfVehicle.Nodes.Add(item.Name);
                    if (m)
                    {
                        CategoriesOfVehicle.CheckBoxes = true;
                    }
                  
                       
                    
                }
                else
                {
                if(!m)
                    {
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            if (CategoriesOfVehicle.Nodes[i].Text == item.Parent.Name)
                            {
                                CategoriesOfVehicle.Nodes[i].Nodes.Add(new TreeNode(item.Name));
                                break;
                            }
                        }
                    }
                   
                  
                   
                   

                }
            }
        }
        private void ChooseCaregoryOfVehicle_Click(object sender, EventArgs e)
        {
            category = category.FindByName(CategoriesOfVehicle.SelectedNode.Text)[0];
            this.Close();
        }

        private void AddCategoryOfVehicle_Load(object sender, EventArgs e)
        {

        }
        public CategoryOfVehicle GetResult()
        {
            return category;
        }

        

        private void NewCategory_Click(object sender, EventArgs e)
        {
            FillCategoryOfVehicle obj = new FillCategoryOfVehicle(check);
            obj.ShowDialog();
            str = obj.GetResult();
            CategoryOfVehicle item = new CategoryOfVehicle();
            try
            {
                item.Name = str[1];
                List<CategoryOfVehicle> cat = category.FindByName(str[0]);
                item.ParentId = cat[0].Id;
               
            }
            catch
            {
                item.Name = str[0];

            }
            item.AddCategoryOfVehicle();
            FillForm(check);




        }

        private void CategoriesOfVehicle_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        public List<CategoryOfVehicle> GetAllCategories()
        {
            List<CategoryOfVehicle> allcategories = new List<CategoryOfVehicle>();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (CategoriesOfVehicle.Nodes[i].Checked == true)
                {
                    CategoryOfVehicle item;
                    item = category.FindByName(CategoriesOfVehicle.Nodes[i].Text)[0];
                    allcategories.Add(item);
                    
                }
            }
            return allcategories;
        }
    }
}
