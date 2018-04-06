using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{
    public class ProductDAL : DbBase<Product>
    {
        #region Add	新增	
        public override int Add(IEnumerable<Product> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, ProductTable.Name, ProductTable.Column, ProductTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(Product _entity)
        {
            if (_entity.Id.IsNotNull())
            {
                string Sql = string.Format(DbSqlFormat.DeleteForm, ProductTable.Name, string.Format("{0}='{1}'", ProductTable.PrimaryKey, _entity.Id));
                return DBHelper.ExcuteSQL(Sql, null);
            }
            else
            {
                return 0;
            }
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(Product _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && ProductTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.Append("Id=@Id,");
                }
                if (_entity.ShopId.IsNotNull())
                {
                    str.Append("ShopId=@ShopId,");
                }
                if (_entity.ProductTypeId.IsNotNull())
                {
                    str.Append("ProductTypeId=@ProductTypeId,");
                }
                if (_entity.ProductName.IsNotNull())
                {
                    str.Append("ProductName=@ProductName,");
                }
                if (_entity.CostPrice.IsNotNull())
                {
                    str.Append("CostPrice=@CostPrice,");
                }
                if (_entity.Inventory.IsNotNull())
                {
                    str.Append("Inventory=@Inventory,");
                }
                if (_entity.Price.IsNotNull())
                {
                    str.Append("Price=@Price,");
                }
                if (_entity.StockQuantity.IsNotNull())
                {
                    str.Append("StockQuantity=@StockQuantity,");
                }
                if (_entity.Status.IsNotNull())
                {
                    str.Append("Status=@Status,");
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
                if (_entity.QRode.IsNotNull())
                {
                    str.Append("QRode=@QRode,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, ProductTable.Name, upStr, string.Format("{0}=@{0}", ProductTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<Product> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<Product> Find(Product _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && ProductTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Id.IsNotNull())
                {
                    str.AppendFormat(" AND Id='{0}'", _entity.Id);
                }
                if (_entity.ShopId.IsNotNull())
                {
                    str.AppendFormat(" AND ShopId='{0}'", _entity.ShopId);
                }
                if (_entity.ProductTypeId.IsNotNull())
                {
                    str.AppendFormat(" AND ProductTypeId='{0}'", _entity.ProductTypeId);
                }
                if (_entity.ProductName.IsNotNull())
                {
                    str.AppendFormat(" AND ProductName='{0}'", _entity.ProductName);
                }
                if (_entity.CostPrice.IsNotNull())
                {
                    str.AppendFormat(" AND CostPrice='{0}'", _entity.CostPrice);
                }
                if (_entity.Price.IsNotNull())
                {
                    str.AppendFormat(" AND Price='{0}'", _entity.Price);
                }
                if (_entity.StockQuantity.IsNotNull())
                {
                    str.AppendFormat(" AND StockQuantity='{0}'", _entity.StockQuantity);
                }
                if (_entity.Status.IsNotNull())
                {
                    str.AppendFormat(" AND Status='{0}'", _entity.Status);
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
                if (_entity.Inventory.IsNotNull())
                {
                    str.AppendFormat(" AND Inventory='{0}'", _entity.Inventory);
                }
                if (_entity.QRode.IsNotNull())
                {
                    str.AppendFormat(" AND QRode='{0}'", _entity.QRode);
                }
                #endregion
                flage = str.ToString();
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, ProductTable.Column, ProductTable.Name, flage);
            return DBHelper.ReadCollection<Product>(Sql, null);
        }
        #endregion End Find
    }
}
