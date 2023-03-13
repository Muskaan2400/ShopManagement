using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class frmOfferForm : Form
    {
        
        public frmOfferForm(string productname,string mrp, string OrderID)
        {
            InitializeComponent();
            lblOGProduct.Text = productname;
            lblOGPrices.Text = mrp;
            lblOrderID.Text = OrderID;
        }
        private void btnCalcNewPrice_Click(object sender, EventArgs e)
        {
            decimal MRP = Convert.ToDecimal(lblOGPrices.Text);
            decimal Discount = Convert.ToDecimal(txtbxDiscPercent.Text);
            decimal NewPrice = MRP-(MRP*Discount/100);
            txtbxNewPrice.Text = NewPrice.ToString();
        }

        private void btnUpdatedPrice_Click(object sender, EventArgs e)
        {
            int discount = Convert.ToInt32(txtbxDiscPercent.Text);
            int orderid = Convert.ToInt32(lblOrderID.Text);
            decimal newprice = Convert.ToDecimal(txtbxNewPrice.Text);
            clsRegister objshop = new clsRegister(orderid, discount, newprice);
            objshop.Update();
            MessageBox.Show("Update Succesfully");
        }

        private void frmOfferForm_Load(object sender, EventArgs e)
        {

        }
    }
}