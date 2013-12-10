using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMIS.Comm;
using PMIS.Model;

namespace PMIS.BLL.Impl
{
    public class ProductManager : GenericManagerBase<PM_Product>, IProductManager
    {

        public Pager<PM_Product> FinPager(int page, int rows, string sort, string Order)
        {
            throw new NotImplementedException();
        }

        public Pager<PM_Product> FinPager(Dictionary<string, object> dictionary, int page, int rows, string sort, string Order)
        {
            throw new NotImplementedException();
        }

        public Pager<PM_Product> FinPager(Dictionary<string, object> dictionary, int page, int rows)
        {
            StringBuilder hsql = new StringBuilder(" from PM_Product p ");
            if (dictionary != null)
            {
                hsql.Append(" where ");
                foreach (var key in dictionary.Keys)
                {
                    hsql.Append(" p." + key + "=:" + key + "");
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
