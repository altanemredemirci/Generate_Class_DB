namespace Northwind
{
    partial class Form1
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
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.dtgrdw_products = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsOnOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgrdw_orderdetails = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrdw_suppliers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdw_products)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdw_orderdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdw_suppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(19, 43);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_category.TabIndex = 0;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.cmb_category_SelectedIndexChanged);
            // 
            // dtgrdw_products
            // 
            this.dtgrdw_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdw_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.SupplierID,
            this.CategoryID,
            this.UnitPrice,
            this.UnitsInStock,
            this.UnitsOnOrder});
            this.dtgrdw_products.Location = new System.Drawing.Point(156, 43);
            this.dtgrdw_products.Name = "dtgrdw_products";
            this.dtgrdw_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdw_products.Size = new System.Drawing.Size(810, 263);
            this.dtgrdw_products.TabIndex = 1;
            this.dtgrdw_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdw_products_CellClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 200;
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "SupplierID";
            this.SupplierID.Name = "SupplierID";
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // UnitsInStock
            // 
            this.UnitsInStock.HeaderText = "UnitsInStock";
            this.UnitsInStock.Name = "UnitsInStock";
            // 
            // UnitsOnOrder
            // 
            this.UnitsOnOrder.HeaderText = "UnitsOnOrder";
            this.UnitsOnOrder.Name = "UnitsOnOrder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtgrdw_orderdetails);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtgrdw_suppliers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_category);
            this.groupBox1.Controls.Add(this.dtgrdw_products);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1737, 802);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1021, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ORDERS";
            // 
            // dtgrdw_orderdetails
            // 
            this.dtgrdw_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdw_orderdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderProductID,
            this.OrderUnitPrice,
            this.OrderQuantity,
            this.OrderDiscount});
            this.dtgrdw_orderdetails.Location = new System.Drawing.Point(1024, 43);
            this.dtgrdw_orderdetails.Name = "dtgrdw_orderdetails";
            this.dtgrdw_orderdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdw_orderdetails.Size = new System.Drawing.Size(560, 263);
            this.dtgrdw_orderdetails.TabIndex = 6;
            this.dtgrdw_orderdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdw_orderdetails_CellClick);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            // 
            // OrderProductID
            // 
            this.OrderProductID.HeaderText = "ProductID";
            this.OrderProductID.Name = "OrderProductID";
            // 
            // OrderUnitPrice
            // 
            this.OrderUnitPrice.HeaderText = "UnitPrice";
            this.OrderUnitPrice.Name = "OrderUnitPrice";
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.HeaderText = "Quantity";
            this.OrderQuantity.Name = "OrderQuantity";
            // 
            // OrderDiscount
            // 
            this.OrderDiscount.HeaderText = "Discount";
            this.OrderDiscount.Name = "OrderDiscount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(153, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SUPPLIERS";
            // 
            // dtgrdw_suppliers
            // 
            this.dtgrdw_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdw_suppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupID,
            this.SupplierCompanyName,
            this.SupplierContactName,
            this.SupplierContactTitle,
            this.SupplierAddress,
            this.SupplierCity,
            this.SupplierPostalCode,
            this.SupplierCountry,
            this.SupplierPhone});
            this.dtgrdw_suppliers.Location = new System.Drawing.Point(156, 353);
            this.dtgrdw_suppliers.Name = "dtgrdw_suppliers";
            this.dtgrdw_suppliers.Size = new System.Drawing.Size(937, 67);
            this.dtgrdw_suppliers.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CATEGORIES";
            // 
            // SupID
            // 
            this.SupID.HeaderText = "ID";
            this.SupID.Name = "SupID";
            this.SupID.Width = 50;
            // 
            // SupplierCompanyName
            // 
            this.SupplierCompanyName.HeaderText = "CompanyName";
            this.SupplierCompanyName.Name = "SupplierCompanyName";
            // 
            // SupplierContactName
            // 
            this.SupplierContactName.HeaderText = "ContactName";
            this.SupplierContactName.Name = "SupplierContactName";
            // 
            // SupplierContactTitle
            // 
            this.SupplierContactTitle.HeaderText = "ContactTitle";
            this.SupplierContactTitle.Name = "SupplierContactTitle";
            this.SupplierContactTitle.Width = 140;
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.HeaderText = "Address";
            this.SupplierAddress.Name = "SupplierAddress";
            // 
            // SupplierCity
            // 
            this.SupplierCity.HeaderText = "City";
            this.SupplierCity.Name = "SupplierCity";
            // 
            // SupplierPostalCode
            // 
            this.SupplierPostalCode.HeaderText = "PostalCode";
            this.SupplierPostalCode.Name = "SupplierPostalCode";
            // 
            // SupplierCountry
            // 
            this.SupplierCountry.HeaderText = "Country";
            this.SupplierCountry.Name = "SupplierCountry";
            // 
            // SupplierPhone
            // 
            this.SupplierPhone.HeaderText = "Phone";
            this.SupplierPhone.Name = "SupplierPhone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 825);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdw_products)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdw_orderdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdw_suppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.DataGridView dtgrdw_products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrdw_suppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsOnOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgrdw_orderdetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierPhone;
    }
}

