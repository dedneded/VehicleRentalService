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
    public partial class AddDiscount : Form
    {
        Discount discount= new Discount();
        List<Branch> branch;
        List<CategoryOfVehicle> category;
        List<Service> service;
        CategoryOfVehicle categories = new CategoryOfVehicle();
        Service services = new Service();
        Branch branches = new Branch();
        public AddDiscount()
        {
            InitializeComponent();
        }

        private void CategoryOfVehicle_Choose_Click(object sender, EventArgs e)
        {
            bool z = true;
            AddCategoryOfVehicle obj = new AddCategoryOfVehicle(z);
            obj.ShowDialog();
            category = obj.GetAllCategories();
            if (category.Count == 0)
            {
                CategoryOfVehicle.Text = "не выбрано";
            }
            else
            {
                CategoryOfVehicle.Text = Convert.ToString(category.Count);
            }

        }

        private void BranchDiscountChoose_Click(object sender, EventArgs e)
        {
            bool m = true;
            Branches obj = new Branches(m);
            obj.ShowDialog();
            branch = obj.GetAllBranches();
            if (branch.Count == 0)
            {
                BranchDiscount.Text = "не выбрано";
            }
            else
            {
                BranchDiscount.Text = Convert.ToString(branch.Count);
            }
        }

        private void AddDiscount_Load(object sender, EventArgs e)
        {

        }

        private void SaveDiscount_Click(object sender, EventArgs e)
        {
            discount.Name = NameDiscount.Text;
            discount.Start = StartDiscountDay.Value;
            discount.End = EndDiscountDay.Value;
            decimal i;
            decimal.TryParse(Discount.Text, out i);
            discount.PriceModifier = i;
            if (IsOptional.Checked == true)
            {
                discount.IsOptional = true;
            }
            else
            {
                discount.IsOptional = false;
            }
            if (AllVehicles.Checked == true)
            {
                discount.ForAllCategories = true;
            }
            else
            {
                discount.ForAllCategories = false;
            }
            if (AllBranchesDiscount.Checked == true)
            {
                discount.ForAllBranches = true;
            }
            else
            {
                discount.ForAllBranches = false;
            }
            if (AllServiceDiscount.Checked == true)
            {
                discount.ForAllServices = true;
            }
            else
            {
                discount.ForAllServices = false;
            }
            discount.AddDiscount(category, branch, service);


        }

        private void AllVehicles_CheckedChanged(object sender, EventArgs e)
        {
            if (AllVehicles.Checked == true)
            {
                category = categories.GetAll();
                CategoryOfVehicle.Text = "Все";
            }

            if (AllVehicles.Checked == false)
            {
                CategoryOfVehicle.Text = "не выбрано";
                category = null;
            }

        }

        private void AllBranchesDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (AllBranchesDiscount.Checked == true)
            {
                branch = branches.GetAll(null, null);
                BranchDiscount.Text = "Все";
            }
            if (AllBranchesDiscount.Checked == false)
            {
                BranchDiscount.Text = "не выбрано";
                branch = null;
            }


        }

        private void ChooseServiceDiscount_Click(object sender, EventArgs e)
        {
            bool z = true;
            Services obj = new Services(z);
            obj.ShowDialog();
            service = obj.GetAllServices();
            if (service.Count == 0)
            {
                ServicesDiscount.Text = "не выбрано";
            }
            else
            {
                ServicesDiscount.Text = Convert.ToString(service.Count);
            }
        }

        private void AllServiceDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (AllServiceDiscount.Checked == true)
            {
                service = services.GetAll(null, null);
                ServicesDiscount.Text = "Все";
            }
            if (AllServiceDiscount.Checked == false)
            {
                ServicesDiscount.Text = "не выбрано";
                service = null;
            }
        }

        private void StartDiscountDay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
