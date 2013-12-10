using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMIS.Comm;

namespace PMIS.BLL.Impl
{
    public class GenericManagerBase<T>:IGenericManager<T> where T:class 
    {
        public IDAL.IRepostitory<T> CurrentRepository { get; set; }

        public virtual T Get(object id)
        {
            return this.CurrentRepository.Get(id);
        }

        public virtual T Load(object id)
        {
            return this.Load(id);
        }

        public virtual object Save(T entity)
        {
            return this.CurrentRepository.Save(entity);
        }

        public virtual void Update(T entity)
        {
            this.CurrentRepository.Update(entity);
        }

        public virtual void SaveOrUpdate(T entity)
        {
            this.CurrentRepository.SaveOrUpdate(entity);
        }

        public virtual void Delete(object id)
        {
            this.CurrentRepository.Delete(id);
        }

        public virtual void Delete(IList<object> idList)
        {
            this.CurrentRepository.Delete(idList);
        }

        public virtual IList<T> LoadAll()
        {
            return this.CurrentRepository.LoadAll().ToList();
        }


        public Pager<T> FindPager(int page, int rows)
        {
            return this.CurrentRepository.FindAllByPager(page, rows);
        }
    }
}
