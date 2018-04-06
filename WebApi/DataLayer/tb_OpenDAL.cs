// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_OpenDAL : DbBase<tb_Open>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_Open> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_OpenTable.Name, tb_OpenTable.Column, tb_OpenTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_Open _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_OpenTable.Name, tb_OpenTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_Open _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_OpenTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.Append("Id=@Id,");
                }
                if (_entity.DeskId.IsNotNull())
                {
                    str.Append("DeskId=@DeskId,");
                }
                if (_entity.TypeId.IsNotNull())
                {
                    str.Append("TypeId=@TypeId,");
                }
                if (_entity.CustomersNumber.IsNotNull())
                {
                    str.Append("CustomersNumber=@CustomersNumber,");
                }
                if (_entity.Remarks.IsNotNull())
                {
                    str.Append("Remarks=@Remarks,");
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
                if (_entity.LastOperationUserId.IsNotNull())
                {
                    str.Append("LastOperationUserId=@LastOperationUserId,");
                }
                if (_entity.Status.IsNotNull())
                {
                    str.Append("Status=@Status,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_OpenTable.Name, upStr, string.Format("{0}=@{0}", tb_OpenTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_Open> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_Open> Find(tb_Open _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_OpenTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.AppendFormat(" AND Id='{0}'", _entity.Id);
                }
                if (_entity.TypeId.IsNotNull())
                {
                    str.AppendFormat(" AND TypeId='{0}'", _entity.TypeId);
                }
                if (_entity.DeskId.IsNotNull())
                {
                    str.AppendFormat(" AND DeskId='{0}'", _entity.DeskId);
                }
                if (_entity.CustomersNumber.IsNotNull())
                {
                    str.AppendFormat(" AND CustomersNumber='{0}'", _entity.CustomersNumber);
                }
                if (_entity.Status.IsNotNull())
                {
                    str.AppendFormat(" AND Status='{0}'", _entity.Status);
                }
                if (_entity.CreateTime.IsNotNull())
                {
                    str.AppendFormat(" AND CreateTime='{0}'", _entity.CreateTime);
                }
                if (_entity.CreateUserId.IsNotNull())
                {
                    str.AppendFormat(" AND CreateUserId='{0}'", _entity.CreateUserId);
                }
                if (_entity.LastOperationUserId.IsNotNull())
                {
                    str.AppendFormat(" AND LastOperationUserId='{0}'", _entity.LastOperationUserId);
                }
                if (_entity.LastOperationTime.IsNotNull())
                {
                    str.AppendFormat(" AND LastOperationTime='{0}'", _entity.LastOperationTime);
                }
                if (_entity.Remarks.IsNotNull())
                {
                    str.AppendFormat(" AND Remarks='{0}'", _entity.Remarks);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_OpenTable.Column, tb_OpenTable.Name, flage);
            return DBHelper.ReadCollection<tb_Open>(Sql, null);
        }
        #endregion End Find
    }
}


