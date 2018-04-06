using Dapper;
using Foot.WebApi.DataLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Foot.WebApi.BusinessLayer
{
    public abstract class BaseBLL<T> where T : class, new()
    {
        public BaseBLL()
        {
            SetCurrentDAL();
        }
        public abstract void SetCurrentDAL();

        public IDbBase<T> CurrentDAL;

        public int Add(T obj)
        {
            List<T> list = new List<T>();
            list.Add(obj);
            return CurrentDAL.Add(list);
        }
        public int Add(List<T> t)
        {
            return CurrentDAL.Add(t);
        }

        public int Delete(T t)
        {
            return CurrentDAL.Delete(t);
        }

        public int ExcuteSQL(string _sql)
        {
            return CurrentDAL.ExcuteSQL(_sql);
        }

        public string ExecuteScalarString(string _sql)
        {
            return CurrentDAL.ExecuteScalarString(_sql);
        }
        public List<T> Find(T t)
        {
            return CurrentDAL.Find(t);
        }

        public int Update(T t)
        {
            return CurrentDAL.Update(t);
        }
        public DataSet GetDataSet(string sql, DynamicParameters p)
        {
            return CurrentDAL.GetDataSet(sql, p);
        }
    }
}
