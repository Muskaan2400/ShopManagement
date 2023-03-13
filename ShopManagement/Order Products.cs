using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class frmOrderProducts : Form
    {
        public frmOrderProducts()
        {
            InitializeComponent();
        }
        private void frmOrderProducts_Load(object sender, EventArgs e)
        {
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.orderproduct();
            grdOrderProductShow.DataSource = dt;
            grdOrderProductShow.Show();
        }
        private void grdOrderProductShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void grdOrderProductShow_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string product = grdOrderProductShow.Rows[grdOrderProductShow.CurrentRow.Index].Cells[7].Value.ToString();
            string MRP = grdOrderProductShow.Rows[grdOrderProductShow.CurrentRow.Index].Cells[9].Value.ToString();
            string orderid = grdOrderProductShow.Rows[grdOrderProductShow.CurrentRow.Index].Cells[1].Value.ToString();
            if(e.ColumnIndex==1)
            {
                frmOfferForm Offer = new frmOfferForm(product, MRP, orderid);
                Offer.Show();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.orderproduct();
            grdOrderProductShow.DataSource = dt;
            grdOrderProductShow.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name=txtbxSearchByName.Text;
            string productName = txtbxSearchByProduct.Text;

            clsRegister objshop = new clsRegister(name,productName);
            DataTable dt = new DataTable();
            dt = objshop.Search();
            grdOrderProductShow.DataSource = dt;
            grdOrderProductShow.Show();
        }
        private void CheckBox_Unchecked(object sender, EventArgs e)

        {
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(DataGridViewRow row in grdOrderProductShow.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    int OrderID = Convert.ToInt32(row.Cells[2].Value);
                    clsRegister obj = new clsRegister(OrderID);
                    obj.ISDeleted();
                    grdOrderProductShow.Rows.Remove(row);
                    i++;
                }
            }
        }
    }
}