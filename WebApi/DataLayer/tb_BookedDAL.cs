// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_BookedDAL : DbBase<tb_Booked>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_Booked> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_BookedTable.Name, tb_BookedTable.Column, tb_BookedTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_Booked _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_BookedTable.Name, tb_BookedTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_Booked _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_BookedTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.Append("Id=@Id,");
                }
                if (_entity.GuestName.IsNotNull())
                {
                    str.Append("GuestName=@GuestName,");
                }
                if (_entity.GuestTelePhone.IsNotNull())
                {
                    str.Append("GuestTelePhone=@GuestTelePhone,");
                }
                if (_entity.BookedDeskTypeId.IsNotNull())
                {
                    str.Append("BookedDeskTypeId=@BookedDeskTypeId,");
                }
                if (_entity.BookedDeskId.IsNotNull())
                {
                    str.Append("BookedDeskId=@BookedDeskId,");
                }
                if (_entity.BookedDateTime.IsNotNull())
                {
                    str.Append("BookedDateTime=@BookedDateTime,");
                }
                if (_entity.Remarks.IsNotNull())
                {
                    str.Append("Remarks=@Remarks,");
                }
                if (_entity.ShopId.IsNotNull())
                {
                    str.Append("ShopId=@ShopId,");
                }
                if (_entity.CreateUserId.IsNotNull())
                {
                    str.Append("CreateUserId=@CreateUserId,");
                }
                if (_entity.CreateTime.IsNotNull())
                {
                    str.Append("CreateTime=@CreateTime,");
                }
                if (_entity.LastOperationTime.IsNotNull())
                {
                    str.Append("LastOperationTime=@LastOperationTime,");
                }
                if (_entity.LastOperationUserId.IsNotNull())
                {
                    str.Append("LastOperationUserId=@LastOperationUserId,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_BookedTable.Name, upStr, string.Format("{0}=@{0}", tb_BookedTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_Booked> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_Booked> Find(tb_Booked _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_BookedTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.AppendFormat(" AND Id='{0}'", _entity.Id);
                }
                if (_entity.GuestName.IsNotNull())
                {
                    str.AppendFormat(" AND GuestName='{0}'", _entity.GuestName);
                }
                if (_entity.GuestTelePhone.IsNotNull())
                {
                    str.AppendFormat(" AND GuestTelePhone='{0}'", _entity.GuestTelePhone);
                }
                if (_entity.BookedDeskTypeId.IsNotNull())
                {
                    str.AppendFormat(" AND BookedDeskTypeId='{0}'", _entity.BookedDeskTypeId);
                }
                if (_entity.BookedDeskId.IsNotNull())
                {
                    str.AppendFormat(" AND BookedDeskId='{0}'", _entity.BookedDeskId);
                }
                if (_entity.BookedDateTime.IsNotNull())
                {
                    str.AppendFormat(" AND BookedDateTime='{0}'", _entity.BookedDateTime);
                }
                if (_entity.Remarks.IsNotNull())
                {
                    str.AppendFormat(" AND Remarks='{0}'", _entity.Remarks);
                }
                if (_entity.ShopId.IsNotNull())
                {
                    str.AppendFormat(" AND ShopId='{0}'", _entity.ShopId);
                }
                if (_entity.CreateUserId.IsNotNull())
                {
                    str.AppendFormat(" AND CreateUserId='{0}'", _entity.CreateUserId);
                }
                if (_entity.CreateTime.IsNotNull())
                {
                    str.AppendFormat(" AND CreateTime='{0}'", _entity.CreateTime);
                }
                if (_entity.LastOperationTime.IsNotNull())
                {
                    str.AppendFormat(" AND LastOperationTime='{0}'", _entity.LastOperationTime);
                }
                if (_entity.LastOperationUserId.IsNotNull())
                {
                    str.AppendFormat(" AND LastOperationUserId='{0}'", _entity.LastOperationUserId);
                }
                #endregion
                flage = str.ToString();
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_BookedTable.Column, tb_BookedTable.Name, flage);
            return DBHelper.ReadCollection<tb_Booked>(Sql, null);
        }
        #endregion End Find
    }
}


