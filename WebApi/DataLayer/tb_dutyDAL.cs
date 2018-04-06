// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_dutyDAL : DbBase<tb_duty>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_duty> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_dutyTable.Name, tb_dutyTable.Column, tb_dutyTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_duty _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_dutyTable.Name, tb_dutyTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_duty _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_dutyTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Duty_ID.IsNotNull())
                {
                    str.Append("Duty_ID=@Duty_ID,");
                }
                if (_entity.Duty_Name.IsNotNull())
                {
                    str.Append("Duty_Name=@Duty_Name,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_dutyTable.Name, upStr, string.Format("{0}=@{0}", tb_dutyTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_duty> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_duty> Find(tb_duty _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_dutyTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Duty_ID.IsNotNull())
                {
                    str.AppendFormat(" AND Duty_ID='{0}'", _entity.Duty_ID);
                }
                if (_entity.Duty_Name.IsNotNull())
                {
                    str.AppendFormat(" AND Duty_Name='{0}'", _entity.Duty_Name);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_dutyTable.Column, tb_dutyTable.Name, flage);
            return DBHelper.ReadCollection<tb_duty>(Sql, null);
        }
        #endregion End Find
    }
}


