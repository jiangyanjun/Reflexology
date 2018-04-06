// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_XFMXDAL : DbBase<tb_XFMX>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_XFMX> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_XFMXTable.Name, tb_XFMXTable.Column, tb_XFMXTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_XFMX _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_XFMXTable.Name, tb_XFMXTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_XFMX _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_XFMXTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.MX_XFID.IsNotNull())
                {
                    str.Append("MX_XFID=@MX_XFID,");
                }
                if (_entity.MX_Goods.IsNotNull())
                {
                    str.Append("MX_Goods=@MX_Goods,");
                }
                if (_entity.MX_goodstype.IsNotNull())
                {
                    str.Append("MX_goodstype=@MX_goodstype,");
                }
                if (_entity.MX_dj.IsNotNull())
                {
                    str.Append("MX_dj=@MX_dj,");
                }
                if (_entity.MX_Num.IsNotNull())
                {
                    str.Append("MX_Num=@MX_Num,");
                }
                if (_entity.MX_Allprice.IsNotNull())
                {
                    str.Append("MX_Allprice=@MX_Allprice,");
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.Append("Beizhu=@Beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_XFMXTable.Name, upStr, string.Format("{0}=@{0}", tb_XFMXTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_XFMX> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public List<tb_XFMX> GetHotProducts(string Sql)
        {
            return DBHelper.ReadCollection<tb_XFMX>(Sql, null);
        }
        public override List<tb_XFMX> Find(tb_XFMX _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_XFMXTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.MX_XFID.IsNotNull())
                {
                    str.AppendFormat(" AND MX_XFID='{0}'", _entity.MX_XFID);
                }
                if (_entity.MX_Goods.IsNotNull())
                {
                    str.AppendFormat(" AND MX_Goods='{0}'", _entity.MX_Goods);
                }
                if (_entity.MX_goodstype.IsNotNull())
                {
                    str.AppendFormat(" AND MX_goodstype='{0}'", _entity.MX_goodstype);
                }
                if (_entity.MX_dj.IsNotNull())
                {
                    str.AppendFormat(" AND MX_dj='{0}'", _entity.MX_dj);
                }
                if (_entity.MX_Num.IsNotNull())
                {
                    str.AppendFormat(" AND MX_Num='{0}'", _entity.MX_Num);
                }
                if (_entity.MX_Allprice.IsNotNull())
                {
                    str.AppendFormat(" AND MX_Allprice='{0}'", _entity.MX_Allprice);
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND Beizhu='{0}'", _entity.Beizhu);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_XFMXTable.Column, tb_XFMXTable.Name, flage);
            return DBHelper.ReadCollection<tb_XFMX>(Sql, null);
        }
        #endregion End Find
    }
}


