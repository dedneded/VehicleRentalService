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
    public partial class SeeDiscount : Form
    {
        Branch branch = new Branch();
        Discount discount = new Discount();
        List<Branch> branches = new List<Branch>();
        public SeeDiscount(int z)
        {
            InitializeComponent();
            FillForm(discount.FindById(z));
        }
        private void FillForm(Discount discount)
        {
            IDDiscountInfo.Text = discount.Id.ToString();
            NameDiscountInfo.Text = discount.Name;
            DiscountInfo.Text = discount.PriceModifier.ToString();
            StartDiscountInfo.Text = discount.Start.ToString();
            EndDiscountInfo.Text = discount.End.ToString();
            branches = discount.FindDiscountBranches(discount);
            QuantityBranch.Text = $"{branches.Count}";
        }

        private void InfoOrdersDiscount_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
        }

        private void SeeDiscount_Load(object sender, EventArgs e)
        {

        }

        private void SeeBranch_Click(object sender, EventArgs e)
        {
            Branches obj = new Branches(branches);
            obj.ShowDialog();
        }
    }
}
