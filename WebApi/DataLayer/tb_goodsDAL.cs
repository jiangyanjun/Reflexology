// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_goodsDAL : DbBase<tb_goods>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_goods> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_goodsTable.Name, tb_goodsTable.Column, tb_goodsTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_goods _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_goodsTable.Name, tb_goodsTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_goods _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_goodsTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.goods_ID.IsNotNull())
                {
                    str.Append("goods_ID=@goods_ID,");
                }
                if (_entity.goods_Name.IsNotNull())
                {
                    str.Append("goods_Name=@goods_Name,");
                }
                if (_entity.Goods_type.IsNotNull())
                {
                    str.Append("Goods_type=@Goods_type,");
                }
                if (_entity.Goods_Xsprice.IsNotNull())
                {
                    str.Append("Goods_Xsprice=@Goods_Xsprice,");
                }
                if (_entity.Goods_num.IsNotNull())
                {
                    str.Append("Goods_num=@Goods_num,");
                }
                if (_entity.Goods_Jhnum.IsNotNull())
                {
                    str.Append("Goods_Jhnum=@Goods_Jhnum,");
                }
                if (_entity.Goods_Jhprice.IsNotNull())
                {
                    str.Append("Goods_Jhprice=@Goods_Jhprice,");
                }
                if (_entity.Goods_allprice.IsNotNull())
                {
                    str.Append("Goods_allprice=@Goods_allprice,");
                }
                if (_entity.Goods_CKID.IsNotNull())
                {
                    str.Append("Goods_CKID=@Goods_CKID,");
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.Append("Beizhu=@Beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_goodsTable.Name, upStr, string.Format("{0}=@{0}", tb_goodsTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_goods> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_goods> Find(tb_goods _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_goodsTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.goods_ID.IsNotNull())
                {
                    str.AppendFormat(" AND goods_ID='{0}'", _entity.goods_ID);
                }
                if (_entity.goods_Name.IsNotNull())
                {
                    str.AppendFormat(" AND goods_Name='{0}'", _entity.goods_Name);
                }
                if (_entity.Goods_type.IsNotNull())
                {
                    str.AppendFormat(" AND Goods_type='{0}'", _entity.Goods_type);
                }
                if (_entity.Goods_Xsprice.IsNotNull())
                {
                    str.AppendFormat(" AND Goods_Xsprice='{0}'", _entity.Goods_Xsprice);
                }
                if (_entity.Goods_num.IsNotNull())
                {
                    str.AppendFormat(" AND Goods_num='{0}'", _entity.Goods_num);
                }
                if (_entity.Goods_Jhnum.IsNotNull())
                {
                    str.AppendFormat(" AND Goods_Jhnum='{0}'", _entity.Goods_Jhnum);
                }
                if (_entity.Goods_Jhprice.IsNotNull())
                {
                    str.AppendFormat(" AND Goods_Jhprice='{0}'", _entity.Goods_Jhprice);
                }
                if (_entity.Goods_allprice.IsNotNull())
                {
                    str.AppendFormat(" AND Goods_allprice='{0}'", _entity.Goods_allprice);
                }
                if (_entity.Goods_CKID.IsNotNull())
                {
                    str.AppendFormat(" AND Goods_CKID='{0}'", _entity.Goods_CKID);
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND Beizhu='{0}'", _entity.Beizhu);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_goodsTable.Column, tb_goodsTable.Name, flage);
            return DBHelper.ReadCollection<tb_goods>(Sql, null);
        }
        #endregion End Find
    }
}


