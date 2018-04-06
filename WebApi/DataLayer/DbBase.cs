using Kebue.Core.Database;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace Foot.WebApi.DataLayers
{
    public abstract class DbBase<T> : IDbBase<T>
    {
        public abstract int Add(IEnumerable<T> _entity);
        public abstract int Delete(T _entity);
        public abstract int Update(T _entity);
        public abstract List<T> Find(T t);

        #region SQL  执行数据库操作
        public virtual int ExcuteSQL(string _sql)
        {
            return DBHelper.ExcuteSQL(_sql, null);
        }
        public virtual string ExecuteScalarString(string _sql)
        {
            return DBHelper.ExecuteScalarString(_sql, null);
        }
        public DataSet GetDataSet(string sql, DynamicParameters p)
        {
            return DBHelper.GetDataSet(sql, null);
        }
        #endregion
    }
}
