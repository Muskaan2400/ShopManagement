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
    public partial class frmOrder : Form
    {
        public int UserId = 0;
        
        public frmOrder()
        {
            InitializeComponent();
            
        }
        public frmOrder(int Ruserid, string Rname, string REmailID, string RPhone)
        {
            InitializeComponent();
            UserId = Ruserid;
            lblOName.Text = Rname;
            lblOEmailID.Text = REmailID;
            lblOPhone.Text = RPhone;

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.GetOrderType();
            cmbbxOtype.DisplayMember = "TypeName";
            cmbbxOtype.ValueMember = "TypeID";
            cmbbxOtype.DataSource= dt;
        }

        private void cmbbxOtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxOtype.SelectedValue.ToString());
            clsRegister objshop = new clsRegister(TypeID);
            DataTable dt = new DataTable();
            dt = objshop.GetOrderProduct();
            cmbbxOProduct.DisplayMember = "ProductName";
            cmbbxOProduct.ValueMember = "ProductID";
            cmbbxOProduct.DataSource= dt;
        }

        private void cmbbxOProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sizeid = Convert.ToInt32(cmbbxOtype.SelectedValue.ToString());
            clsRegister objshop = new clsRegister();
            DataTable dt = new DataTable();
            dt = objshop.GetSizeShow();
            GrdSizeShow.DataSource=dt;
            GrdSizeShow.Show();

        }

        private void GrdSizeShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sizeid = Convert.ToInt32(GrdSizeShow.Rows[GrdSizeShow.CurrentRow.Index].Cells[0].Value.ToString());
            string size = GrdSizeShow.Rows[GrdSizeShow.CurrentRow.Index].Cells[1].Value.ToString();

            clsRegister objshop = new clsRegister(size, sizeid);
            SqlDataReader dr;
            dr = objshop.MRPShow();
            while (dr.Read())
            {
                txtbxOPrice.Text = dr["MRP"].ToString();

            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddtocart_Click(object sender, EventArgs e)
        {
            
            string type = cmbbxOtype.Text.ToString();
            string product = cmbbxOProduct.Text.ToString(); 
            string size = (GrdSizeShow.Rows[GrdSizeShow.CurrentRow.Index].Cells[1].Value.ToString());
            string sizeid = (GrdSizeShow.Rows[GrdSizeShow.CurrentRow.Index].Cells[0].Value.ToString());
            string price = txtbxOPrice.Text.ToString();

            ListViewItem list= new ListViewItem();
            list.Text = type;
            list.SubItems.Add(product);
            list.SubItems.Add(size);
            list.SubItems.Add(price);
            list.SubItems.Add(sizeid);

            listView.Items.Add(list);
        }

        private void btnRemovetocart_Click(object sender, EventArgs e)
        {
            for(int i=listView.Items.Count-1;i>=0;i--)
            {
                if(listView.Items[i].Selected)
                {
                    listView.Items[i].Remove();

                }
            }
            
        }

        

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            foreach (ListViewItem item in listView.Items)
            {
                sum += decimal.Parse(item.SubItems[3].Text);
            }
            txtTotal.Text = Convert.ToString(sum);
        }

        private void btnOrderConfirm_Click(object sender, EventArgs e)
        {
            bool ISDelete = false;
            decimal DiscountPrice = 0;
            int Discount = 0;
            DateTime OrderDate = DateTime.Now; ;
            
            string OrderStatus = "Confirm";

            for (int i=0;i<listView.Items.Count;i++)
            {
                int SizeID = Convert.ToInt32(listView.Items[i].SubItems[4].Text);
                clsRegister obj = new clsRegister(UserId, SizeID,OrderDate,OrderStatus, Discount, DiscountPrice,ISDelete);
                obj.OrderConfirm();
                
            }
            MessageBox.Show("Save Successfully");

            
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
