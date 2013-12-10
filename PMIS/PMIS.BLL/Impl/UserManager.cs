using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using PMIS.Comm;
using PMIS.IDAL;
using PMIS.Model;

namespace PMIS.BLL.Impl
{
    public class UserManager : GenericManagerBase<PM_User>, IUserManager
    {
        public PM_User GetUser(string strName)
        {
            return ((IUserRepository) this.CurrentRepository).GetUser(strName);
        }

        public PM_User GetUser(string strName, string strPassword)
        {
            return ((IUserRepository)this.CurrentRepository).GetUser(strName,strPassword);
        }



        public Pager<PM_User> FinPager(int page, int rows, string sort, string Order)
        {
            throw new NotImplementedException();
        }

        public Pager<PM_User> FinPager(Dictionary<string, object> dictionary, int page, int rows, string sort, string Order)
        {
            throw new NotImplementedException();
        }

        public Pager<PM_User> FinPager(Dictionary<string, object> dictionary, int page, int rows)
        {
            StringBuilder hsql = new StringBuilder(" from PM_User re ");
            if (dictionary != null)
            {
                hsql.Append(" where ");
                foreach (var key in dictionary.Keys)
                {
                    hsql.Append(" re." + key + "=:" + key + "");
                }
                return this.CurrentRepository.FindPagerByHqlParam(hsql.ToString(), dictionary, page, rows);
            }
            else
            {
                return this.CurrentRepository.FindAllByPager(page, rows);
            }
        }


        public IList<PM_User> GetUserList(string strName)
        {
            return ((IUserRepository)this.CurrentRepository).GetUserList(strName);
        }
    }
}
