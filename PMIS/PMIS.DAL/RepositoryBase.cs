using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using PMIS.Comm;
using PMIS.IDAL;
using Spring.Data.Support;
using Spring.Data.NHibernate.Generic.Support;


namespace PMIS.DAL
{
    public class RepositoryBase<T> : HibernateDaoSupport, IRepostitory<T> where T : class
    {

        public virtual T Get(object id)
        {
            return this.Session.Get<T>(id);
        }

        public virtual T Load(object id)
        {
            return this.Session.Load<T>(id);
        }

        public virtual object Save(T entity)
        {
            return this.HibernateTemplate.Save(entity);
        }

        public virtual void Update(T entity)
        {
            this.Session.Update(entity);
        }

        public virtual void SaveOrUpdate(T entity)
        {
            this.Session.SaveOrUpdate(entity);
        }

        public virtual void Delete(object id)
        {
            this.Session.Delete(id);
        }

        public virtual void Delete(IList<object> idList)
        {

            foreach (var o in idList)
            {
                this.Session.Delete(o);
            }

        }

        public virtual T GetByHql(String hql)
        {
            IList<T> list = this.Session.CreateQuery(hql).List<T>();
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public virtual T GetByHqlParam(string hql, Dictionary<string, object> pDictionary)
        {

            IQuery iQuery = this.Session.CreateQuery(hql);
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }
            IList<T> list = iQuery.List<T>();
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }

        }

        public virtual IList<T> GetListByhql(string hql)
        {

            return this.Session.CreateQuery(hql).List<T>();

        }

        public virtual IList<T> GetListByHqlParam(string hql, Dictionary<string, object> pDictionary)
        {

            IQuery iQuery = this.Session.CreateQuery(hql);
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }
            return iQuery.List<T>();

        }

        public virtual Pager<T> FindPagerByHql(string hql, int page, int rows)
        {

            IQuery iQuery = this.Session.CreateQuery(hql);
            Pager<T> pager = new Pager<T>();
            pager.rows = iQuery.SetFirstResult((page - 1)*rows).SetMaxResults(rows).List<T>();
            pager.total = this.Count(hql);
            return pager;

        }

        public virtual Pager<T> FindPagerByHqlParam(string hql, Dictionary<string, object> pDictionary, int page, int rows)
        {

            IQuery iQuery = this.Session.CreateQuery(hql);
            Pager<T> pager = new Pager<T>();
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }
            pager.rows = iQuery.SetFirstResult((page - 1)*rows).SetMaxResults(rows).List<T>();
            pager.total = this.Count(hql);
            return pager;

        }

        public virtual int Count(string hql)
        {
            return (int) this.Session.CreateQuery(hql).UniqueResult();
        }

        public virtual int Count(string hql, Dictionary<string, object> pDictionary)
        {

            IQuery iQuery = this.Session.CreateQuery(hql);
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }
            return (int) iQuery.UniqueResult();

        }

        public virtual int ExecuteHql(string hql)
        {

            IQuery iQuery = this.Session.CreateQuery(hql);
            return iQuery.ExecuteUpdate();

        }

        public virtual int ExecuteHql(string hql, Dictionary<string, object> pDictionary)
        {

            IQuery iQuery = this.Session.CreateQuery(hql);
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }
            return iQuery.ExecuteUpdate();

        }

        public virtual Pager<object[]> FindPagerBySql(string sql)
        {

            ISQLQuery iQuery = this.Session.CreateSQLQuery(sql);
            Pager<object[]> pager = new Pager<object[]>();
            pager.rows = iQuery.List<object[]>();
            pager.total = this.countBySql(sql);
            return pager;

        }

        public virtual Pager<object[]> FindPagerBySql(string sql, int page, int rows)
        {

            ISQLQuery iQuery = this.Session.CreateSQLQuery(sql);
            Pager<object[]> pager = new Pager<object[]>();

            pager.rows = iQuery.SetFirstResult((page - 1)*rows).SetMaxResults(rows).List<object[]>();
            pager.total = this.countBySql(sql);
            return pager;

        }

        public virtual Pager<object[]> FindPagerBySql(string sql, Dictionary<string, object> pDictionary)
        {

            ISQLQuery iQuery = this.Session.CreateSQLQuery(sql);
            Pager<object[]> pager = new Pager<object[]>();
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }
            pager.rows = iQuery.List<object[]>();
            pager.total = this.countBySql(sql);
            return pager;

        }

        public virtual Pager<object[]> FindPagerBySql(string sql, Dictionary<string, object> pDictionary, int page, int rows)
        {

            ISQLQuery iQuery = this.Session.CreateSQLQuery(sql);
            Pager<object[]> pager = new Pager<object[]>();
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }
            pager.rows = iQuery.SetFirstResult((page - 1)*rows).SetMaxResults(rows).List<object[]>();
            pager.total = this.countBySql(sql);
            return pager;

        }

        public virtual int executeSql(string sql)
        {

            ISQLQuery iQuery = this.Session.CreateSQLQuery(sql);
            return iQuery.ExecuteUpdate();

        }

        public virtual int executeSql(string sql, Dictionary<string, object> pDictionary)
        {

            ISQLQuery iQuery = this.Session.CreateSQLQuery(sql);
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }
            return iQuery.ExecuteUpdate();

        }

        public virtual int countBySql(string sql)
        {

            return (int) this.Session.CreateSQLQuery(sql).UniqueResult();

        }

        public virtual int countBySql(string sql, Dictionary<string, object> pDictionary)
        {

            ISQLQuery iQuery = this.Session.CreateSQLQuery(sql);
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }
            return (int) iQuery.UniqueResult();

        }

        public Pager<T> FindAllByPager(int page, int rows)
        {
            Pager<T> pager=new Pager<T>();
            pager.total = this.HibernateTemplate.LoadAll<T>().Count;
            pager.rows = this.HibernateTemplate.LoadAll<T>().Skip((page - 1) * rows).Take(rows).ToList();

            return pager;
        }


        public virtual IQueryable<T> LoadAll()
        {
            return this.Session.Query<T>();
        }


        public IList<object[]> FindBySqlList(string sql, Dictionary<string, object> pDictionary)
        {
            ISQLQuery iQuery = this.Session.CreateSQLQuery(sql);
            if (pDictionary != null)
            {
                foreach (var o in pDictionary.Keys)
                {
                    iQuery.SetParameter(o, pDictionary[o]);
                }
            }

            return iQuery.List<object[]>();
        }

        public IList<object[]> FindBySqlList(string sql)
        {
            ISQLQuery iQuery = this.Session.CreateSQLQuery(sql);
            return iQuery.List<object[]>();
        }
    }
}
