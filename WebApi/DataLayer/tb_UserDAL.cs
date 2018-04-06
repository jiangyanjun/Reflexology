// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_UserDAL : DbBase<tb_User>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_User> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_UserTable.Name, tb_UserTable.Column, tb_UserTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_User _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_UserTable.Name, tb_UserTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_User _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_UserTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.Append("ID=@ID,");
                }
                if (_entity.User_Name.IsNotNull())
                {
                    str.Append("User_Name=@User_Name,");
                }
                if (_entity.User_Pwd.IsNotNull())
                {
                    str.Append("User_Pwd=@User_Pwd,");
                }
                if (_entity.power.IsNotNull())
                {
                    str.Append("power=@power,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_UserTable.Name, upStr, string.Format("{0}=@{0}", tb_UserTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_User> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_User> Find(tb_User _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_UserTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.AppendFormat(" AND ID='{0}'", _entity.Id);
                }
                if (_entity.User_Name.IsNotNull())
                {
                    str.AppendFormat(" AND User_Name='{0}'", _entity.User_Name);
                }
                if (_entity.User_Pwd.IsNotNull())
                {
                    str.AppendFormat(" AND User_Pwd='{0}'", _entity.User_Pwd);
                }
                if (_entity.power.IsNotNull())
                {
                    str.AppendFormat(" AND power='{0}'", _entity.power);
                }
                #endregion
                flage = str.ToString();
                ////flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_UserTable.Column, tb_UserTable.Name, flage);
            return DBHelper.ReadCollection<tb_User>(Sql, null);
        }
        #endregion End Find
    }
}


