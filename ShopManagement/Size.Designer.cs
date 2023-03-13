namespace ShopManagement
{
    partial class frmSize
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
            this.lblSType = new System.Windows.Forms.Label();
            this.cmbbxSType = new System.Windows.Forms.ComboBox();
            this.btnSSave = new System.Windows.Forms.Button();
            this.btnSClear = new System.Windows.Forms.Button();
            this.lblSProductName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblRealPrice = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.cmbbxProductName = new System.Windows.Forms.ComboBox();
            this.txtbxSize = new System.Windows.Forms.TextBox();
            this.txtbxMRP = new System.Windows.Forms.TextBox();
            this.txtbxRealPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSType
            // 
            this.lblSType.AutoSize = true;
            this.lblSType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSType.Location = new System.Drawing.Point(124, 69);
            this.lblSType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSType.Name = "lblSType";
            this.lblSType.Size = new System.Drawing.Size(88, 37);
            this.lblSType.TabIndex = 0;
            this.lblSType.Text = "Type:";
            // 
            // cmbbxSType
            // 
            this.cmbbxSType.FormattingEnabled = true;
            this.cmbbxSType.Location = new System.Drawing.Point(326, 78);
            this.cmbbxSType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxSType.Name = "cmbbxSType";
            this.cmbbxSType.Size = new System.Drawing.Size(301, 28);
            this.cmbbxSType.TabIndex = 1;
            this.cmbbxSType.SelectedIndexChanged += new System.EventHandler(this.cmbbxSType_SelectedIndexChanged);
            // 
            // btnSSave
            // 
            this.btnSSave.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSave.Location = new System.Drawing.Point(116, 594);
            this.btnSSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSSave.Name = "btnSSave";
            this.btnSSave.Size = new System.Drawing.Size(156, 62);
            this.btnSSave.TabIndex = 2;
            this.btnSSave.Text = "Save";
            this.btnSSave.UseVisualStyleBackColor = true;
            this.btnSSave.Click += new System.EventHandler(this.btnSSave_Click);
            // 
            // btnSClear
            // 
            this.btnSClear.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSClear.Location = new System.Drawing.Point(454, 594);
            this.btnSClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSClear.Name = "btnSClear";
            this.btnSClear.Size = new System.Drawing.Size(156, 62);
            this.btnSClear.TabIndex = 3;
            this.btnSClear.Text = "Clear";
            this.btnSClear.UseVisualStyleBackColor = true;
            // 
            // lblSProductName
            // 
            this.lblSProductName.AutoSize = true;
            this.lblSProductName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSProductName.Location = new System.Drawing.Point(93, 178);
            this.lblSProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSProductName.Name = "lblSProductName";
            this.lblSProductName.Size = new System.Drawing.Size(205, 37);
            this.lblSProductName.TabIndex = 4;
            this.lblSProductName.Text = "Product Name:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(124, 280);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(79, 37);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size:";
            // 
            // lblRealPrice
            // 
            this.lblRealPrice.AutoSize = true;
            this.lblRealPrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealPrice.Location = new System.Drawing.Point(124, 454);
            this.lblRealPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealPrice.Name = "lblRealPrice";
            this.lblRealPrice.Size = new System.Drawing.Size(154, 37);
            this.lblRealPrice.TabIndex = 6;
            this.lblRealPrice.Text = "Real Price:";
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.Location = new System.Drawing.Point(124, 363);
            this.lblMRP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(85, 37);
            this.lblMRP.TabIndex = 7;
            this.lblMRP.Text = "MRP:";
            // 
            // cmbbxProductName
            // 
            this.cmbbxProductName.FormattingEnabled = true;
            this.cmbbxProductName.Location = new System.Drawing.Point(326, 178);
            this.cmbbxProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxProductName.Name = "cmbbxProductName";
            this.cmbbxProductName.Size = new System.Drawing.Size(301, 28);
            this.cmbbxProductName.TabIndex = 8;
            // 
            // txtbxSize
            // 
            this.txtbxSize.Location = new System.Drawing.Point(326, 280);
            this.txtbxSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSize.Name = "txtbxSize";
            this.txtbxSize.Size = new System.Drawing.Size(301, 26);
            this.txtbxSize.TabIndex = 9;
            // 
            // txtbxMRP
            // 
            this.txtbxMRP.Location = new System.Drawing.Point(326, 363);
            this.txtbxMRP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxMRP.Name = "txtbxMRP";
            this.txtbxMRP.Size = new System.Drawing.Size(301, 26);
            this.txtbxMRP.TabIndex = 10;
            // 
            // txtbxRealPrice
            // 
            this.txtbxRealPrice.Location = new System.Drawing.Point(326, 454);
            this.txtbxRealPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxRealPrice.Name = "txtbxRealPrice";
            this.txtbxRealPrice.Size = new System.Drawing.Size(301, 26);
            this.txtbxRealPrice.TabIndex = 11;
            // 
            // frmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 674);
            this.Controls.Add(this.txtbxRealPrice);
            this.Controls.Add(this.txtbxMRP);
            this.Controls.Add(this.txtbxSize);
            this.Controls.Add(this.cmbbxProductName);
            this.Controls.Add(this.lblMRP);
            this.Controls.Add(this.lblRealPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblSProductName);
            this.Controls.Add(this.btnSClear);
            this.Controls.Add(this.btnSSave);
            this.Controls.Add(this.cmbbxSType);
            this.Controls.Add(this.lblSType);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSize";
            this.Text = "Size";
            this.Load += new System.EventHandler(this.frmSize_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSType;
        private System.Windows.Forms.ComboBox cmbbxSType;
        private System.Windows.Forms.Button btnSSave;
        private System.Windows.Forms.Button btnSClear;
        private System.Windows.Forms.Label lblSProductName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblRealPrice;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.ComboBox cmbbxProductName;
        private System.Windows.Forms.TextBox txtbxSize;
        private System.Windows.Forms.TextBox txtbxMRP;
        private System.Windows.Forms.TextBox txtbxRealPrice;
    }
}