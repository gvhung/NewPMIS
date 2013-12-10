using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMIS.Comm;
using PMIS.Model;

namespace PMIS.BLL.Impl
{
    public class RoleManager : GenericManagerBase<PM_Role>, IRoleManager
   {
       public IList<PM_Role> GetRoleList(int pm_UserId)
       {
           IList<PM_Role> list=new List<PM_Role>();
           String hSql =
               "select r.pm_TRId,r.pm_TRNanme,r.pm_TRBz,r.pm_TRFid,r.pm_TRState,r.Version from PM_Role r where r.pm_TRId in(select rf.pm_TRFpRid from PM_RoleFp rf where rf.pm_TRFpUid=:pm_UserId)";
           Dictionary<String, Object> di = new Dictionary<string, object>();
           di.Add("pm_UserId", pm_UserId);
           var li = this.CurrentRepository.FindBySqlList(hSql, di);
           foreach (var objectse in li)
           {
               PM_Role ro=new PM_Role();
               ro.pm_TRId = Convert.ToInt16(objectse[0]);
               ro.pm_TRNanme = objectse[1].ToString();
               ro.pm_TRBz = objectse[2].ToString();
               ro.pm_TRFid = Convert.ToInt16(objectse[3]);
               ro.pm_TRState = objectse[4].ToString();
               ro.Version = Convert.ToInt16(objectse[5]);
               list.Add(ro);
           }
           return list;
       }

       public Pager<PM_Role> FinPager(int page, int rows, string sort, string Order)
       {
           throw new NotImplementedException();
       }

       public Pager<PM_Role> FinPager(Dictionary<string, object> dictionary, int page, int rows, string sort, string Order)
       {
           throw new NotImplementedException();
       }

       public Pager<PM_Role> FinPager(Dictionary<string, object> dictionary, int page, int rows)
       {
           StringBuilder hsql = new StringBuilder(" from PM_Role re ");
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
   }
}
