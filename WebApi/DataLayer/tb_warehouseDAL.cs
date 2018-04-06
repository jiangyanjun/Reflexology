// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_warehouseDAL : DbBase<tb_warehouse>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_warehouse> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_warehouseTable.Name, tb_warehouseTable.Column, tb_warehouseTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_warehouse _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_warehouseTable.Name, tb_warehouseTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_warehouse _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_warehouseTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.CK_ID.IsNotNull())
                {
                    str.Append("CK_ID=@CK_ID,");
                }
                if (_entity.CK_Name.IsNotNull())
                {
                    str.Append("CK_Name=@CK_Name,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_warehouseTable.Name, upStr, string.Format("{0}=@{0}", tb_warehouseTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_warehouse> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_warehouse> Find(tb_warehouse _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_warehouseTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.CK_ID.IsNotNull())
                {
                    str.AppendFormat(" AND CK_ID='{0}'", _entity.CK_ID);
                }
                if (_entity.CK_Name.IsNotNull())
                {
                    str.AppendFormat(" AND CK_Name='{0}'", _entity.CK_Name);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_warehouseTable.Column, tb_warehouseTable.Name, flage);
            return DBHelper.ReadCollection<tb_warehouse>(Sql, null);
        }
        #endregion End Find
    }
}


