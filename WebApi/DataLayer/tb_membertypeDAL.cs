// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_membertypeDAL : DbBase<tb_membertype>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_membertype> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_membertypeTable.Name, tb_membertypeTable.Column, tb_membertypeTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_membertype _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_membertypeTable.Name, tb_membertypeTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_membertype _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_membertypeTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Mt_ID.IsNotNull())
                {
                    str.Append("Mt_ID=@Mt_ID,");
                }
                if (_entity.Mt_Name.IsNotNull())
                {
                    str.Append("Mt_Name=@Mt_Name,");
                }
                if (_entity.Mt_csjf.IsNotNull())
                {
                    str.Append("Mt_csjf=@Mt_csjf,");
                }
                if (_entity.Mt_agio.IsNotNull())
                {
                    str.Append("Mt_agio=@Mt_agio,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_membertypeTable.Name, upStr, string.Format("{0}=@{0}", tb_membertypeTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_membertype> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_membertype> Find(tb_membertype _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_membertypeTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Mt_ID.IsNotNull())
                {
                    str.AppendFormat(" AND Mt_ID='{0}'", _entity.Mt_ID);
                }
                if (_entity.Mt_Name.IsNotNull())
                {
                    str.AppendFormat(" AND Mt_Name='{0}'", _entity.Mt_Name);
                }
                if (_entity.Mt_csjf.IsNotNull())
                {
                    str.AppendFormat(" AND Mt_csjf='{0}'", _entity.Mt_csjf);
                }
                if (_entity.Mt_agio.IsNotNull())
                {
                    str.AppendFormat(" AND Mt_agio='{0}'", _entity.Mt_agio);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_membertypeTable.Column, tb_membertypeTable.Name, flage);
            return DBHelper.ReadCollection<tb_membertype>(Sql, null);
        }
        #endregion End Find
    }
}


