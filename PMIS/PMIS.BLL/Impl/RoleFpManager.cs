using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMIS.Model;

namespace PMIS.BLL.Impl
{
    public class RoleFpManager : GenericManagerBase<PM_RoleFp>, IRoleFpManager
    {
        public IList<PM_RoleFp> GetRoleList(int pm_UserId)
        {
            String hSql =
                " from PM_RoleFp rf where rf.pm_TRFpUid=:pm_UserId)";
            Dictionary<String, Object> di = new Dictionary<string, object>();
            di.Add("pm_UserId", pm_UserId);
            return this.CurrentRepository.GetListByHqlParam(hSql, di);
        }

    }
}
