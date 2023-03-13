namespace ShopManagement
{
    partial class frmUnorderProduct
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
            this.lblUnorderProductInformation = new System.Windows.Forms.Label();
            this.grdUnorderproduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnorderproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnorderProductInformation
            // 
            this.lblUnorderProductInformation.AutoSize = true;
            this.lblUnorderProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnorderProductInformation.Location = new System.Drawing.Point(110, 46);
            this.lblUnorderProductInformation.Name = "lblUnorderProductInformation";
            this.lblUnorderProductInformation.Size = new System.Drawing.Size(303, 29);
            this.lblUnorderProductInformation.TabIndex = 0;
            this.lblUnorderProductInformation.Text = "UnorderProductInformation";
            // 
            // grdUnorderproduct
            // 
            this.grdUnorderproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnorderproduct.Location = new System.Drawing.Point(31, 105);
            this.grdUnorderproduct.Name = "grdUnorderproduct";
            this.grdUnorderproduct.RowHeadersWidth = 62;
            this.grdUnorderproduct.RowTemplate.Height = 28;
            this.grdUnorderproduct.Size = new System.Drawing.Size(926, 298);
            this.grdUnorderproduct.TabIndex = 1;
            this.grdUnorderproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUnorderproduct_CellContentClick);
            // 
            // frmUnorderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 583);
            this.Controls.Add(this.grdUnorderproduct);
            this.Controls.Add(this.lblUnorderProductInformation);
            this.Name = "frmUnorderProduct";
            this.Text = "UnorderProduct";
            this.Load += new System.EventHandler(this.frmUnorderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnorderproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnorderProductInformation;
        private System.Windows.Forms.DataGridView grdUnorderproduct;
    }
}