namespace Northwind_Generate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.treeView_server = new System.Windows.Forms.TreeView();
            this.cnt_menu_Generate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchbox_class = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.cnt_menu_Generate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1527, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 69);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // treeView_server
            // 
            this.treeView_server.ContextMenuStrip = this.cnt_menu_Generate;
            this.treeView_server.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView_server.ImageIndex = 0;
            this.treeView_server.ImageList = this.ımageList1;
            this.treeView_server.Location = new System.Drawing.Point(0, 98);
            this.treeView_server.Name = "treeView_server";
            this.treeView_server.SelectedImageIndex = 0;
            this.treeView_server.Size = new System.Drawing.Size(240, 643);
            this.treeView_server.TabIndex = 1;
            this.treeView_server.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_server_AfterSelect);
            // 
            // cnt_menu_Generate
            // 
            this.cnt_menu_Generate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateClassToolStripMenuItem});
            this.cnt_menu_Generate.Name = "cnt_menu_Generate";
            this.cnt_menu_Generate.Size = new System.Drawing.Size(149, 26);
            this.cnt_menu_Generate.Click += new System.EventHandler(this.cnt_menu_Generate_Click);
            // 
            // generateClassToolStripMenuItem
            // 
            this.generateClassToolStripMenuItem.Name = "generateClassToolStripMenuItem";
            this.generateClassToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.generateClassToolStripMenuItem.Text = "GenerateClass";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "SQLServerProject_16x.png");
            this.ımageList1.Images.SetKeyName(1, "Database_16x.png");
            this.ımageList1.Images.SetKeyName(2, "Table_16x.png");
            this.ımageList1.Images.SetKeyName(3, "Column_16x.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchbox_class);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(240, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1287, 643);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // rchbox_class
            // 
            this.rchbox_class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchbox_class.Location = new System.Drawing.Point(3, 16);
            this.rchbox_class.Name = "rchbox_class";
            this.rchbox_class.Size = new System.Drawing.Size(1281, 624);
            this.rchbox_class.TabIndex = 0;
            this.rchbox_class.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.treeView_server);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.cnt_menu_Generate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TreeView treeView_server;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchbox_class;
        private System.Windows.Forms.ContextMenuStrip cnt_menu_Generate;
        private System.Windows.Forms.ToolStripMenuItem generateClassToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

