namespace Kebue.Core.Database
{
    public class DbSqlFormat
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 查询sql
        /// </summary>
        public const string SelectForm = "SELECT {0} FROM {1} WHERE 1=1 {2}";
        /// <summary>
        /// 更新sql语句
        /// </summary>
        public const string UpdateForm = "UPDATE {0} SET {1} WHERE {2}";
        /// <summary>
        /// 新增sql语句
        /// </summary>
        public const string InsertForm = "INSERT INTO {0} ({1}) VALUES({2})";
        /// <summary>
        /// 删除sql语句
        /// </summary>
        public const string DeleteForm = "DELETE {0} WHERE {1}";
    }
}
