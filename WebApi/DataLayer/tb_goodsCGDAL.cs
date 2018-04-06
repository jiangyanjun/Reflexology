// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_goodsCGDAL : DbBase<tb_goodsCG>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_goodsCG> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_goodsCGTable.Name, tb_goodsCGTable.Column, tb_goodsCGTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_goodsCG _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_goodsCGTable.Name, tb_goodsCGTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_goodsCG _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_goodsCGTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.CG_ID.IsNotNull())
                {
                    str.Append("CG_ID=@CG_ID,");
                }
                if (_entity.CG_sj.IsNotNull())
                {
                    str.Append("CG_sj=@CG_sj,");
                }
                if (_entity.CG_ghs.IsNotNull())
                {
                    str.Append("CG_ghs=@CG_ghs,");
                }
                if (_entity.CG_buyer.IsNotNull())
                {
                    str.Append("CG_buyer=@CG_buyer,");
                }
                if (_entity.CG_Allprice.IsNotNull())
                {
                    str.Append("CG_Allprice=@CG_Allprice,");
                }
                if (_entity.CG_beizhu.IsNotNull())
                {
                    str.Append("CG_beizhu=@CG_beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_goodsCGTable.Name, upStr, string.Format("{0}=@{0}", tb_goodsCGTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_goodsCG> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_goodsCG> Find(tb_goodsCG _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_goodsCGTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.CG_ID.IsNotNull())
                {
                    str.AppendFormat(" AND CG_ID='{0}'", _entity.CG_ID);
                }
                if (_entity.CG_sj.IsNotNull())
                {
                    str.AppendFormat(" AND CG_sj='{0}'", _entity.CG_sj);
                }
                if (_entity.CG_ghs.IsNotNull())
                {
                    str.AppendFormat(" AND CG_ghs='{0}'", _entity.CG_ghs);
                }
                if (_entity.CG_buyer.IsNotNull())
                {
                    str.AppendFormat(" AND CG_buyer='{0}'", _entity.CG_buyer);
                }
                if (_entity.CG_Allprice.IsNotNull())
                {
                    str.AppendFormat(" AND CG_Allprice='{0}'", _entity.CG_Allprice);
                }
                if (_entity.CG_beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND CG_beizhu='{0}'", _entity.CG_beizhu);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_goodsCGTable.Column, tb_goodsCGTable.Name, flage);
            return DBHelper.ReadCollection<tb_goodsCG>(Sql, null);
        }
        #endregion End Find
    }
}


