// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_qtxsDAL : DbBase<tb_qtxs>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_qtxs> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_qtxsTable.Name, tb_qtxsTable.Column, tb_qtxsTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_qtxs _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_qtxsTable.Name, tb_qtxsTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_qtxs _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_qtxsTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.QT_ID.IsNotNull())
                {
                    str.Append("QT_ID=@QT_ID,");
                }
                if (_entity.QT_Goods.IsNotNull())
                {
                    str.Append("QT_Goods=@QT_Goods,");
                }
                if (_entity.QT_goodstype.IsNotNull())
                {
                    str.Append("QT_goodstype=@QT_goodstype,");
                }
                if (_entity.QT_dj.IsNotNull())
                {
                    str.Append("QT_dj=@QT_dj,");
                }
                if (_entity.QT_Num.IsNotNull())
                {
                    str.Append("QT_Num=@QT_Num,");
                }
                if (_entity.QT_Allprice.IsNotNull())
                {
                    str.Append("QT_Allprice=@QT_Allprice,");
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.Append("Beizhu=@Beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_qtxsTable.Name, upStr, string.Format("{0}=@{0}", tb_qtxsTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_qtxs> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_qtxs> Find(tb_qtxs _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_qtxsTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.QT_ID.IsNotNull())
                {
                    str.AppendFormat(" AND QT_ID='{0}'", _entity.QT_ID);
                }
                if (_entity.QT_Goods.IsNotNull())
                {
                    str.AppendFormat(" AND QT_Goods='{0}'", _entity.QT_Goods);
                }
                if (_entity.QT_goodstype.IsNotNull())
                {
                    str.AppendFormat(" AND QT_goodstype='{0}'", _entity.QT_goodstype);
                }
                if (_entity.QT_dj.IsNotNull())
                {
                    str.AppendFormat(" AND QT_dj='{0}'", _entity.QT_dj);
                }
                if (_entity.QT_Num.IsNotNull())
                {
                    str.AppendFormat(" AND QT_Num='{0}'", _entity.QT_Num);
                }
                if (_entity.QT_Allprice.IsNotNull())
                {
                    str.AppendFormat(" AND QT_Allprice='{0}'", _entity.QT_Allprice);
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND Beizhu='{0}'", _entity.Beizhu);
                }
                #endregion
                flage = str.ToString();
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_qtxsTable.Column, tb_qtxsTable.Name, flage);
            return DBHelper.ReadCollection<tb_qtxs>(Sql, null);
        }
        #endregion End Find
    }
}


