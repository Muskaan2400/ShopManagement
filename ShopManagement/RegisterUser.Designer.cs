namespace ShopManagement
{
    partial class frmRegisterUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRType = new System.Windows.Forms.Label();
            this.lblRName = new System.Windows.Forms.Label();
            this.lblREmailID = new System.Windows.Forms.Label();
            this.lblRContact = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblRState = new System.Windows.Forms.Label();
            this.lblRPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRClear = new System.Windows.Forms.Button();
            this.rdbbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbbtnFemale = new System.Windows.Forms.RadioButton();
            this.txtbxRname = new System.Windows.Forms.TextBox();
            this.txtbxREmailID = new System.Windows.Forms.TextBox();
            this.txtbxRContact = new System.Windows.Forms.TextBox();
            this.txtbxRState = new System.Windows.Forms.TextBox();
            this.txtbxRPassword = new System.Windows.Forms.TextBox();
            this.cmbbxRType = new System.Windows.Forms.ComboBox();
            this.errorRegister = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRType.Location = new System.Drawing.Point(240, 28);
            this.lblRType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(88, 37);
            this.lblRType.TabIndex = 0;
            this.lblRType.Text = "Type:";
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRName.Location = new System.Drawing.Point(232, 117);
            this.lblRName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(98, 37);
            this.lblRName.TabIndex = 1;
            this.lblRName.Text = "Name:";
            // 
            // lblREmailID
            // 
            this.lblREmailID.AutoSize = true;
            this.lblREmailID.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREmailID.Location = new System.Drawing.Point(237, 215);
            this.lblREmailID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblREmailID.Name = "lblREmailID";
            this.lblREmailID.Size = new System.Drawing.Size(130, 37);
            this.lblREmailID.TabIndex = 2;
            this.lblREmailID.Text = "E-MailID:";
            // 
            // lblRContact
            // 
            this.lblRContact.AutoSize = true;
            this.lblRContact.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRContact.Location = new System.Drawing.Point(222, 311);
            this.lblRContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRContact.Name = "lblRContact";
            this.lblRContact.Size = new System.Drawing.Size(125, 37);
            this.lblRContact.TabIndex = 3;
            this.lblRContact.Text = "Contact:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(222, 405);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(118, 37);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // lblRState
            // 
            this.lblRState.AutoSize = true;
            this.lblRState.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRState.Location = new System.Drawing.Point(222, 485);
            this.lblRState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRState.Name = "lblRState";
            this.lblRState.Size = new System.Drawing.Size(92, 37);
            this.lblRState.TabIndex = 5;
            this.lblRState.Text = "State:";
            // 
            // lblRPassword
            // 
            this.lblRPassword.AutoSize = true;
            this.lblRPassword.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPassword.Location = new System.Drawing.Point(222, 568);
            this.lblRPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRPassword.Name = "lblRPassword";
            this.lblRPassword.Size = new System.Drawing.Size(156, 37);
            this.lblRPassword.TabIndex = 6;
            this.lblRPassword.Text = "PassWord:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(244, 723);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(168, 65);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRClear
            // 
            this.btnRClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRClear.Location = new System.Drawing.Point(549, 723);
            this.btnRClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRClear.Name = "btnRClear";
            this.btnRClear.Size = new System.Drawing.Size(168, 65);
            this.btnRClear.TabIndex = 8;
            this.btnRClear.Text = "Clear";
            this.btnRClear.UseVisualStyleBackColor = true;
            // 
            // rdbbtnMale
            // 
            this.rdbbtnMale.AutoSize = true;
            this.rdbbtnMale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbbtnMale.Location = new System.Drawing.Point(434, 402);
            this.rdbbtnMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbbtnMale.Name = "rdbbtnMale";
            this.rdbbtnMale.Size = new System.Drawing.Size(81, 33);
            this.rdbbtnMale.TabIndex = 9;
            this.rdbbtnMale.TabStop = true;
            this.rdbbtnMale.Text = "Male";
            this.rdbbtnMale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbbtnFemale
            // 
            this.rdbbtnFemale.AutoSize = true;
            this.rdbbtnFemale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbbtnFemale.Location = new System.Drawing.Point(603, 405);
            this.rdbbtnFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbbtnFemale.Name = "rdbbtnFemale";
            this.rdbbtnFemale.Size = new System.Drawing.Size(106, 33);
            this.rdbbtnFemale.TabIndex = 10;
            this.rdbbtnFemale.TabStop = true;
            this.rdbbtnFemale.Text = "Female";
            this.rdbbtnFemale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtbxRname
            // 
            this.txtbxRname.Location = new System.Drawing.Point(434, 122);
            this.txtbxRname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxRname.Name = "txtbxRname";
            this.txtbxRname.Size = new System.Drawing.Size(314, 26);
            this.txtbxRname.TabIndex = 12;
            this.txtbxRname.TextChanged += new System.EventHandler(this.txtbxRname_TextChanged);
            // 
            // txtbxREmailID
            // 
            this.txtbxREmailID.Location = new System.Drawing.Point(434, 215);
            this.txtbxREmailID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxREmailID.Name = "txtbxREmailID";
            this.txtbxREmailID.Size = new System.Drawing.Size(314, 26);
            this.txtbxREmailID.TabIndex = 13;
            this.txtbxREmailID.TextChanged += new System.EventHandler(this.txtbxREmailID_TextChanged);
            // 
            // txtbxRContact
            // 
            this.txtbxRContact.Location = new System.Drawing.Point(434, 311);
            this.txtbxRContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxRContact.Name = "txtbxRContact";
            this.txtbxRContact.Size = new System.Drawing.Size(314, 26);
            this.txtbxRContact.TabIndex = 14;
            this.txtbxRContact.TextChanged += new System.EventHandler(this.txtbxRContact_TextChanged);
            // 
            // txtbxRState
            // 
            this.txtbxRState.Location = new System.Drawing.Point(434, 485);
            this.txtbxRState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxRState.Name = "txtbxRState";
            this.txtbxRState.Size = new System.Drawing.Size(314, 26);
            this.txtbxRState.TabIndex = 15;
            this.txtbxRState.TextChanged += new System.EventHandler(this.txtbxRState_TextChanged);
            // 
            // txtbxRPassword
            // 
            this.txtbxRPassword.Location = new System.Drawing.Point(434, 568);
            this.txtbxRPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxRPassword.Name = "txtbxRPassword";
            this.txtbxRPassword.Size = new System.Drawing.Size(314, 26);
            this.txtbxRPassword.TabIndex = 16;
            this.txtbxRPassword.TextChanged += new System.EventHandler(this.txtbxRPassword_TextChanged);
            // 
            // cmbbxRType
            // 
            this.cmbbxRType.FormattingEnabled = true;
            this.cmbbxRType.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.cmbbxRType.Location = new System.Drawing.Point(434, 56);
            this.cmbbxRType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxRType.Name = "cmbbxRType";
            this.cmbbxRType.Size = new System.Drawing.Size(314, 28);
            this.cmbbxRType.TabIndex = 17;
            this.cmbbxRType.SelectedIndexChanged += new System.EventHandler(this.cmbbxRType_SelectedIndexChanged);
            // 
            // errorRegister
            // 
            this.errorRegister.ContainerControl = this;
            // 
            // frmRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 846);
            this.Controls.Add(this.cmbbxRType);
            this.Controls.Add(this.txtbxRPassword);
            this.Controls.Add(this.txtbxRState);
            this.Controls.Add(this.txtbxRContact);
            this.Controls.Add(this.txtbxREmailID);
            this.Controls.Add(this.txtbxRname);
            this.Controls.Add(this.rdbbtnFemale);
            this.Controls.Add(this.rdbbtnMale);
            this.Controls.Add(this.btnRClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRPassword);
            this.Controls.Add(this.lblRState);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblRContact);
            this.Controls.Add(this.lblREmailID);
            this.Controls.Add(this.lblRName);
            this.Controls.Add(this.lblRType);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegisterUser";
            this.Text = "RegisterUser";
            this.Load += new System.EventHandler(this.frmRegisterUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.Label lblRName;
        private System.Windows.Forms.Label lblREmailID;
        private System.Windows.Forms.Label lblRContact;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblRState;
        private System.Windows.Forms.Label lblRPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRClear;
        private System.Windows.Forms.RadioButton rdbbtnMale;
        private System.Windows.Forms.RadioButton rdbbtnFemale;
        private System.Windows.Forms.TextBox txtbxRname;
        private System.Windows.Forms.TextBox txtbxREmailID;
        private System.Windows.Forms.TextBox txtbxRContact;
        private System.Windows.Forms.TextBox txtbxRState;
        private System.Windows.Forms.TextBox txtbxRPassword;
        private System.Windows.Forms.ComboBox cmbbxRType;
        private System.Windows.Forms.ErrorProvider errorRegister;
    }
}