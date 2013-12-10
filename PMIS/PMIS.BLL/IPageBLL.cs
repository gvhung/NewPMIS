using System;
using System.Collections.Generic;
using PMIS.Comm;

namespace PMIS.BLL
{
    public interface IPageBLL<T>
    {
        Pager<T> FinPager(int page, int rows, String sort, String Order);
        Pager<T> FinPager(Dictionary<String, Object> dictionary, int page, int rows, String sort, String Order);
        Pager<T> FinPager(Dictionary<String, Object> dictionary, int page, int rows);
    }
}
