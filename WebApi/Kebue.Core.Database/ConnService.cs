using Kebue.Core.Util;
using Microsoft.Data.Sqlite;
using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Kebue.Core.Database
{
    public class ConnService : IDisposable
    {
        public ConnService(DbTypeEnum dbtype = DbTypeEnum.SqlServer, string connStr = "")
        {
            if (connection == null)
            {
                switch (dbtype)
                {
                    case DbTypeEnum.SqlLite:
                        connection = new SqliteConnection(ConnectionDatabaseStr(StaticStr.DatabaseConnectionStr));
                        break;
                    case DbTypeEnum.SqlServer:
                        connection = new SqlConnection(StaticStr.DatabaseConnectionStr);
                        break;
                        //case DbTypeEnum.MySql:
                        //    connection = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                        //    break;
                        //case DbTypeEnum.PostgreSQL:
                        //    connection = new Npgsql.NpgsqlConnection(connStr);
                        //    break;
                        //default:
                        //    connection = new SqlConnection(StaticToolHelp.ConnectionDatabaseStr);
                        //    break;
                }
                connection.Open();
            }
        }
        static string ConnectionDatabaseStr(string path)
        {
            return string.Format("Data Source={0}", path);
        }
        #region 数据库连接对象
        private DbConnection connection = null;
        public DbConnection Connection
        {
            get
            {
                return connection;
            }
        }
        #endregion
        public void Dispose()
        {
            if (connection != null)
                connection.Close();
        }
    }
}
