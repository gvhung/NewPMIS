using System.Collections.Generic;
using PMIS.Model;

namespace PMIS.BLL
{
    public interface IResourceManager:IGenericManager<PM_Resource>,IPageBLL<PM_Resource>
    {
        IList<PM_Resource> GetResource(IList<PM_Role> listRole);
        IList<PM_Resource> GetResourceTrddList(IList<PM_Resource> list);
    }
}
