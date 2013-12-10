using System.Collections.Generic;
using PMIS.Model;

namespace PMIS.BLL
{
   public interface IRoleManager:IGenericManager<PM_Role>,IPageBLL<PM_Role>
   {
       IList<PM_Role> GetRoleList(int pm_UserId);
   }
}
