// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_DeskTypeDAL : DbBase<tb_DeskType>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_DeskType> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_DeskTypeTable.Name, tb_DeskTypeTable.Column, tb_DeskTypeTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_DeskType _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_DeskTypeTable.Name, tb_DeskTypeTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_DeskType _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_DeskTypeTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.Append("Id=@Id,");
                }
                if (_entity.Name.IsNotNull())
                {
                    str.Append("Name=@Name,");
                }
                if (_entity.CreateTime.IsNotNull())
                {
                    str.Append("CreateTime=@CreateTime,");
                }
                if (_entity.CreateUserId.IsNotNull())
                {
                    str.Append("CreateUserId=@CreateUserId,");
                }
                if (_entity.LastOperationTime.IsNotNull())
                {
                    str.Append("LastOperationTime=@LastOperationTime,");
                }
                if (_entity.Remarks.IsNotNull())
                {
                    str.Append("Remarks=@Remarks,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_DeskTypeTable.Name, upStr, string.Format("{0}=@{0}", tb_DeskTypeTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_DeskType> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_DeskType> Find(tb_DeskType _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_DeskTypeTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.AppendFormat(" AND Id='{0}'", _entity.Id);
                }
                if (_entity.Name.IsNotNull())
                {
                    str.AppendFormat(" AND Name='{0}'", _entity.Name);
                }
                if (_entity.Remarks.IsNotNull())
                {
                    str.AppendFormat(" AND Remarks='{0}'", _entity.Remarks);
                }
                if (_entity.CreateUserId.IsNotNull())
                {
                    str.AppendFormat(" AND DT_number='{0}'", _entity.CreateUserId);
                }
                if (_entity.LastOperationUserId.IsNotNull())
                {
                    str.AppendFormat(" AND LastOperationUserId='{0}'", _entity.LastOperationUserId);
                }
                if (_entity.LastOperationTime.IsNotNull())
                {
                    str.AppendFormat(" AND LastOperationTime='{0}'", _entity.LastOperationTime);
                }
                if (_entity.CreateTime.IsNotNull())
                {
                    str.AppendFormat(" AND CreateTime='{0}'", _entity.CreateTime);
                }
                #endregion
                flage = str.ToString();
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_DeskTypeTable.Column, tb_DeskTypeTable.Name, flage);
            return DBHelper.ReadCollection<tb_DeskType>(Sql, null);
        }
        #endregion End Find
    }
}


