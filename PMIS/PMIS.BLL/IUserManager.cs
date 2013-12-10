using System;
using System.Collections.Generic;
using PMIS.Model;

namespace PMIS.BLL
{
    public interface IUserManager:IGenericManager<PM_User>,IPageBLL<PM_User>
    {
        PM_User GetUser(String strName);

        PM_User GetUser(String strName, String strPassword);

        IList<PM_User> GetUserList(string strName);
    }
}
