// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_DeskXSDAL : DbBase<tb_DeskXS>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_DeskXS> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_DeskXSTable.Name, tb_DeskXSTable.Column, tb_DeskXSTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_DeskXS _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_DeskXSTable.Name, tb_DeskXSTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_DeskXS _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_DeskXSTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.XS_ID.IsNotNull())
                {
                    str.Append("XS_ID=@XS_ID,");
                }
                if (_entity.XS_DeskName.IsNotNull())
                {
                    str.Append("XS_DeskName=@XS_DeskName,");
                }
                if (_entity.XS_goodsName.IsNotNull())
                {
                    str.Append("XS_goodsName=@XS_goodsName,");
                }
                if (_entity.XS_dj.IsNotNull())
                {
                    str.Append("XS_dj=@XS_dj,");
                }
                if (_entity.XS_Sum.IsNotNull())
                {
                    str.Append("XS_Sum=@XS_Sum,");
                }
                if (_entity.XS_allprice.IsNotNull())
                {
                    str.Append("XS_allprice=@XS_allprice,");
                }
                if (_entity.XS_sj.IsNotNull())
                {
                    str.Append("XS_sj=@XS_sj,");
                }
                if (_entity.beizhu.IsNotNull())
                {
                    str.Append("beizhu=@beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_DeskXSTable.Name, upStr, string.Format("{0}=@{0}", tb_DeskXSTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_DeskXS> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_DeskXS> Find(tb_DeskXS _entity)
        {
            if (_entity.IsNotNull() && _entity.XS_DeskName.IsNotNull())
            {
                switch (_entity.beizhu)
                {
                    case "查询桌台消费信息":
                        var str_sql = string.Format("select a.XS_goodsName,a.XS_dj,a.XS_Sum,a.XS_allprice,a.XS_sj,a.beizhu ,b.Open_Waiter from tb_DeskXS as a,tb_Open as b where a.XS_DeskName='{0}' and a.XS_DeskName=b.Open_Name", _entity.XS_DeskName);
                        return DBHelper.ReadCollection<tb_DeskXS>(str_sql, null);
                }
            }
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_DeskXSTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.XS_ID.IsNotNull())
                {
                    str.AppendFormat(" AND XS_ID='{0}'", _entity.XS_ID);
                }
                if (_entity.XS_DeskName.IsNotNull())
                {
                    str.AppendFormat(" AND XS_DeskName='{0}'", _entity.XS_DeskName);
                }
                if (_entity.XS_goodsName.IsNotNull())
                {
                    str.AppendFormat(" AND XS_goodsName='{0}'", _entity.XS_goodsName);
                }
                if (_entity.XS_dj.IsNotNull())
                {
                    str.AppendFormat(" AND XS_dj='{0}'", _entity.XS_dj);
                }
                if (_entity.XS_Sum.IsNotNull())
                {
                    str.AppendFormat(" AND XS_Sum='{0}'", _entity.XS_Sum);
                }
                if (_entity.XS_allprice.IsNotNull())
                {
                    str.AppendFormat(" AND XS_allprice='{0}'", _entity.XS_allprice);
                }
                if (_entity.XS_sj.IsNotNull())
                {
                    str.AppendFormat(" AND XS_sj='{0}'", _entity.XS_sj);
                }
                if (_entity.beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND beizhu='{0}'", _entity.beizhu);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_DeskXSTable.Column, tb_DeskXSTable.Name, flage);
            return DBHelper.ReadCollection<tb_DeskXS>(Sql, null);
        }
        #endregion End Find
    }
}


