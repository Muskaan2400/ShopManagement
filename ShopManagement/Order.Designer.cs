namespace ShopManagement
{
    partial class frmOrder
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
            this.lblorderform = new System.Windows.Forms.Label();
            this.lblOType = new System.Windows.Forms.Label();
            this.lblOProduct = new System.Windows.Forms.Label();
            this.lblOPrice = new System.Windows.Forms.Label();
            this.GrdSizeShow = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOclear = new System.Windows.Forms.Button();
            this.btnAddtocart = new System.Windows.Forms.Button();
            this.btnRemovetocart = new System.Windows.Forms.Button();
            this.txtbxOPrice = new System.Windows.Forms.TextBox();
            this.cmbbxOtype = new System.Windows.Forms.ComboBox();
            this.cmbbxOProduct = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmailid = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnOrderConfirm = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOName = new System.Windows.Forms.Label();
            this.lblOEmailID = new System.Windows.Forms.Label();
            this.lblOPhone = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblOID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSizeShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblorderform
            // 
            this.lblorderform.AutoSize = true;
            this.lblorderform.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderform.Location = new System.Drawing.Point(459, 14);
            this.lblorderform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblorderform.Name = "lblorderform";
            this.lblorderform.Size = new System.Drawing.Size(153, 37);
            this.lblorderform.TabIndex = 0;
            this.lblorderform.Text = "OrderForm";
            // 
            // lblOType
            // 
            this.lblOType.AutoSize = true;
            this.lblOType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOType.Location = new System.Drawing.Point(64, 109);
            this.lblOType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOType.Name = "lblOType";
            this.lblOType.Size = new System.Drawing.Size(71, 33);
            this.lblOType.TabIndex = 1;
            this.lblOType.Text = "Type";
            // 
            // lblOProduct
            // 
            this.lblOProduct.AutoSize = true;
            this.lblOProduct.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOProduct.Location = new System.Drawing.Point(64, 183);
            this.lblOProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOProduct.Name = "lblOProduct";
            this.lblOProduct.Size = new System.Drawing.Size(106, 33);
            this.lblOProduct.TabIndex = 2;
            this.lblOProduct.Text = "Product";
            // 
            // lblOPrice
            // 
            this.lblOPrice.AutoSize = true;
            this.lblOPrice.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPrice.Location = new System.Drawing.Point(64, 557);
            this.lblOPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOPrice.Name = "lblOPrice";
            this.lblOPrice.Size = new System.Drawing.Size(73, 33);
            this.lblOPrice.TabIndex = 3;
            this.lblOPrice.Text = "Price";
            // 
            // GrdSizeShow
            // 
            this.GrdSizeShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSizeShow.Location = new System.Drawing.Point(56, 273);
            this.GrdSizeShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrdSizeShow.Name = "GrdSizeShow";
            this.GrdSizeShow.RowHeadersWidth = 62;
            this.GrdSizeShow.Size = new System.Drawing.Size(408, 231);
            this.GrdSizeShow.TabIndex = 4;
            this.GrdSizeShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdSizeShow_CellClick);
            this.GrdSizeShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdSizeShow_CellClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(56, 658);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 62);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnOclear
            // 
            this.btnOclear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOclear.Location = new System.Drawing.Point(333, 658);
            this.btnOclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOclear.Name = "btnOclear";
            this.btnOclear.Size = new System.Drawing.Size(130, 62);
            this.btnOclear.TabIndex = 6;
            this.btnOclear.Text = "Clear";
            this.btnOclear.UseVisualStyleBackColor = true;
            // 
            // btnAddtocart
            // 
            this.btnAddtocart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtocart.Location = new System.Drawing.Point(532, 223);
            this.btnAddtocart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddtocart.Name = "btnAddtocart";
            this.btnAddtocart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddtocart.Size = new System.Drawing.Size(159, 60);
            this.btnAddtocart.TabIndex = 7;
            this.btnAddtocart.Text = "Add to Cart";
            this.btnAddtocart.UseVisualStyleBackColor = true;
            this.btnAddtocart.Click += new System.EventHandler(this.btnAddtocart_Click);
            // 
            // btnRemovetocart
            // 
            this.btnRemovetocart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovetocart.Location = new System.Drawing.Point(532, 458);
            this.btnRemovetocart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemovetocart.Name = "btnRemovetocart";
            this.btnRemovetocart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemovetocart.Size = new System.Drawing.Size(180, 88);
            this.btnRemovetocart.TabIndex = 8;
            this.btnRemovetocart.Text = "Remove to Cart";
            this.btnRemovetocart.UseVisualStyleBackColor = true;
            this.btnRemovetocart.Click += new System.EventHandler(this.btnRemovetocart_Click);
            // 
            // txtbxOPrice
            // 
            this.txtbxOPrice.Location = new System.Drawing.Point(165, 565);
            this.txtbxOPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxOPrice.Name = "txtbxOPrice";
            this.txtbxOPrice.Size = new System.Drawing.Size(214, 26);
            this.txtbxOPrice.TabIndex = 9;
            // 
            // cmbbxOtype
            // 
            this.cmbbxOtype.FormattingEnabled = true;
            this.cmbbxOtype.Location = new System.Drawing.Point(200, 112);
            this.cmbbxOtype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxOtype.Name = "cmbbxOtype";
            this.cmbbxOtype.Size = new System.Drawing.Size(217, 28);
            this.cmbbxOtype.TabIndex = 10;
            this.cmbbxOtype.SelectedIndexChanged += new System.EventHandler(this.cmbbxOtype_SelectedIndexChanged);
            // 
            // cmbbxOProduct
            // 
            this.cmbbxOProduct.FormattingEnabled = true;
            this.cmbbxOProduct.Location = new System.Drawing.Point(200, 191);
            this.cmbbxOProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxOProduct.Name = "cmbbxOProduct";
            this.cmbbxOProduct.Size = new System.Drawing.Size(217, 28);
            this.cmbbxOProduct.TabIndex = 11;
            this.cmbbxOProduct.SelectedIndexChanged += new System.EventHandler(this.cmbbxOProduct_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(792, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblEmailid
            // 
            this.lblEmailid.AutoSize = true;
            this.lblEmailid.Location = new System.Drawing.Point(792, 173);
            this.lblEmailid.Name = "lblEmailid";
            this.lblEmailid.Size = new System.Drawing.Size(65, 20);
            this.lblEmailid.TabIndex = 13;
            this.lblEmailid.Text = "EmailID";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(792, 223);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(796, 548);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(61, 46);
            this.btnTotal.TabIndex = 18;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnOrderConfirm
            // 
            this.btnOrderConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderConfirm.Location = new System.Drawing.Point(865, 649);
            this.btnOrderConfirm.Name = "btnOrderConfirm";
            this.btnOrderConfirm.Size = new System.Drawing.Size(138, 58);
            this.btnOrderConfirm.TabIndex = 19;
            this.btnOrderConfirm.Text = "OrderConfirm";
            this.btnOrderConfirm.UseVisualStyleBackColor = true;
            this.btnOrderConfirm.Click += new System.EventHandler(this.btnOrderConfirm_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(946, 568);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 20;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Product,
            this.Size,
            this.Price,
            this.SizeID});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(743, 282);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(540, 202);
            this.listView.TabIndex = 21;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 79;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 115;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 94;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 105;
            // 
            // SizeID
            // 
            this.SizeID.Text = "SizeID";
            // 
            // lblOName
            // 
            this.lblOName.AutoSize = true;
            this.lblOName.Location = new System.Drawing.Point(929, 122);
            this.lblOName.Name = "lblOName";
            this.lblOName.Size = new System.Drawing.Size(51, 20);
            this.lblOName.TabIndex = 22;
            this.lblOName.Text = "Name";
            // 
            // lblOEmailID
            // 
            this.lblOEmailID.AutoSize = true;
            this.lblOEmailID.Location = new System.Drawing.Point(926, 173);
            this.lblOEmailID.Name = "lblOEmailID";
            this.lblOEmailID.Size = new System.Drawing.Size(65, 20);
            this.lblOEmailID.TabIndex = 23;
            this.lblOEmailID.Text = "EmailID";
            // 
            // lblOPhone
            // 
            this.lblOPhone.AutoSize = true;
            this.lblOPhone.Location = new System.Drawing.Point(926, 223);
            this.lblOPhone.Name = "lblOPhone";
            this.lblOPhone.Size = new System.Drawing.Size(54, 20);
            this.lblOPhone.TabIndex = 24;
            this.lblOPhone.Text = "phone";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(792, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID";
            // 
            // lblOID
            // 
            this.lblOID.AutoSize = true;
            this.lblOID.Location = new System.Drawing.Point(929, 84);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(26, 20);
            this.lblOID.TabIndex = 26;
            this.lblOID.Text = "ID";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 757);
            this.Controls.Add(this.lblOID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblOPhone);
            this.Controls.Add(this.lblOEmailID);
            this.Controls.Add(this.lblOName);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnOrderConfirm);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmailid);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbbxOProduct);
            this.Controls.Add(this.cmbbxOtype);
            this.Controls.Add(this.txtbxOPrice);
            this.Controls.Add(this.btnRemovetocart);
            this.Controls.Add(this.btnAddtocart);
            this.Controls.Add(this.btnOclear);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.GrdSizeShow);
            this.Controls.Add(this.lblOPrice);
            this.Controls.Add(this.lblOProduct);
            this.Controls.Add(this.lblOType);
            this.Controls.Add(this.lblorderform);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdSizeShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblorderform;
        private System.Windows.Forms.Label lblOType;
        private System.Windows.Forms.Label lblOProduct;
        private System.Windows.Forms.Label lblOPrice;
        private System.Windows.Forms.DataGridView GrdSizeShow;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOclear;
        private System.Windows.Forms.Button btnAddtocart;
        private System.Windows.Forms.Button btnRemovetocart;
        private System.Windows.Forms.TextBox txtbxOPrice;
        private System.Windows.Forms.ComboBox cmbbxOtype;
        private System.Windows.Forms.ComboBox cmbbxOProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmailid;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnOrderConfirm;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label lblOName;
        private System.Windows.Forms.Label lblOEmailID;
        private System.Windows.Forms.Label lblOPhone;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblOID;
        private System.Windows.Forms.ColumnHeader SizeID;
    }
}