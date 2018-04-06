// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_memberXFDAL : DbBase<tb_memberXF>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_memberXF> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_memberXFTable.Name, tb_memberXFTable.Column, tb_memberXFTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_memberXF _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_memberXFTable.Name, tb_memberXFTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_memberXF _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_memberXFTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.HY_ID.IsNotNull())
                {
                    str.Append("HY_ID=@HY_ID,");
                }
                if (_entity.HY_Name.IsNotNull())
                {
                    str.Append("HY_Name=@HY_Name,");
                }
                if (_entity.YH_Zdh.IsNotNull())
                {
                    str.Append("YH_Zdh=@YH_Zdh,");
                }
                if (_entity.YH_desk.IsNotNull())
                {
                    str.Append("YH_desk=@YH_desk,");
                }
                if (_entity.YH_money.IsNotNull())
                {
                    str.Append("YH_money=@YH_money,");
                }
                if (_entity.YH_sj.IsNotNull())
                {
                    str.Append("YH_sj=@YH_sj,");
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.Append("Beizhu=@Beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_memberXFTable.Name, upStr, string.Format("{0}=@{0}", tb_memberXFTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_memberXF> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_memberXF> Find(tb_memberXF _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_memberXFTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.HY_ID.IsNotNull())
                {
                    str.AppendFormat(" AND HY_ID='{0}'", _entity.HY_ID);
                }
                if (_entity.HY_Name.IsNotNull())
                {
                    str.AppendFormat(" AND HY_Name='{0}'", _entity.HY_Name);
                }
                if (_entity.YH_Zdh.IsNotNull())
                {
                    str.AppendFormat(" AND YH_Zdh='{0}'", _entity.YH_Zdh);
                }
                if (_entity.YH_desk.IsNotNull())
                {
                    str.AppendFormat(" AND YH_desk='{0}'", _entity.YH_desk);
                }
                if (_entity.YH_money.IsNotNull())
                {
                    str.AppendFormat(" AND YH_money='{0}'", _entity.YH_money);
                }
                if (_entity.YH_sj.IsNotNull())
                {
                    str.AppendFormat(" AND YH_sj='{0}'", _entity.YH_sj);
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND Beizhu='{0}'", _entity.Beizhu);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_memberXFTable.Column, tb_memberXFTable.Name, flage);
            return DBHelper.ReadCollection<tb_memberXF>(Sql, null);
        }
        #endregion End Find
    }
}


