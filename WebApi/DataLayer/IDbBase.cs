using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Foot.WebApi.DataLayers
{
    public interface IDbBase<T>
    {
        /// <summary>
        /// 按主键查询返回集合
        /// </summary>
        /// <param name="primary">主键</param>
        /// <returns></returns>
        List<T> Find(T primary);

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
        DataSet GetDataSet(string sql, DynamicParameters p);
    }
}
