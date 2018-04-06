// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_XFDAL : DbBase<tb_XF>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_XF> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_XFTable.Name, tb_XFTable.Column, tb_XFTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_XF _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_XFTable.Name, tb_XFTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_XF _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_XFTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.XF_ID.IsNotNull())
                {
                    str.Append("XF_ID=@XF_ID,");
                }
                if (_entity.XF_desk.IsNotNull())
                {
                    str.Append("XF_desk=@XF_desk,");
                }
                if (_entity.XF_Ymoney.IsNotNull())
                {
                    str.Append("XF_Ymoney=@XF_Ymoney,");
                }
                if (_entity.XF_ZK.IsNotNull())
                {
                    str.Append("XF_ZK=@XF_ZK,");
                }
                if (_entity.XF_Smoney.IsNotNull())
                {
                    str.Append("XF_Smoney=@XF_Smoney,");
                }
                if (_entity.XF_sj.IsNotNull())
                {
                    str.Append("XF_sj=@XF_sj,");
                }
                if (_entity.XF_waiter.IsNotNull())
                {
                    str.Append("XF_waiter=@XF_waiter,");
                }
                if (_entity.beizhu.IsNotNull())
                {
                    str.Append("beizhu=@beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_XFTable.Name, upStr, string.Format("{0}=@{0}", tb_XFTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_XF> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_XF> Find(tb_XF _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_XFTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.XF_ID.IsNotNull())
                {
                    str.AppendFormat(" AND XF_ID='{0}'", _entity.XF_ID);
                }
                if (_entity.XF_desk.IsNotNull())
                {
                    str.AppendFormat(" AND XF_desk='{0}'", _entity.XF_desk);
                }
                if (_entity.XF_Ymoney.IsNotNull())
                {
                    str.AppendFormat(" AND XF_Ymoney='{0}'", _entity.XF_Ymoney);
                }
                if (_entity.XF_ZK.IsNotNull())
                {
                    str.AppendFormat(" AND XF_ZK='{0}'", _entity.XF_ZK);
                }
                if (_entity.XF_Smoney.IsNotNull())
                {
                    str.AppendFormat(" AND XF_Smoney='{0}'", _entity.XF_Smoney);
                }
                if (_entity.XF_sj.IsNotNull())
                {
                    str.AppendFormat(" AND XF_sj='{0}'", _entity.XF_sj);
                }
                if (_entity.XF_waiter.IsNotNull())
                {
                    str.AppendFormat(" AND XF_waiter='{0}'", _entity.XF_waiter);
                }
                if (_entity.beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND beizhu='{0}'", _entity.beizhu);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_XFTable.Column, tb_XFTable.Name, flage);
            return DBHelper.ReadCollection<tb_XF>(Sql, null);
        }
        #endregion End Find
    }
}


