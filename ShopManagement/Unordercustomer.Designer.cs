namespace ShopManagement
{
    partial class frmUnorderCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.grdUnorderCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnorderCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "UnorderCustomerInfo";
            // 
            // grdUnorderCustomer
            // 
            this.grdUnorderCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnorderCustomer.Location = new System.Drawing.Point(12, 97);
            this.grdUnorderCustomer.Name = "grdUnorderCustomer";
            this.grdUnorderCustomer.RowHeadersWidth = 62;
            this.grdUnorderCustomer.RowTemplate.Height = 28;
            this.grdUnorderCustomer.Size = new System.Drawing.Size(766, 274);
            this.grdUnorderCustomer.TabIndex = 1;
            this.grdUnorderCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUnorderCustomer_CellContentClick);
            // 
            // frmUnorderCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdUnorderCustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmUnorderCustomer";
            this.Text = "Unordercustomer";
            this.Load += new System.EventHandler(this.frmUnorderCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnorderCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdUnorderCustomer;
    }
}