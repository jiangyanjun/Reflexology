using System.Collections.Generic;

namespace Kebue.Core.API.CommLayer
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
        public int Add(IEnumerable<T> t)
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

        public IEnumerable<T> Find()
        {
            return CurrentDAL.Find();
        }

        public IEnumerable<T> Find(string id)
        {
            return CurrentDAL.Find(id);
        }

        public int Update(T t)
        {
            return CurrentDAL.Update(t);
        }
    }
}
