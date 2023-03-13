using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            cmbbxTypeLogin.Items.Add("Admin");
            cmbbxTypeLogin.Items.Add("Customer");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string typename=cmbbxTypeLogin.SelectedItem.ToString();
            string EmailID = txtEmailLogin.Text;
            string password = txtPasswordLogin.Text;

            clsRegister objlogin = new clsRegister(typename, EmailID, password);
            SqlDataReader dr;
            dr = objlogin.Login();
            while (dr.Read())
            {
                int Ruserid = Convert.ToInt32(dr["RegisterID"].ToString());
                string Rname = dr["RegisterName"].ToString();
                string REmailID = dr["RegisterEmailID"].ToString();
                string RPhone = dr["RegisterContact"].ToString();

                if (cmbbxTypeLogin.Text.ToString() == "Customer")
                {
                    frmOrder objorder = new frmOrder(Ruserid, Rname, REmailID, RPhone);
                    
                    MessageBox.Show("Login Successsfull");
                    objorder.Show();
                }
                else if(cmbbxTypeLogin.Text.ToString() == "Admin") 
                {
                    frmAdmin objAdmin =new frmAdmin ();

                    MessageBox.Show("Login Successfully..!");
                    objAdmin.Show();

                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
                
            }
            

        }

        private void cmbbxTypeLogin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


