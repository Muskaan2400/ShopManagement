using System;

namespace ShopManagement
{
    partial class frmLogin
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
            this.lblTypeLogin = new System.Windows.Forms.Label();
            this.lblEmailLogin = new System.Windows.Forms.Label();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.cmbbxTypeLogin = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeLogin
            // 
            this.lblTypeLogin.AutoSize = true;
            this.lblTypeLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeLogin.Location = new System.Drawing.Point(119, 112);
            this.lblTypeLogin.Name = "lblTypeLogin";
            this.lblTypeLogin.Size = new System.Drawing.Size(80, 33);
            this.lblTypeLogin.TabIndex = 0;
            this.lblTypeLogin.Text = "Type";
            // 
            // lblEmailLogin
            // 
            this.lblEmailLogin.AutoSize = true;
            this.lblEmailLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailLogin.Location = new System.Drawing.Point(119, 210);
            this.lblEmailLogin.Name = "lblEmailLogin";
            this.lblEmailLogin.Size = new System.Drawing.Size(92, 33);
            this.lblEmailLogin.TabIndex = 2;
            this.lblEmailLogin.Text = "Email";
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogin.Location = new System.Drawing.Point(119, 309);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(147, 33);
            this.lblPasswordLogin.TabIndex = 3;
            this.lblPasswordLogin.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(97, 530);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 47);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Location = new System.Drawing.Point(306, 216);
            this.txtEmailLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(198, 26);
            this.txtEmailLogin.TabIndex = 7;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(306, 316);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(198, 26);
            this.txtPasswordLogin.TabIndex = 8;
            // 
            // cmbbxTypeLogin
            // 
            this.cmbbxTypeLogin.FormattingEnabled = true;
            this.cmbbxTypeLogin.Location = new System.Drawing.Point(306, 113);
            this.cmbbxTypeLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxTypeLogin.Name = "cmbbxTypeLogin";
            this.cmbbxTypeLogin.Size = new System.Drawing.Size(198, 28);
            this.cmbbxTypeLogin.TabIndex = 9;
            this.cmbbxTypeLogin.SelectedIndexChanged += new System.EventHandler(this.cmbbxTypeLogin_SelectedIndexChanged);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(401, 520);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(144, 47);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 682);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.cmbbxTypeLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.lblEmailLogin);
            this.Controls.Add(this.lblTypeLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeLogin;
        private System.Windows.Forms.Label lblEmailLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.ComboBox cmbbxTypeLogin;
        private readonly EventHandler lblUserNameLogin_Click;
        private System.Windows.Forms.Button btnclear;
    }
}