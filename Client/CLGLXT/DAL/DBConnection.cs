using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Foot.Client.DAL
{
    class DBConnection
    {
        /// <summary>      
        ///  连接数据库私有字符串，本类使用，不能修改，只能读取。
        /// </summary>
        // Data Source 数据源,DataBase 数据库的名字 
        // Uid 登陆这个数据库需要的用户名,Pws 登陆这个数据库需要的密码
       private readonly string DBcon = @"Server=.;DataBase=DB_MyCL;Uid=sa;Pwd=sa";

       /// <summary>
       /// 根据传入的SQL语句，执行一个查询操作，传入的SQL语句只能是Select
       /// </summary>
       /// <param name="Str_Sql">例如Str_Sql="select * from a"</param>
       /// <returns>返回一个DataSet的数据集</returns>
       // DataSet 表示数据在内存中的缓存
       public DataSet GetDataFromSQL(string Str_Sql)
       {
           SqlConnection con = new SqlConnection(DBcon);
           SqlDataAdapter da = new SqlDataAdapter(Str_Sql,con);
           DataSet ds = new DataSet();
           da.Fill(ds);
           return ds;
       }
       /// <summary>
       ///执行 Insert into,updata,delete 三种SQL语句的通用方法
       /// </summary>
       /// <param name="Str_Sql">例如Str_Sql="select * from a where id='1';"</param>
       /// <returns>返回一个Bool型的值，为真执行成功，为假执行失败</returns>
       public bool ExecSQl(string Str_Sql)
       {
           SqlConnection con = new SqlConnection(DBcon);
           SqlCommand com = new SqlCommand(Str_Sql,con);

           con.Open();
           int a = com.ExecuteNonQuery();
           con.Close();
           if (a > 0)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
        /// <summary>
        /// 验证数据是否存在
        /// </summary>
        /// <param name="str_sql">统计 查询语句</param>
        /// <returns>统计的数据行数</returns>
       public Int32 YZSql(string str_sql)
       {
           SqlConnection con = new SqlConnection(DBcon);

           SqlCommand com = new SqlCommand(str_sql, con);
           con.Open();
           Int32 aa = (Int32)com.ExecuteScalar();
           con.Close();

           return aa;
       }
    }
}
