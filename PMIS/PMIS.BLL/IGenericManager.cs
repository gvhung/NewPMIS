using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMIS.Comm;

namespace PMIS.BLL
{
    public interface IGenericManager<T>
    {
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>实体</returns>
        T Get(object id);

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>实体</returns>
        T Load(object id);

        /// <summary>
        /// 插入实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>ID</returns>
        object Save(T entity);

        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity">实体</param>
        void Update(T entity);

        /// <summary>
        /// 修改或保存实体
        /// </summary>
        /// <param name="entity">实体</param>
        void SaveOrUpdate(T entity);

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="id">ID</param>
        void Delete(object id);

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="idList">ID集合</param>
        void Delete(IList<object> idList);

        #region
        /// <summary>
        /// 获取全部实体
        /// </summary>
        /// <returns></returns>
        IList<T> LoadAll();
        /// <summary>
        /// 无条件分页查询
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        Pager<T> FindPager(int page, int rows);
        #endregion
    }
}
