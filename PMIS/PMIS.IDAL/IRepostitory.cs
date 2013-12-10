using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMIS.Comm;

namespace PMIS.IDAL
{
	public interface IRepostitory<T>
	{
		#region

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

        /// <summary>
        /// 获取全部实体
        /// </summary>
        /// <returns></returns>
	    IQueryable<T> LoadAll();

        #endregion
		#region
		/// <summary>
		/// 
		/// </summary>
		/// <param name="hql"></param>
		/// <returns></returns>
		T GetByHql(String hql);

	    /// <summary>
	    /// 
	    /// </summary>
	    /// <param name="hql"></param>
	    /// <param name="pDictionary"></param>
	    /// <returns></returns>
		T GetByHqlParam(String hql, Dictionary<String, Object> pDictionary);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hql"></param>
		/// <returns></returns>
		IList<T> GetListByhql(String hql);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hql"></param>
        /// <param name="pDictionary"></param>
        /// <returns></returns>
		IList<T> GetListByHqlParam(String hql, Dictionary<String, Object> pDictionary);

	    /// <summary>
	    /// 
	    /// </summary>
	    /// <param name="hql"></param>
	    /// <param name="page"></param>
	    /// <param name="rows"></param>
	    /// <returns></returns>
        Pager<T> FindPagerByHql(String hql, int page, int rows);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hql"></param>
		/// <param name="pDictionary"></param>
		/// <param name="page"></param>
		/// <param name="rows"></param>
		/// <returns></returns>
        Pager<T> FindPagerByHqlParam(String hql, Dictionary<String, Object> pDictionary, int page, int rows);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hql"></param>
		/// <returns></returns>
		Int32 Count(String hql);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hql"></param>
		/// <param name="pDictionary"></param>
		/// <returns></returns>
		Int32 Count(String hql, Dictionary<String, Object> pDictionary);

	    /// <summary>
	    /// 
	    /// </summary>
	    /// <param name="hql"></param>
	    /// <returns></returns>
		int ExecuteHql(String hql);

	    /// <summary>
	    /// 
	    /// </summary>
	    /// <param name="hql"></param>
	    /// <param name="pDictionary"></param>
	    /// <returns></returns>
		int ExecuteHql(String hql, Dictionary<String, Object> pDictionary);

	    /// <summary>
	    /// 
	    /// </summary>
	    /// <param name="sql"></param>
	    /// <returns></returns>
        Pager<Object[]> FindPagerBySql(String sql);

	    /// <summary>
	    /// 
	    /// </summary>
	    /// <param name="sql"></param>
	    /// <param name="page"></param>
	    /// <param name="rows"></param>
	    /// <returns></returns>
        Pager<Object[]> FindPagerBySql(String sql, int page, int rows);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pDictionary"></param>
        /// <returns></returns>
        Pager<Object[]> FindPagerBySql(String sql, Dictionary<String, Object> pDictionary);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pDictionary"></param>
        /// <returns></returns>
        IList<object[]> FindBySqlList(String sql, Dictionary<String, Object> pDictionary);

        /// <summary>
        /// Sql语句查询List
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        IList<object[]> FindBySqlList(String sql);

	    /// <summary>
	    /// 根据条件查询Sql分页
	    /// </summary>
	    /// <param name="sql"></param>
	    /// <param name="pDictionary"></param>
	    /// <param name="page"></param>
	    /// <param name="rows"></param>
	    /// <returns></returns>
        Pager<Object[]> FindPagerBySql(String sql, Dictionary<String, Object> pDictionary, int page, int rows);

	    /// <summary>
	    /// 执行不带参数的Sql语句
	    /// </summary>
	    /// <param name="sql"></param>
	    /// <returns></returns>
		int executeSql(String sql);

	    /// <summary>
	    /// 执行带参数的Sql语句
	    /// </summary>
	    /// <param name="sql"></param>
	    /// <param name="pDictionary"></param>
	    /// <returns></returns>
		int executeSql(String sql, Dictionary<String, Object> pDictionary);

	    /// <summary>
	    /// 无参数Sql语句查询总数
	    /// </summary>
	    /// <param name="sql"></param>
	    /// <returns></returns>
		Int32 countBySql(String sql);

	    /// <summary>
	    /// Sql查询总数
	    /// </summary>
	    /// <param name="sql">Sql语句</param>
	    /// <param name="pDictionary">参数</param>
	    /// <returns></returns>
		Int32 countBySql(String sql, Dictionary<String, Object> pDictionary);

		#endregion
        /// <summary>
        /// 无条件分页查询
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        Pager<T> FindAllByPager(int page, int rows);
    }
}
