// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_powertypeDAL : DbBase<tb_powertype>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_powertype> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_powertypeTable.Name, tb_powertypeTable.Column, tb_powertypeTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_powertype _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_powertypeTable.Name, tb_powertypeTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_powertype _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_powertypeTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Pt_ID.IsNotNull())
                {
                    str.Append("Pt_ID=@Pt_ID,");
                }
                if (_entity.Pt_Name.IsNotNull())
                {
                    str.Append("Pt_Name=@Pt_Name,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_powertypeTable.Name, upStr, string.Format("{0}=@{0}", tb_powertypeTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_powertype> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_powertype> Find(tb_powertype _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_powertypeTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Pt_ID.IsNotNull())
                {
                    str.AppendFormat(" AND Pt_ID='{0}'", _entity.Pt_ID);
                }
                if (_entity.Pt_Name.IsNotNull())
                {
                    str.AppendFormat(" AND Pt_Name='{0}'", _entity.Pt_Name);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_powertypeTable.Column, tb_powertypeTable.Name, flage);
            return DBHelper.ReadCollection<tb_powertype>(Sql, null);
        }
        #endregion End Find
    }
}


