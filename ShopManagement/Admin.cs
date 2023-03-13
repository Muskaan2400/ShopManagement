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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderProducts OProduct = new frmOrderProducts();
            OProduct.Show();
            OProduct.MdiParent = this;
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnorderProduct objunorder = new frmUnorderProduct();
            objunorder.Show();
            objunorder.MdiParent = this;
        }

        private void unorderCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnorderCustomer customer = new frmUnorderCustomer();
            customer.Show();
            customer.MdiParent = this;

        }
    }
}
