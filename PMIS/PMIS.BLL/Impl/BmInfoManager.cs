using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMIS.Comm;
using PMIS.Model;


namespace PMIS.BLL.Impl
{
    public class BmInfoManager : GenericManagerBase<Bm_Table>, IBmInfoManager
    {
        public object GetNextCode(string code)
        {
            throw new NotImplementedException();
        }

        public void GetAndGroupByBm()
        {
            IList<Bm_Table> list = this.GetBmTablesAll();
            UtilCodeInfo.rolestate = this.CoventBmInfo(list.Where(r => r.bm_lx.Equals("rolestate")).ToList());
            UtilCodeInfo.usRole = this.CoventBmInfo(list.Where(r => r.bm_lx.Equals("usRole")).ToList());
            UtilCodeInfo.usstate = this.CoventBmInfo(list.Where(r => r.bm_lx.Equals("usstate")).ToList());
            UtilCodeInfo.xtzylx = this.CoventBmInfo(list.Where(r => r.bm_lx.Equals("xtzylx")).ToList());
            UtilCodeInfo.xtzyzt = this.CoventBmInfo(list.Where(r => r.bm_lx.Equals("xtzyzt")).ToList());
        }

        private IList<BmInfo> CoventBmInfo(IList<Bm_Table> list)
        {
            IList<BmInfo> bmList=new List<BmInfo>();
            foreach (var bmInfo in list)
            {
                BmInfo bm=new BmInfo();
                bm.Code = bmInfo.bm_code;
                bm.Name = bmInfo.bm_mc;
                bmList.Add(bm);
            }
            return bmList;
        }

        public IList<Bm_Table> GetBmTablesAll()
        {
            return this.CurrentRepository.LoadAll().ToList();
        }
    }
}
