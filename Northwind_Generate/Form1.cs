using Microsoft.Build.Evaluation;
using Microsoft.CSharp;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind_Generate
{
    public partial class Form1 : Form
    {
        Server svr;
        public Form1()
        {

            InitializeComponent();
        }
        Project addProject = new Project(@"C:\Users\ALTAN EMRE\source\repos\Northwind\Northwind_Generate\Northwind_Generate.csproj");
        private void btn_connect_Click(object sender, EventArgs e)
        {
            //Login frm = new Login();
            //frm.Show();
            //treeView_server.Nodes.Clear();
            svr = new Server(".");
            svr.ConnectionContext.LoginSecure = true;

            TreeNode nds = new TreeNode(svr.ConnectionContext.ServerInstance);
            nds.ImageIndex = 0;
            treeView_server.Nodes.Add(nds);

            foreach (Database database in svr.Databases)
            {
                TreeNode node = new TreeNode(database.Name);
                node.Tag = database;
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
                treeView_server.Nodes.Add(node);
            }
        }
    
        private void treeView_server_AfterSelect(object sender, TreeViewEventArgs e)
        {

            e.Node.Nodes.Clear();

            if (e.Node.Tag is Database)
            {
                
                foreach (Table table in (e.Node.Tag as Database).Tables) 
                {
                    TreeNode node = new TreeNode(table.Name);
                    node.Tag = table;
                    node.SelectedImageIndex = 2;
                    node.ImageIndex = 2;
                    e.Node.Nodes.Add(node);
                }
            }

            if (e.Node.Tag is Table)
            {
                foreach (Column column in (e.Node.Tag as Table).Columns)
                {
                    TreeNode node = new TreeNode(column.Name);
                    node.Tag = column;
                    node.SelectedImageIndex = 3;
                    node.ImageIndex = 3;
                    e.Node.Nodes.Add(node);        
                }
            }
        }


        private void cnt_menu_Generate_Click(object sender, EventArgs e)
        {
            if(treeView_server.SelectedNode.Tag is Table)
            {
                Table tables = (Table)treeView_server.SelectedNode.Tag;
                Assembly asm = Assembly.GetExecutingAssembly();
                Type[] typs = asm.GetTypes();
                bool result = false;
                foreach (Type type in typs)
                {
                    if(type.IsClass && type.Name != tables.Name)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
                Dictionary<string, Type> props = new Dictionary<string, Type>(); 
                if (result == true)
                {
                    MyClassBuilder builder = new MyClassBuilder(tables.Name,  addProject);
                    foreach (Column column in tables.Columns)
                    {
                        props.Add(column.Name, GetClrType(column.DataType.Name));
                    }
                    builder.AddProperties(props);
                    builder.GenerateCSharpCode(tables.Name.Replace(" ",""));
                    IEnumerable<string> rows = File.ReadLines(string.Format(@"C:\Users\ALTAN EMRE\source\repos\Northwind\Northwind_Generate\" + tables.Name+".cs")); //IEnumrable=> memoryden veri okumayı sağlar.
                    rchbox_class.Text = String.Join(Environment.NewLine, rows); //Environment.NewLine => Yeni satır karakteri döndürür. \n 
                }
            }
        }


        public static Type GetClrType(string sqlType)
        {
            switch (sqlType)
            {
                case "bigint":
                    return typeof(long?);

                case "binary":
                case "image":
                case "timestamp":
                case "varbinary":
                    return typeof(byte[]);

                case "bit":
                    return typeof(bool?);

                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar":
                case "xml":
                    return typeof(string);

                case "datetime":
                case "smalldatetime":
                case "date":
                case "time":
                case "datetime2":
                    return typeof(DateTime?);

                case "decimal":
                case "money":
                case "smallmoney":
                    return typeof(decimal?);

                case "float":
                    return typeof(double?);

                case "int":
                    return typeof(int?);

                case "real":
                    return typeof(float?);

                case "uniqueidentifier":
                    return typeof(Guid?);

                case "smallint":
                    return typeof(short?);

                case "tinyint":
                    return typeof(byte?);

                case "variant":
                case "udt":
                    return typeof(object);

                case "structured":
                    return typeof(DataTable);

                case "datetimeoffset":
                    return typeof(DateTimeOffset?);

                default:
                    throw new ArgumentOutOfRangeException("sqlType");
            }
        }

    }

}



        
       

      




