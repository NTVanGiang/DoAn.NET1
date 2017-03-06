using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_User
    {
        DAL_User dal_user = new DAL_User();
        public DataTable Get()
        {
            return dal_user.Get();
        }
        public bool Insert_User(Users pUser)
        {
            return dal_user.Insert_User(pUser);
        }
        public bool Update_User(Users pUser)
        {
            return dal_user.Update_User(pUser);
        }
        public bool Delete_User(string IdUser)
        {
            return dal_user.Delete_User(IdUser);
        }
        public bool CheckLogin(string user, string pass)
        {
            return dal_user.CheckLogin(user, pass);
        }

    }
}
