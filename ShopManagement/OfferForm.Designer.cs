namespace ShopManagement
{
    partial class frmOfferForm
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
            this.lblOfferForm = new System.Windows.Forms.Label();
            this.lblOfferInfo = new System.Windows.Forms.Label();
            this.lblOGPrice = new System.Windows.Forms.Label();
            this.lblDiscPercent = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.lblOGPrices = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblNewPriceRS = new System.Windows.Forms.Label();
            this.txtbxDiscPercent = new System.Windows.Forms.TextBox();
            this.txtbxNewPrice = new System.Windows.Forms.TextBox();
            this.btnUpdatedPrice = new System.Windows.Forms.Button();
            this.btnCalcNewPrice = new System.Windows.Forms.Button();
            this.lblOGProduct = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOfferForm
            // 
            this.lblOfferForm.AutoSize = true;
            this.lblOfferForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferForm.Location = new System.Drawing.Point(294, 18);
            this.lblOfferForm.Name = "lblOfferForm";
            this.lblOfferForm.Size = new System.Drawing.Size(208, 32);
            this.lblOfferForm.TabIndex = 0;
            this.lblOfferForm.Text = "OFFER FORM";
            // 
            // lblOfferInfo
            // 
            this.lblOfferInfo.AutoSize = true;
            this.lblOfferInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferInfo.Location = new System.Drawing.Point(33, 64);
            this.lblOfferInfo.Name = "lblOfferInfo";
            this.lblOfferInfo.Size = new System.Drawing.Size(287, 29);
            this.lblOfferInfo.TabIndex = 1;
            this.lblOfferInfo.Text = "OFFER INFORMATION";
            // 
            // lblOGPrice
            // 
            this.lblOGPrice.AutoSize = true;
            this.lblOGPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOGPrice.Location = new System.Drawing.Point(63, 112);
            this.lblOGPrice.Name = "lblOGPrice";
            this.lblOGPrice.Size = new System.Drawing.Size(166, 25);
            this.lblOGPrice.TabIndex = 2;
            this.lblOGPrice.Text = "Orignal Price Of";
            // 
            // lblDiscPercent
            // 
            this.lblDiscPercent.AutoSize = true;
            this.lblDiscPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscPercent.Location = new System.Drawing.Point(63, 166);
            this.lblDiscPercent.Name = "lblDiscPercent";
            this.lblDiscPercent.Size = new System.Drawing.Size(236, 25);
            this.lblDiscPercent.TabIndex = 3;
            this.lblDiscPercent.Text = "Discount In Percentage";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPrice.Location = new System.Drawing.Point(63, 218);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(109, 25);
            this.lblNewPrice.TabIndex = 4;
            this.lblNewPrice.Text = "New Price";
            // 
            // lblOGPrices
            // 
            this.lblOGPrices.AutoSize = true;
            this.lblOGPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOGPrices.Location = new System.Drawing.Point(504, 107);
            this.lblOGPrices.Name = "lblOGPrices";
            this.lblOGPrices.Size = new System.Drawing.Size(90, 29);
            this.lblOGPrices.TabIndex = 5;
            this.lblOGPrices.Text = "PRICE";
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS.Location = new System.Drawing.Point(671, 108);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(65, 29);
            this.lblRS.TabIndex = 6;
            this.lblRS.Text = "RS/-";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(671, 166);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(31, 25);
            this.lblPercentage.TabIndex = 7;
            this.lblPercentage.Text = "%";
            // 
            // lblNewPriceRS
            // 
            this.lblNewPriceRS.AutoSize = true;
            this.lblNewPriceRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPriceRS.Location = new System.Drawing.Point(671, 216);
            this.lblNewPriceRS.Name = "lblNewPriceRS";
            this.lblNewPriceRS.Size = new System.Drawing.Size(56, 25);
            this.lblNewPriceRS.TabIndex = 8;
            this.lblNewPriceRS.Text = "RS/-";
            // 
            // txtbxDiscPercent
            // 
            this.txtbxDiscPercent.Location = new System.Drawing.Point(453, 165);
            this.txtbxDiscPercent.Name = "txtbxDiscPercent";
            this.txtbxDiscPercent.Size = new System.Drawing.Size(155, 26);
            this.txtbxDiscPercent.TabIndex = 9;
            // 
            // txtbxNewPrice
            // 
            this.txtbxNewPrice.Location = new System.Drawing.Point(453, 217);
            this.txtbxNewPrice.Name = "txtbxNewPrice";
            this.txtbxNewPrice.Size = new System.Drawing.Size(155, 26);
            this.txtbxNewPrice.TabIndex = 10;
            // 
            // btnUpdatedPrice
            // 
            this.btnUpdatedPrice.Location = new System.Drawing.Point(96, 312);
            this.btnUpdatedPrice.Name = "btnUpdatedPrice";
            this.btnUpdatedPrice.Size = new System.Drawing.Size(162, 37);
            this.btnUpdatedPrice.TabIndex = 11;
            this.btnUpdatedPrice.Text = "UPDATED PRICE";
            this.btnUpdatedPrice.UseVisualStyleBackColor = true;
            this.btnUpdatedPrice.Click += new System.EventHandler(this.btnUpdatedPrice_Click);
            // 
            // btnCalcNewPrice
            // 
            this.btnCalcNewPrice.Location = new System.Drawing.Point(394, 312);
            this.btnCalcNewPrice.Name = "btnCalcNewPrice";
            this.btnCalcNewPrice.Size = new System.Drawing.Size(259, 37);
            this.btnCalcNewPrice.TabIndex = 12;
            this.btnCalcNewPrice.Text = "CALCULATED NEW PRICE";
            this.btnCalcNewPrice.UseVisualStyleBackColor = true;
            this.btnCalcNewPrice.Click += new System.EventHandler(this.btnCalcNewPrice_Click);
            // 
            // lblOGProduct
            // 
            this.lblOGProduct.AutoSize = true;
            this.lblOGProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOGProduct.Location = new System.Drawing.Point(246, 111);
            this.lblOGProduct.Name = "lblOGProduct";
            this.lblOGProduct.Size = new System.Drawing.Size(97, 25);
            this.lblOGProduct.TabIndex = 13;
            this.lblOGProduct.Text = "Products";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(505, 71);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(63, 20);
            this.lblOrderID.TabIndex = 15;
            this.lblOrderID.Text = "orderID";
            // 
            // frmOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblOGProduct);
            this.Controls.Add(this.btnCalcNewPrice);
            this.Controls.Add(this.btnUpdatedPrice);
            this.Controls.Add(this.txtbxNewPrice);
            this.Controls.Add(this.txtbxDiscPercent);
            this.Controls.Add(this.lblNewPriceRS);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.lblOGPrices);
            this.Controls.Add(this.lblNewPrice);
            this.Controls.Add(this.lblDiscPercent);
            this.Controls.Add(this.lblOGPrice);
            this.Controls.Add(this.lblOfferInfo);
            this.Controls.Add(this.lblOfferForm);
            this.Name = "frmOfferForm";
            this.Text = "OfferForm";
            this.Load += new System.EventHandler(this.frmOfferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOfferForm;
        private System.Windows.Forms.Label lblOfferInfo;
        private System.Windows.Forms.Label lblOGPrice;
        private System.Windows.Forms.Label lblDiscPercent;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblNewPriceRS;
        private System.Windows.Forms.TextBox txtbxDiscPercent;
        private System.Windows.Forms.TextBox txtbxNewPrice;
        private System.Windows.Forms.Button btnUpdatedPrice;
        private System.Windows.Forms.Button btnCalcNewPrice;
        public System.Windows.Forms.Label lblOGPrices;
        public System.Windows.Forms.Label lblOGProduct;
        private System.Windows.Forms.Label lblOrderID;
    }
}