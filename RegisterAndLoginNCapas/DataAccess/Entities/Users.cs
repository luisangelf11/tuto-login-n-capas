using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccess.Connection;
using Common.Attributes;

namespace DataAccess.Entities
{
    public class Users
    {
        ConnectionDB c = new ConnectionDB();
        SqlCommand cmd = new SqlCommand();

        public void CreateUser(AttributesUserBD obj)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_CreateUser";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Lastname", obj.Lastname);
                cmd.Parameters.AddWithValue("@Username", obj.Username);
                cmd.Parameters.AddWithValue("@Pass", obj.Password);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }
    }
}
