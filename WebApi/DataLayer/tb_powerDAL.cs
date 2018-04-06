// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_powerDAL : DbBase<tb_power>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_power> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_powerTable.Name, tb_powerTable.Column, tb_powerTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_power _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_powerTable.Name, tb_powerTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_power _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_powerTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.power_ID.IsNotNull())
                {
                    str.Append("power_ID=@power_ID,");
                }
                if (_entity.power_type.IsNotNull())
                {
                    str.Append("power_type=@power_type,");
                }
                if (_entity.power_Name.IsNotNull())
                {
                    str.Append("power_Name=@power_Name,");
                }
                if (_entity.pope.IsNotNull())
                {
                    str.Append("pope=@pope,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_powerTable.Name, upStr, string.Format("{0}=@{0}", tb_powerTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_power> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_power> Find(tb_power _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_powerTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.power_ID.IsNotNull())
                {
                    str.AppendFormat(" AND power_ID='{0}'", _entity.power_ID);
                }
                if (_entity.power_type.IsNotNull())
                {
                    str.AppendFormat(" AND power_type='{0}'", _entity.power_type);
                }
                if (_entity.power_Name.IsNotNull())
                {
                    str.AppendFormat(" AND power_Name='{0}'", _entity.power_Name);
                }
                if (_entity.pope.IsNotNull())
                {
                    str.AppendFormat(" AND pope='{0}'", _entity.pope);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_powerTable.Column, tb_powerTable.Name, flage);
            return DBHelper.ReadCollection<tb_power>(Sql, null);
        }
        #endregion End Find
    }
}


