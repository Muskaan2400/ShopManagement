using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ShopManagement
{
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(cmbbxRType.Text=="")
            {
                MessageBox.Show("You must select conversion type");
                errorRegister.SetError(this.cmbbxRType, "You must select conversion type");
                return;
            }
            if(txtbxRname.Text=="")
            {
                MessageBox.Show("please enter your Name");
                errorRegister.SetError(this.txtbxRname, "Please Provide valid Name");
                return;
            }
            if(txtbxREmailID.Text=="")
            {
                MessageBox.Show("please enter your Email");
                errorRegister.SetError(this.txtbxREmailID, "Please Provide valid EmailID");
                return;

            }
            if (txtbxRContact.Text == "")
            {
                MessageBox.Show("please enter your contact");
                errorRegister.SetError(this.txtbxRContact, "Please Provide valid contact");
                return;

            }
            if (rdbbtnMale.Checked && rdbbtnFemale.Checked)
            {
                MessageBox.Show("please enter your Gender");
                errorRegister.SetError(this.lblGender, "Please Provide valid Gender");
                return;

            }
            if (txtbxRState.Text == "")
            {
                MessageBox.Show("please enter your State");
                errorRegister.SetError(this.txtbxRState, "Please Provide valid state");
                return;

            }
            if (txtbxRPassword.Text == "")
            {
                MessageBox.Show("please enter your Password");
                errorRegister.SetError(this.txtbxRPassword, "Please Provide valid Password");
                return;

            }


            string Typename = cmbbxRType.SelectedItem.ToString();
            string Gender = "";
            if(rdbbtnMale.Checked)
            {
                Gender = rdbbtnMale.Text;
            }
            else
            {
                Gender = rdbbtnFemale.Text;
            }

            Int64 Contact = Convert.ToInt64(txtbxRContact.Text);


            clsRegister objregi = new clsRegister(txtbxRname.Text,txtbxREmailID.Text,txtbxRState.Text,txtbxRPassword.Text, Typename, Gender,Contact);
            objregi.SaveRegister();


            MessageBox.Show("Save Successfully");
        }

        private void cmbbxRType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxRType.SelectedText))
                {
                errorRegister.Clear();
                 }
            else
            {
                errorRegister.SetError(this.cmbbxRType, "You must select a conversion type");
                return;
            }

        }

        private void txtbxRname_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z ]*$";
;
            if (Regex.IsMatch(txtbxRname.Text,pattern))
            {
                errorRegister.Clear();
            }
            else
            {
                errorRegister.SetError(this.txtbxRname, "Please provide valid state");
                return;
            }

        }

        private void txtbxRState_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z]*$";
            if (Regex.IsMatch(txtbxRState.Text, pattern))
            {
                errorRegister.Clear();
            }
            else
            {
                errorRegister.SetError(this.txtbxRState, "Please provide valid state");
                return;
            }

        }

        private void txtbxREmailID_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA]\\.)+[a-zA-Z]{2,9})$";
;
            if (Regex.IsMatch(txtbxREmailID.Text, pattern))
            {
                errorRegister.Clear();
            }
            else
            {
                errorRegister.SetError(this.txtbxREmailID, "Please provide valid Mail Address");
                return;
            }
        }

        private void lblGender_Click(object sender, EventArgs e)
        {
            if (rdbbtnMale.Checked && rdbbtnFemale.Checked)
            {
                errorRegister.Clear();
            }
            else
            {
                errorRegister.SetError(this.lblGender, "Please provide valid gender");
                return;
            }
        }

        private void txtbxRPassword_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*])";
            if (Regex.IsMatch(txtbxRPassword.Text, pattern))
            {
                errorRegister.Clear();
            }
            else
            {
                errorRegister.SetError(this.txtbxRPassword, "Please provide valid Password");
                return;
            }
        }

        private void txtbxRContact_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]{10}$"
;
            if (Regex.IsMatch(txtbxRContact.Text, pattern))
            {
                errorRegister.Clear();
            }
            else
            {
                errorRegister.SetError(this.txtbxRContact, "Please provide valid contact");
                return;
            }
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {

        }
    }
}