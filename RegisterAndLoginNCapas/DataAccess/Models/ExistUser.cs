using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;

namespace DataAccess.Models
{
    public class ExistUser
    {
        ConnectionDB c = new ConnectionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public bool ValidateUser(string user)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "SELECT * FROM Users WHERE Username = @user";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@user", user);
            dr = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            //cmd.Connection = c.CloseConnection();
            if (dr.HasRows)
            {
                cmd.Connection = c.CloseConnection();
                return true;
            }
            else
            {
                cmd.Connection = c.CloseConnection();
                return false;
            }
        }
    }
}
