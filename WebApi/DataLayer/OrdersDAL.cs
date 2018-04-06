using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{
    public class OrdersDAL : DbBase<Orders>
    {
        #region Add	新增	
        public override int Add(IEnumerable<Orders> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, OrdersTable.Name, OrdersTable.Column, OrdersTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(Orders _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, OrdersTable.Name, OrdersTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(Orders _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && OrdersTable.PrimaryKey.IsNotNull())
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
                if (_entity.CustomerNumber.IsNotNull())
                {
                    str.Append("CustomerNumber=@CustomerNumber,");
                }
                if (_entity.TypeId.IsNotNull())
                {
                    str.Append("TypeId=@TypeId,");
                }
                if (_entity.MemberId.IsNotNull())
                {
                    str.Append("MemberId=@MemberId,");
                }
                if (_entity.CustomerName.IsNotNull())
                {
                    str.Append("CustomerName=@CustomerName,");
                }
                if (_entity.TelePhone.IsNotNull())
                {
                    str.Append("TelePhone=@TelePhone,");
                }
                if (_entity.ShopId.IsNotNull())
                {
                    str.Append("ShopId=@ShopId,");
                }
                if (_entity.Status.IsNotNull())
                {
                    str.Append("Status=@Status,");
                }
                if (_entity.PackageId.IsNotNull())
                {
                    str.Append("PackageId=@PackageId,");
                }
                if (_entity.FlowStatus.IsNotNull())
                {
                    str.Append("FlowStatus=@FlowStatus,");
                }
                if (_entity.TotalAmount.IsNotNull())
                {
                    str.Append("TotalAmount=@TotalAmount,");
                }
                if (_entity.FreeAmount.IsNotNull())
                {
                    str.Append("FreeAmount=@FreeAmount,");
                }
                if (_entity.PaymentAmount.IsNotNull())
                {
                    str.Append("PaymentAmount=@PaymentAmount,");
                }
                if (_entity.Remarks.IsNotNull())
                {
                    str.Append("Remarks=@Remarks,");
                }
                if (_entity.CreateUserId.IsNotNull())
                {
                    str.Append("CreateUserId=@CreateUserId,");
                }
                if (_entity.CreateTime.IsNotNull())
                {
                    str.Append("CreateTime=@CreateTime,");
                }
                if (_entity.LastOperationUserId.IsNotNull())
                {
                    str.Append("LastOperationUserId=@LastOperationUserId,");
                }
                if (_entity.LastOperationTime.IsNotNull())
                {
                    str.Append("LastOperationTime=@LastOperationTime,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, OrdersTable.Name, upStr, string.Format("{0}=@{0}", OrdersTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<Orders> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<Orders> Find(Orders _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && OrdersTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.AppendFormat(" AND Id='{0}'", _entity.Id);
                }
                if (_entity.DeskId.IsNotNull())
                {
                    str.AppendFormat(" AND DeskId='{0}'", _entity.DeskId);
                }
                if (_entity.CustomerNumber.IsNotNull())
                {
                    str.AppendFormat(" AND CustomerNumber='{0}'", _entity.CustomerNumber);
                }
                if (_entity.TypeId.IsNotNull())
                {
                    str.AppendFormat(" AND TypeId='{0}'", _entity.TypeId);
                }
                if (_entity.MemberId.IsNotNull())
                {
                    str.AppendFormat(" AND MemberId='{0}'", _entity.MemberId);
                }
                if (_entity.PackageId.IsNotNull())
                {
                    str.AppendFormat(" AND PackageId='{0}'", _entity.PackageId);
                }
                if (_entity.CustomerName.IsNotNull())
                {
                    str.AppendFormat(" AND CustomerName='{0}'", _entity.CustomerName);
                }
                if (_entity.TelePhone.IsNotNull())
                {
                    str.AppendFormat(" AND TelePhone='{0}'", _entity.TelePhone);
                }
                if (_entity.ShopId.IsNotNull())
                {
                    str.AppendFormat(" AND ShopId='{0}'", _entity.ShopId);
                }
                if (_entity.Status.IsNotNull())
                {
                    str.AppendFormat(" AND Status='{0}'", _entity.Status);
                }
                if (_entity.FlowStatus.IsNotNull())
                {
                    str.AppendFormat(" AND FlowStatus='{0}'", _entity.FlowStatus);
                }
                if (_entity.TotalAmount.IsNotNull())
                {
                    str.AppendFormat(" AND TotalAmount='{0}'", _entity.TotalAmount);
                }
                if (_entity.FreeAmount.IsNotNull())
                {
                    str.AppendFormat(" AND FreeAmount='{0}'", _entity.FreeAmount);
                }
                if (_entity.PaymentAmount.IsNotNull())
                {
                    str.AppendFormat(" AND PaymentAmount='{0}'", _entity.PaymentAmount);
                }
                if (_entity.Remarks.IsNotNull())
                {
                    str.AppendFormat(" AND Remarks='{0}'", _entity.Remarks);
                }
                if (_entity.CreateUserId.IsNotNull())
                {
                    str.AppendFormat(" AND CreateUserId='{0}'", _entity.CreateUserId);
                }
                if (_entity.CreateTime.IsNotNull())
                {
                    str.AppendFormat(" AND CreateTime='{0}'", _entity.CreateTime);
                }
                if (_entity.LastOperationUserId.IsNotNull())
                {
                    str.AppendFormat(" AND LastOperationUserId='{0}'", _entity.LastOperationUserId);
                }
                if (_entity.LastOperationTime.IsNotNull())
                {
                    str.AppendFormat(" AND LastOperationTime='{0}'", _entity.LastOperationTime);
                }
                #endregion
                flage = str.ToString();
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, OrdersTable.Column, OrdersTable.Name, flage);
            return DBHelper.ReadCollection<Orders>(Sql, null);
        }
        #endregion End Find
    }
}
