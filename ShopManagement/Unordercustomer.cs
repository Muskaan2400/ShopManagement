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
    public partial class frmUnorderCustomer : Form
    {
        public frmUnorderCustomer()
        {
            InitializeComponent();
        }

        private void grdUnorderCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUnorderCustomer_Load(object sender, EventArgs e)
        {
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.UnorderedCustomer();
            
            grdUnorderCustomer.DataSource = dt;
            grdUnorderCustomer.Show();
        }
    }
}
