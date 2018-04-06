// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_goodsCFDAL : DbBase<tb_goodsCF>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_goodsCF> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_goodsCFTable.Name, tb_goodsCFTable.Column, tb_goodsCFTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_goodsCF _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_goodsCFTable.Name, tb_goodsCFTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_goodsCF _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_goodsCFTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.ID.IsNotNull())
                {
                    str.Append("ID=@ID,");
                }
                if (_entity.CF_ID.IsNotNull())
                {
                    str.Append("CF_ID=@CF_ID,");
                }
                if (_entity.CF_GoodsID.IsNotNull())
                {
                    str.Append("CF_GoodsID=@CF_GoodsID,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_goodsCFTable.Name, upStr, string.Format("{0}=@{0}", tb_goodsCFTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_goodsCF> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_goodsCF> Find(tb_goodsCF _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_goodsCFTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.ID.IsNotNull())
                {
                    str.AppendFormat(" AND ID='{0}'", _entity.ID);
                }
                if (_entity.CF_ID.IsNotNull())
                {
                    str.AppendFormat(" AND CF_ID='{0}'", _entity.CF_ID);
                }
                if (_entity.CF_GoodsID.IsNotNull())
                {
                    str.AppendFormat(" AND CF_GoodsID='{0}'", _entity.CF_GoodsID);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_goodsCFTable.Column, tb_goodsCFTable.Name, flage);
            return DBHelper.ReadCollection<tb_goodsCF>(Sql, null);
        }
        #endregion End Find
    }
}


