using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class BusinessLogicLayer
    {
        DataAccessLayer DAL;
        SqlDataReader reader;
        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        internal List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                reader = DAL.GetCategories();
                while (reader.Read())
                {
                    categories.Add(new Category()
                    {
                        CategoryID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        CategoryName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Description = reader.IsDBNull(2) ? string.Empty : reader.GetString(2)
                        //Picture = reader.IsDBNull(3) ? string.Empty : reader.GetBytes(3)
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {
                //LOG
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return categories;
        }
        internal List<Product> GetProducts(int id)
        {
            List<Product> products = new List<Product>();
            try
            {
                reader = DAL.GetProducts(id);
                while (reader.Read())
                {
                    products.Add(new Product()
                    {
                        ProductID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        ProductName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        SupplierID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                        CategoryID = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                        UnitPrice = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                        UnitsInStock = reader.IsDBNull(5) ? 0 : reader.GetInt16(5),
                        UnitsOnOrder = reader.IsDBNull(6) ? 0 : reader.GetInt16(6)

                    });     
                }
                reader.Close();
            }
            catch (Exception)
            {
                //LOG
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return products;
        }
        internal List<Supplier> GetSuppliers(int id)
        {
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                reader = DAL.GetSuppliers(id);
                while (reader.Read())
                {
                    suppliers.Add(new Supplier()
                    {
                        SupplierID   = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),                  
                        CompanyName  = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        ContactName  = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Address      = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        City         = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        PostalCode   = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        Country      = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Phone        = reader.IsDBNull(8) ? string.Empty : reader.GetString(8)
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {
                //LOG
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return suppliers;
        }
        internal List<OrderDetails> GetOrderDetails(int id)
        {
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            try
            {
                reader = DAL.GetOrderDetails(id);
                while (reader.Read())
                {
                    orderDetails.Add(new OrderDetails()
                    {
                        OrderID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        ProductID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                        UnitPrice = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                        Quantity = reader.IsDBNull(3) ? 0 : reader.GetInt16(3),
                        Discount = reader.IsDBNull(4) ? 0 : reader.GetFloat(4)
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {
                //LOG
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return orderDetails;
        }
        internal List<Order> GetOrders(int id)
        {
            List<Order> orders = new List<Order>();
            try
            {
                reader = DAL.GetOrders(id);
                while (reader.Read())
                {
                    orders.Add(new Order()
                    {
                        OrderID        = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        CustomerID     = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        EmployeeID     = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                        OrderDate      = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                        RequiredDate   = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                        ShippedDate    = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5),
                        ShipVia        = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                        Freight        = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7),
                        ShipName       = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        ShipAddress    = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                        ShipCity       = reader.IsDBNull(10) ? string.Empty : reader.GetString(10),
                        ShipRegion     = reader.IsDBNull(11) ? string.Empty : reader.GetString(11),
                        ShipPostalCode = reader.IsDBNull(12) ? string.Empty : reader.GetString(12),
                        ShipCountry    = reader.IsDBNull(13) ? string.Empty : reader.GetString(13)
                    }); 
                }
                reader.Close();
            }
            catch (Exception)
            {
                //LOG
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return orders;
        }
        internal List<Customer> GetCustomer(string id)
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                reader = DAL.GetCustomer(id);
                while (reader.Read())
                {
                    customers.Add(new Customer()
                    {
                        CustomerID = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                        CompanyName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        ContactName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        ContactTitle = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        Address = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        City = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Region = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        PostalCode = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Country = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        Phone = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                        Fax = reader.IsDBNull(10) ? string.Empty : reader.GetString(10)
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {
                //LOG
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return customers;
        }
        internal List<Employee> GetEmployee(int id)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                reader = DAL.GetEmployee(id);
                while (reader.Read())
                {
                    employees.Add(new Employee()
                    {
                        EmployeeID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        LastName  = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        FirstName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Title = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        BirthDate   = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                        HireDate    = reader.IsDBNull(5) ? DateTime.MinValue : reader.GetDateTime(5),
                        Address = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        City= reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Region  = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        PostalCode    = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                        Country = reader.IsDBNull(10) ? string.Empty : reader.GetString(10),
                        HomePhone = reader.IsDBNull(11) ? string.Empty : reader.GetString(11)
                    }); 
                }
                reader.Close();
            }
            catch (Exception)
            {
                //LOG
            }
            finally
            {
                DAL.BaglantiAyarla();
            }
            return employees;
        }
    }
}
