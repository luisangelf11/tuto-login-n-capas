using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;

namespace DataAccess.Models
{
    public class LoginUser
    {
        ConnectionDB c = new ConnectionDB();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool Login(string user, string pass)
        {
            cmd.Connection = c.OpenConnection();
            cmd.CommandText = "SELECT * FROM Users WHERE Username = @user AND Pass = @pass";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    AttributesUser.ID = dr.GetInt32(0);
                    AttributesUser.Name = dr.GetString(1);
                    AttributesUser.Lastname = dr.GetString(2);
                    AttributesUser.Username = dr.GetString(3);
                    AttributesUser.Pass = dr.GetString(4);
                }
                return true;
            }
            else return false;
        }
    }
}
