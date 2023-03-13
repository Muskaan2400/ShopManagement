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
    public partial class frmUnorderProduct : Form
    {
        public frmUnorderProduct()
        {
            InitializeComponent();
        }

        private void grdUnorderproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void frmUnorderProduct_Load(object sender, EventArgs e)
        {
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.UnorderdProduct();



            grdUnorderproduct.DataSource = dt;
            grdUnorderproduct.Show();
        }
    }
}
