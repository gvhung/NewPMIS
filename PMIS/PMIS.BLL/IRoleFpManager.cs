using System.Collections.Generic;
using PMIS.Model;

namespace PMIS.BLL
{
    public interface IRoleFpManager:IGenericManager<PM_RoleFp>
    {
        IList<PM_RoleFp> GetRoleList(int pm_UserId);
    }
}
