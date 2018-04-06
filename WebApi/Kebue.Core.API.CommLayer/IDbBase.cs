using System.Collections.Generic;

namespace Kebue.Core.API.CommLayer
{
    public interface IDbBase<T>
    {
        /// <summary>
        /// 返回集合
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Find();

        /// <summary>
        /// 按主键查询返回集合
        /// </summary>
        /// <param name="primaryKey">主键</param>
        /// <returns></returns>
        IEnumerable<T> Find(string primaryKey);

        /// <summary>
        /// 集合增加到数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Add(IEnumerable<T> p);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Delete(T p);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update(T p);

        /// <summary>
        /// 查询单个返回数值
        /// </summary>
        /// <param name="_sql">要执行的SQL</param>
        /// <returns></returns>
        int ExcuteSQL(string _sql);

        /// <summary>
        /// 查询单个返回字符串值
        /// </summary>
        /// <param name="_sql">要执行的SQL</param>
        /// <returns></returns>
        string ExecuteScalarString(string _sql);

    }
}
