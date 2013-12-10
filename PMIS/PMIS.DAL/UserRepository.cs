using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMIS.IDAL;

using PMIS.Model;

namespace PMIS.DAL
{
    public class UserRepository : RepositoryBase<PM_User>, IUserRepository
    {
        public PM_User GetUser(string strName)
        {
          return  this.HibernateTemplate.LoadAll<PM_User>().FirstOrDefault(r => r.pm_UserName.Equals(strName));
        }

        public PM_User GetUser(string strName, string strPassword)
        {
           return this.HibernateTemplate.LoadAll<PM_User>().FirstOrDefault(r => r.pm_UserName.Equals(strName)&&r.pm_UserPassword.Equals(strPassword));
        }


        public IList<PM_User> GetUserList(string strName)
        {
            return this.HibernateTemplate.LoadAll<PM_User>().Where(r => r.pm_UserName.Equals(strName)).ToList();
        }
    }
}
