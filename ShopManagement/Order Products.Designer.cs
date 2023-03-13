namespace ShopManagement
{
    partial class frmOrderProducts
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
            this.lblOrderProductInfo = new System.Windows.Forms.Label();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.lblSearchByProduct = new System.Windows.Forms.Label();
            this.grdOrderProductShow = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtbxSearchByName = new System.Windows.Forms.TextBox();
            this.txtbxSearchByProduct = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderProductShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderProductInfo
            // 
            this.lblOrderProductInfo.AutoSize = true;
            this.lblOrderProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderProductInfo.Location = new System.Drawing.Point(363, 19);
            this.lblOrderProductInfo.Name = "lblOrderProductInfo";
            this.lblOrderProductInfo.Size = new System.Drawing.Size(333, 30);
            this.lblOrderProductInfo.TabIndex = 0;
            this.lblOrderProductInfo.Text = "Order Product Information";
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByName.Location = new System.Drawing.Point(266, 427);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(174, 25);
            this.lblSearchByName.TabIndex = 1;
            this.lblSearchByName.Text = "Search By Name";
            // 
            // lblSearchByProduct
            // 
            this.lblSearchByProduct.AutoSize = true;
            this.lblSearchByProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByProduct.Location = new System.Drawing.Point(266, 504);
            this.lblSearchByProduct.Name = "lblSearchByProduct";
            this.lblSearchByProduct.Size = new System.Drawing.Size(192, 25);
            this.lblSearchByProduct.TabIndex = 2;
            this.lblSearchByProduct.Text = "Search By Product";
            // 
            // grdOrderProductShow
            // 
            this.grdOrderProductShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrderProductShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Discount});
            this.grdOrderProductShow.Location = new System.Drawing.Point(55, 81);
            this.grdOrderProductShow.Name = "grdOrderProductShow";
            this.grdOrderProductShow.RowHeadersWidth = 62;
            this.grdOrderProductShow.RowTemplate.Height = 28;
            this.grdOrderProductShow.Size = new System.Drawing.Size(926, 314);
            this.grdOrderProductShow.TabIndex = 3;
            this.grdOrderProductShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderProductShow_CellContentClick_1);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.Width = 80;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 8;
            this.Discount.Name = "Discount";
            this.Discount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Discount.Text = "Discount";
            this.Discount.UseColumnTextForButtonValue = true;
            this.Discount.Width = 150;
            // 
            // txtbxSearchByName
            // 
            this.txtbxSearchByName.Location = new System.Drawing.Point(559, 427);
            this.txtbxSearchByName.Name = "txtbxSearchByName";
            this.txtbxSearchByName.Size = new System.Drawing.Size(310, 26);
            this.txtbxSearchByName.TabIndex = 4;
            // 
            // txtbxSearchByProduct
            // 
            this.txtbxSearchByProduct.Location = new System.Drawing.Point(559, 503);
            this.txtbxSearchByProduct.Name = "txtbxSearchByProduct";
            this.txtbxSearchByProduct.Size = new System.Drawing.Size(310, 26);
            this.txtbxSearchByProduct.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(471, 567);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 53);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(266, 567);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 42);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(638, 563);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 53);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmOrderProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 632);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbxSearchByProduct);
            this.Controls.Add(this.txtbxSearchByName);
            this.Controls.Add(this.grdOrderProductShow);
            this.Controls.Add(this.lblSearchByProduct);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.lblOrderProductInfo);
            this.Name = "frmOrderProducts";
            this.Text = "Order Products";
            this.Load += new System.EventHandler(this.frmOrderProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderProductShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderProductInfo;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.Label lblSearchByProduct;
        private System.Windows.Forms.DataGridView grdOrderProductShow;
        private System.Windows.Forms.TextBox txtbxSearchByName;
        private System.Windows.Forms.TextBox txtbxSearchByProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewButtonColumn Discount;
    }
}