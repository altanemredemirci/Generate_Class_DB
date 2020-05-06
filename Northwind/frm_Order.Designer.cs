namespace Northwind
{
    partial class frm_Order
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgrwd_employee = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrwd_customer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgrwd_orders = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderRequiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderShipVia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderShipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderShipCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderShipRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderShipPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderShipCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrwd_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrwd_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrwd_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgrwd_employee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgrwd_customer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtgrwd_orders);
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1717, 724);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "EMPLOYEE";
            // 
            // dtgrwd_employee
            // 
            this.dtgrwd_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrwd_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.LastName,
            this.FirstName,
            this.Title,
            this.BirthDate,
            this.HireDate,
            this.Address,
            this.City,
            this.Region,
            this.PostalCode,
            this.Country,
            this.HomePhone});
            this.dtgrwd_employee.Location = new System.Drawing.Point(37, 187);
            this.dtgrwd_employee.Name = "dtgrwd_employee";
            this.dtgrwd_employee.Size = new System.Drawing.Size(1473, 73);
            this.dtgrwd_employee.TabIndex = 11;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 120;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Width = 150;
            // 
            // HireDate
            // 
            this.HireDate.HeaderText = "HireDate";
            this.HireDate.Name = "HireDate";
            this.HireDate.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 200;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Region
            // 
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            // 
            // PostalCode
            // 
            this.PostalCode.HeaderText = "PostalCode";
            this.PostalCode.Name = "PostalCode";
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // HomePhone
            // 
            this.HomePhone.HeaderText = "HomePhone";
            this.HomePhone.Name = "HomePhone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "CUSTOMER";
            // 
            // dtgrwd_customer
            // 
            this.dtgrwd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrwd_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerCompanyName,
            this.CustomerContactName,
            this.CustomerContactTitle,
            this.CustomerAddress,
            this.CustomerCity,
            this.CustomerRegion,
            this.CustomerPostalCode,
            this.CustomerCountry,
            this.CustomerPhone,
            this.CustomerFax});
            this.dtgrwd_customer.Location = new System.Drawing.Point(35, 342);
            this.dtgrwd_customer.Name = "dtgrwd_customer";
            this.dtgrwd_customer.Size = new System.Drawing.Size(1176, 69);
            this.dtgrwd_customer.TabIndex = 9;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            // 
            // CustomerCompanyName
            // 
            this.CustomerCompanyName.HeaderText = "CompanyName";
            this.CustomerCompanyName.Name = "CustomerCompanyName";
            // 
            // CustomerContactName
            // 
            this.CustomerContactName.HeaderText = "ContactName";
            this.CustomerContactName.Name = "CustomerContactName";
            this.CustomerContactName.Width = 120;
            // 
            // CustomerContactTitle
            // 
            this.CustomerContactTitle.HeaderText = "ContactTitle";
            this.CustomerContactTitle.Name = "CustomerContactTitle";
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.HeaderText = "Address";
            this.CustomerAddress.Name = "CustomerAddress";
            // 
            // CustomerCity
            // 
            this.CustomerCity.HeaderText = "City";
            this.CustomerCity.Name = "CustomerCity";
            // 
            // CustomerRegion
            // 
            this.CustomerRegion.HeaderText = "Region";
            this.CustomerRegion.Name = "CustomerRegion";
            // 
            // CustomerPostalCode
            // 
            this.CustomerPostalCode.HeaderText = "PostalCode";
            this.CustomerPostalCode.Name = "CustomerPostalCode";
            // 
            // CustomerCountry
            // 
            this.CustomerCountry.HeaderText = "Country";
            this.CustomerCountry.Name = "CustomerCountry";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.HeaderText = "Phone";
            this.CustomerPhone.Name = "CustomerPhone";
            // 
            // CustomerFax
            // 
            this.CustomerFax.HeaderText = "Fax";
            this.CustomerFax.Name = "CustomerFax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ORDER";
            // 
            // dtgrwd_orders
            // 
            this.dtgrwd_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrwd_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.OrderCustomerID,
            this.OrderEmployeeID,
            this.OrderDate,
            this.OrderRequiredDate,
            this.OrderShippedDate,
            this.OrderShipVia,
            this.OrderFreight,
            this.OrderShipName,
            this.OrderShipAddress,
            this.OrderShipCity,
            this.OrderShipRegion,
            this.OrderShipPostalCode,
            this.OrderShipCountry});
            this.dtgrwd_orders.Location = new System.Drawing.Point(37, 46);
            this.dtgrwd_orders.Name = "dtgrwd_orders";
            this.dtgrwd_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrwd_orders.Size = new System.Drawing.Size(1486, 67);
            this.dtgrwd_orders.TabIndex = 0;
            this.dtgrwd_orders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrwd_orders_CellClick);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            // 
            // OrderCustomerID
            // 
            this.OrderCustomerID.HeaderText = "CustomerID";
            this.OrderCustomerID.Name = "OrderCustomerID";
            // 
            // OrderEmployeeID
            // 
            this.OrderEmployeeID.HeaderText = "EmployeeID";
            this.OrderEmployeeID.Name = "OrderEmployeeID";
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 120;
            // 
            // OrderRequiredDate
            // 
            this.OrderRequiredDate.HeaderText = "RequiredDate";
            this.OrderRequiredDate.Name = "OrderRequiredDate";
            this.OrderRequiredDate.Width = 120;
            // 
            // OrderShippedDate
            // 
            this.OrderShippedDate.HeaderText = "ShippedDate";
            this.OrderShippedDate.Name = "OrderShippedDate";
            // 
            // OrderShipVia
            // 
            this.OrderShipVia.HeaderText = "ShipVia";
            this.OrderShipVia.Name = "OrderShipVia";
            // 
            // OrderFreight
            // 
            this.OrderFreight.HeaderText = "Freight";
            this.OrderFreight.Name = "OrderFreight";
            // 
            // OrderShipName
            // 
            this.OrderShipName.HeaderText = "ShipName";
            this.OrderShipName.Name = "OrderShipName";
            // 
            // OrderShipAddress
            // 
            this.OrderShipAddress.HeaderText = "ShipAddress";
            this.OrderShipAddress.Name = "OrderShipAddress";
            // 
            // OrderShipCity
            // 
            this.OrderShipCity.HeaderText = "ShipCity";
            this.OrderShipCity.Name = "OrderShipCity";
            // 
            // OrderShipRegion
            // 
            this.OrderShipRegion.HeaderText = "ShipRegion";
            this.OrderShipRegion.Name = "OrderShipRegion";
            // 
            // OrderShipPostalCode
            // 
            this.OrderShipPostalCode.HeaderText = "ShipPostalCode";
            this.OrderShipPostalCode.Name = "OrderShipPostalCode";
            // 
            // OrderShipCountry
            // 
            this.OrderShipCountry.HeaderText = "ShipCountry";
            this.OrderShipCountry.Name = "OrderShipCountry";
            // 
            // frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 784);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frm_Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrwd_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrwd_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrwd_orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrwd_orders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrwd_employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrwd_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderRequiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderShipVia;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderShipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderShipCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderShipRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderShipPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderShipCountry;
    }
}