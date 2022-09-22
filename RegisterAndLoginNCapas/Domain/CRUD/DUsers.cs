using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Attributes;
using DataAccess.Entities;

namespace Domain.CRUD
{
    public class DUsers
    {
        Users users = new Users();

        public void CreateUser(AttributesUserBD obj)
        {
            users.CreateUser(obj);
        }
    }
}
