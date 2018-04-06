// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_goodsMXDAL : DbBase<tb_goodsMX>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_goodsMX> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_goodsMXTable.Name, tb_goodsMXTable.Column, tb_goodsMXTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_goodsMX _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_goodsMXTable.Name, tb_goodsMXTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_goodsMX _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_goodsMXTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.MX_ID.IsNotNull())
                {
                    str.Append("MX_ID=@MX_ID,");
                }
                if (_entity.MX_CGID.IsNotNull())
                {
                    str.Append("MX_CGID=@MX_CGID,");
                }
                if (_entity.MX_name.IsNotNull())
                {
                    str.Append("MX_name=@MX_name,");
                }
                if (_entity.Goods_type.IsNotNull())
                {
                    str.Append("Goods_type=@Goods_type,");
                }
                if (_entity.MX_price.IsNotNull())
                {
                    str.Append("MX_price=@MX_price,");
                }
                if (_entity.MX_num.IsNotNull())
                {
                    str.Append("MX_num=@MX_num,");
                }
                if (_entity.MX_allprice.IsNotNull())
                {
                    str.Append("MX_allprice=@MX_allprice,");
                }
                if (_entity.MX_beizhu.IsNotNull())
                {
                    str.Append("MX_beizhu=@MX_beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_goodsMXTable.Name, upStr, string.Format("{0}=@{0}", tb_goodsMXTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_goodsMX> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_goodsMX> Find(tb_goodsMX _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_goodsMXTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.MX_ID.IsNotNull())
                {
                    str.AppendFormat(" AND MX_ID='{0}'", _entity.MX_ID);
                }
                if (_entity.MX_CGID.IsNotNull())
                {
                    str.AppendFormat(" AND MX_CGID='{0}'", _entity.MX_CGID);
                }
                if (_entity.MX_name.IsNotNull())
                {
                    str.AppendFormat(" AND MX_name='{0}'", _entity.MX_name);
                }
                if (_entity.Goods_type.IsNotNull())
                {
                    str.AppendFormat(" AND Goods_type='{0}'", _entity.Goods_type);
                }
                if (_entity.MX_price.IsNotNull())
                {
                    str.AppendFormat(" AND MX_price='{0}'", _entity.MX_price);
                }
                if (_entity.MX_num.IsNotNull())
                {
                    str.AppendFormat(" AND MX_num='{0}'", _entity.MX_num);
                }
                if (_entity.MX_allprice.IsNotNull())
                {
                    str.AppendFormat(" AND MX_allprice='{0}'", _entity.MX_allprice);
                }
                if (_entity.MX_beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND MX_beizhu='{0}'", _entity.MX_beizhu);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_goodsMXTable.Column, tb_goodsMXTable.Name, flage);
            return DBHelper.ReadCollection<tb_goodsMX>(Sql, null);
        }
        #endregion End Find
    }
}


