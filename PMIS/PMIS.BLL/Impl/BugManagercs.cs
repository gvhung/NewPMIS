using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMIS.Comm;
using PMIS.Model;

namespace PMIS.BLL.Impl
{
    public class BugManagercs : GenericManagerBase<PM_BUG>, IBugManager
    {
        public Pager<PM_BUG> FinPager(int page, int rows, string sort, string Order)
        {
            throw new NotImplementedException();
        }

        public Pager<PM_BUG> FinPager(Dictionary<string, object> dictionary, int page, int rows, string sort, string Order)
        {
            throw new NotImplementedException();
        }

        public Pager<PM_BUG> FinPager(Dictionary<string, object> dictionary, int page, int rows)
        {
            throw new NotImplementedException();
        }
    }
}
