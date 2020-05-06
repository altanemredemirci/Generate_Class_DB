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
    public partial class frm_Order : Form
    {
        int ID;
        BusinessLogicLayer BLL;
        public frm_Order(int id)
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer();
            ID = id;
        }

        private void frm_Order_Load(object sender, EventArgs e)
        {
            List<Order> lstorder = BLL.GetOrders(ID);
            for (int i = 0; i < lstorder.Count; i++)
            {
                dtgrwd_orders.Rows.Add();
                dtgrwd_orders.Rows[i].Cells[0].Value = lstorder[i].OrderID;
                dtgrwd_orders.Rows[i].Cells[1].Value = lstorder[i].CustomerID;
                dtgrwd_orders.Rows[i].Cells[2].Value = lstorder[i].EmployeeID;
                dtgrwd_orders.Rows[i].Cells[3].Value = lstorder[i].OrderDate;
                dtgrwd_orders.Rows[i].Cells[4].Value = lstorder[i].RequiredDate;
                dtgrwd_orders.Rows[i].Cells[5].Value = lstorder[i].ShippedDate;
                dtgrwd_orders.Rows[i].Cells[6].Value = lstorder[i].ShipVia;
                dtgrwd_orders.Rows[i].Cells[7].Value = lstorder[i].Freight;
                dtgrwd_orders.Rows[i].Cells[8].Value = lstorder[i].ShipName;
                dtgrwd_orders.Rows[i].Cells[9].Value = lstorder[i].ShipAddress;
                dtgrwd_orders.Rows[i].Cells[10].Value = lstorder[i].ShipCity;
                dtgrwd_orders.Rows[i].Cells[11].Value = lstorder[i].ShipRegion;
                dtgrwd_orders.Rows[i].Cells[12].Value = lstorder[i].ShipPostalCode;
                dtgrwd_orders.Rows[i].Cells[13].Value = lstorder[i].ShipCountry;  
            }

        }

        private void dtgrwd_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           string id = (dtgrwd_orders.Rows[e.RowIndex].Cells[1].Value).ToString();

            List<Customer> lstcustomer = BLL.GetCustomer(id);
            for (int i = 0; i < lstcustomer.Count; i++)
            {
                dtgrwd_customer.Rows.Add();
                dtgrwd_customer.Rows[i].Cells[0].Value = lstcustomer[i].CustomerID;
                dtgrwd_customer.Rows[i].Cells[1].Value = lstcustomer[i].CompanyName;
                dtgrwd_customer.Rows[i].Cells[2].Value = lstcustomer[i].ContactName;
                dtgrwd_customer.Rows[i].Cells[3].Value = lstcustomer[i].ContactTitle;
                dtgrwd_customer.Rows[i].Cells[4].Value = lstcustomer[i].Address; ;
                dtgrwd_customer.Rows[i].Cells[5].Value = lstcustomer[i].City;
                dtgrwd_customer.Rows[i].Cells[6].Value = lstcustomer[i].Region;
                dtgrwd_customer.Rows[i].Cells[7].Value = lstcustomer[i].PostalCode;
                dtgrwd_customer.Rows[i].Cells[8].Value = lstcustomer[i].Country;
                dtgrwd_customer.Rows[i].Cells[9].Value = lstcustomer[i].Phone;
                dtgrwd_customer.Rows[i].Cells[10].Value = lstcustomer[i].Fax;
            }

            int ID = Convert.ToInt32 (dtgrwd_orders.Rows[e.RowIndex].Cells[2].Value);

            List<Employee> lstemployee= BLL.GetEmployee(ID);
            for (int i = 0; i < lstemployee.Count; i++)
            {
                dtgrwd_employee.Rows.Add();
                dtgrwd_employee.Rows[i].Cells[0].Value =  lstemployee[i].EmployeeID;
                dtgrwd_employee.Rows[i].Cells[1].Value =  lstemployee[i].LastName;
                dtgrwd_employee.Rows[i].Cells[2].Value =  lstemployee[i].FirstName;
                dtgrwd_employee.Rows[i].Cells[3].Value =  lstemployee[i].Title;
                dtgrwd_employee.Rows[i].Cells[4].Value =  lstemployee[i].BirthDate; ;
                dtgrwd_employee.Rows[i].Cells[5].Value =  lstemployee[i].HireDate;
                dtgrwd_employee.Rows[i].Cells[6].Value =  lstemployee[i].Address;
                dtgrwd_employee.Rows[i].Cells[7].Value =  lstemployee[i].City;
                dtgrwd_employee.Rows[i].Cells[8].Value =  lstemployee[i].Region;
                dtgrwd_employee.Rows[i].Cells[9].Value =  lstemployee[i].PostalCode;
                dtgrwd_employee.Rows[i].Cells[10].Value = lstemployee[i].Country;
                dtgrwd_employee.Rows[i].Cells[11].Value = lstemployee[i].HomePhone;
            }
        }
    }
}
