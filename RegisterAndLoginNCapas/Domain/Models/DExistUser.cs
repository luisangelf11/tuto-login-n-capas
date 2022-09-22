using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Domain.Models
{
    public class DExistUser
    {
        ExistUser exist = new ExistUser();
        public bool ValidateUser(string user)
        {
           return exist.ValidateUser(user);
        }
    }
}
