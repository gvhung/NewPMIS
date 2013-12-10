using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMIS.Model;

namespace PMIS.IDAL
{
    public interface IUserRepository:IRepostitory<PM_User>
    {
        PM_User GetUser(String strName);

        PM_User GetUser(String strName, String strPassword);

        IList<PM_User> GetUserList(string strName);
    }
}
