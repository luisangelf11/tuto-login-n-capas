using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Domain.Models
{
    public class DLoginUser
    {
        LoginUser login = new LoginUser();

        public bool Login(string user, string pass)
        {
            return login.Login(user, pass);
        }
    }
}
