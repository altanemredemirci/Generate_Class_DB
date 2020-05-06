using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in BLL.GetCategories())
            {
                cmb_category.Items.Add(item).ToString();
            }
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cat = (Category)cmb_category.SelectedItem;
            List<Product> lst = BLL.GetProducts(cat.CategoryID);
            for (int i = 0; i < lst.Count; i++)
            {
                dtgrdw_products.Rows.Add();    
                dtgrdw_products.Rows[i].Cells[0].Value = lst[i].ProductID;
                dtgrdw_products.Rows[i].Cells[1].Value = lst[i].ProductName;
                dtgrdw_products.Rows[i].Cells[2].Value = lst[i].SupplierID;
                dtgrdw_products.Rows[i].Cells[3].Value = lst[i].CategoryID;
                dtgrdw_products.Rows[i].Cells[4].Value = lst[i].UnitPrice;
                dtgrdw_products.Rows[i].Cells[5].Value = lst[i].UnitsInStock;
                dtgrdw_products.Rows[i].Cells[6].Value = lst[i].UnitsOnOrder;

            }
        }

        private void dtgrdw_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

               int id = Convert.ToInt32(dtgrdw_products.Rows[e.RowIndex].Cells[0].Value);
                
                List<Supplier> lstsupplier = BLL.GetSuppliers(id);
                for (int i = 0; i < lstsupplier.Count; i++)
                {
                    dtgrdw_suppliers.Rows.Add();
                    dtgrdw_suppliers.Rows[i].Cells[0].Value = lstsupplier[i].SupplierID;
                    dtgrdw_suppliers.Rows[i].Cells[1].Value = lstsupplier[i].CompanyName;
                    dtgrdw_suppliers.Rows[i].Cells[2].Value = lstsupplier[i].ContactName;
                    dtgrdw_suppliers.Rows[i].Cells[3].Value = lstsupplier[i].ContactTitle;
                    dtgrdw_suppliers.Rows[i].Cells[4].Value = lstsupplier[i].Address;
                    dtgrdw_suppliers.Rows[i].Cells[5].Value = lstsupplier[i].City;
                    dtgrdw_suppliers.Rows[i].Cells[6].Value = lstsupplier[i].PostalCode;
                    dtgrdw_suppliers.Rows[i].Cells[7].Value = lstsupplier[i].Country;
                    dtgrdw_suppliers.Rows[i].Cells[8].Value = lstsupplier[i].Phone;

                }

                List<OrderDetails> lstorder = BLL.GetOrderDetails(id);
                for (int i = 0; i < lstorder.Count; i++)
                {
                    dtgrdw_orderdetails.Rows.Add();
                    dtgrdw_orderdetails.Rows[i].Cells[0].Value = lstorder[i].OrderID;
                    dtgrdw_orderdetails.Rows[i].Cells[1].Value = lstorder[i].ProductID;
                    dtgrdw_orderdetails.Rows[i].Cells[2].Value = lstorder[i].UnitPrice;
                    dtgrdw_orderdetails.Rows[i].Cells[3].Value = lstorder[i].Quantity;
                    dtgrdw_orderdetails.Rows[i].Cells[4].Value = lstorder[i].Discount;
                }

            }
        }

        private void dtgrdw_orderdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtgrdw_orderdetails.Rows[e.RowIndex].Cells[0].Value);
            frm_Order frm = new frm_Order(id);
            frm.Show();
            this.Hide();
        }
    }
}
