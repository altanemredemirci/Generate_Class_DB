using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;
        int Sonuc = 0;
        public DataAccessLayer()
        {
            connect = new SqlConnection("Server=.;Database=NORTHWND;uid=sa;pwd=9117");
        }
        public void BaglantiAyarla()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
            else
                connect.Close();
        }

        internal SqlDataReader GetCategories()
        {
            command = new SqlCommand("Select * from Categories", connect);
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader GetProducts(int id)
        {
            command = new SqlCommand("SP_GetProducts", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader GetSuppliers(int id)
        {
            command = new SqlCommand("SP_GetSuppliers", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader GetOrderDetails(int id)
        {
            command = new SqlCommand("SP_GetOrderDetails", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader GetOrders(int id)
        {
            command = new SqlCommand("SP_GetOrders", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader GetCustomer(string id)
        {
            command = new SqlCommand("SP_GetCustomer", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        internal SqlDataReader GetEmployee(int id)
        {
            command = new SqlCommand("SP_GetEmployee", connect);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
    }
}
