using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using  System.Data.SqlClient;
using System.Threading.Tasks;
using Customerdetail.Model;

namespace Customerdetail.Repository
{
    public class CustomerRepository
    {
        public bool Exitcode(CustomerModel customerModel)
        {
         
            string connectionString = @"Server=PC-301-28\SQLEXPRESS;DataBase=Customerdetail;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM Customers WHERE Name='" + customerModel.Code + "'";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            if (dataTable.Rows.Count > 0)
            {
                return  true;
            
            }
            sqlConnection.Close();
            return false;
        }
        public bool Exitcontact(CustomerModel customerModel)
        {

            string connectionString = @"Server=PC-301-28\SQLEXPRESS;DataBase=Customerdetail;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM Customers WHERE Name='" + customerModel.Contact + "'";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return true;

            }
            sqlConnection.Close();
            return false;
        }

        public bool Addcustomer(CustomerModel customerModel)
        {
            string connectionString = @"Server=PC-301-28\SQLEXPRESS;DataBase=Customerdetail;Integrated Security=true";
            SqlConnection sqlconnection = new SqlConnection(connectionString);

            string CommandString = @"INSERT INTO Customers(Code,Name, Address, Contact) VALUES ('" + customerModel.Code + "','" + customerModel.Name + "','" + customerModel.Address + "','" + customerModel.Contact + "')";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlconnection);
            

            sqlconnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                return true;

            }

            sqlconnection.Close();
            return false;
        }
    }
}
