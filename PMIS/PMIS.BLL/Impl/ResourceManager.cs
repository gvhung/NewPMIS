using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMIS.Comm;
using PMIS.Model;

namespace PMIS.BLL.Impl
{
    public class ResourceManager : GenericManagerBase<PM_Resource>, IResourceManager
    {
        public IList<PM_Resource> GetResource(IList<PM_Role> listRole)
        {
            if (listRole != null && listRole.Count > 0)
            {
                String rid = "";
                foreach (var pmRole in listRole)
                {

                    rid = ",'" + pmRole.pm_TRId + "'";
                }
                rid = rid.Remove(0, 1);
                String hSql = "select re.pm_TReid,re.pm_TRURL,re.pm_TRIMG,re.pm_TRFid,re.pm_TRName,re.pm_TRpysx from PM_Resource re where re.pm_TReid in(select r.pm_TReid from PM_ReFp r where r.pm_TRId in(" + rid + "))";
               IList<PM_Resource> list=new List<PM_Resource>();
                var listS = this.CurrentRepository.FindBySqlList(hSql);
                foreach (var objectse in listS)
                {
                    PM_Resource re = new PM_Resource();
                    re.pm_TReid = Convert.ToInt16(objectse[0]);
                    var bean = list.FirstOrDefault(r => r.pm_TReid.Equals(re.pm_TReid));
                    if (bean == null)
                    {
                        re.pm_TRURL = Convert.ToString(objectse[1]);
                        re.pm_TRIMG = Convert.ToString(objectse[2]);
                        re.pm_TRFid = Convert.ToInt16(objectse[3]);
                        re.pm_TRName = Convert.ToString(objectse[4]);
                        re.pm_TRpysx = Convert.ToString(objectse[5]);
                        list.Add(re);
                    }
                }
                var listTop = list.Where(r => r.pm_TRFid.Equals(0));
                if (listTop != null)
                {
                    foreach (var pmResource in listTop)
                    {
                        pmResource.children = list.Where(r => r.pm_TRFid.Equals(pmResource.pm_TReid)).ToList();
                    }
                }
                return listTop.ToList();
              
                 ;
            }
            else
            {
                return null;
            }
        }

        public Pager<PM_Resource> FinPager(Dictionary<string, object> pDictionary, int page, int rows)
        {
            StringBuilder hsql = new StringBuilder(" from PM_Resource re ");
            if (pDictionary != null)
            {
                hsql.Append(" where ");
                foreach (var key in pDictionary.Keys)
                {
                    hsql.Append(" re." + key + "=:" + key + "");
                }
                return this.CurrentRepository.FindPagerByHqlParam(hsql.ToString(), pDictionary, page, rows);
            }
            else
            {
                //this.CurrentRepository
                return this.CurrentRepository.FindAllByPager(page, rows);
            }
        }

        public Pager<PM_Resource> FinPager(int page, int rows, string sort, string Order)
        {
            throw new NotImplementedException();
        }

        public Pager<PM_Resource> FinPager(Dictionary<string, object> dictionary, int page, int rows, string sort, string Order)
        {
            throw new NotImplementedException();
        }

        public override PM_Resource Get(object id)
        {
            PM_Resource resource = base.Get(id);
            if (resource != null && resource.pm_TRFid != 0)
            {
                resource.FResource = base.Get(resource.pm_TRFid);
            }
            return resource;
        }

        
        public IList<PM_Resource> GetResourceTrddList(IList<PM_Resource> list)
        {
            var listTop = list.Where(r => r.pm_TRFid.Equals(0));
            if (listTop != null)
            {
                foreach (var pmResource in listTop)
                {
                    pmResource.children = list.Where(r => r.pm_TRFid.Equals(pmResource.pm_TReid)).ToList();
                }
            }
            return listTop.ToList();
        }
    }
}
