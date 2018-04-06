using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{
    public class ProductTypeDAL : DbBase<ProductType>
    {
        #region Add	新增	
        public override int Add(IEnumerable<ProductType> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, ProductTypeTable.Name, ProductTypeTable.Column, ProductTypeTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(ProductType _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, ProductTypeTable.Name, ProductTypeTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(ProductType _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && ProductTypeTable.PrimaryKey.IsNotNull())
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
                if (_entity.ShopId.IsNotNull())
                {
                    str.Append("ShopId=@ShopId,");
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
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, ProductTypeTable.Name, upStr, string.Format("{0}=@{0}", ProductTypeTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<ProductType> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<ProductType> Find(ProductType _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && ProductTypeTable.PrimaryKey.IsNotNull())
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
                if (_entity.ShopId.IsNotNull())
                {
                    str.AppendFormat(" AND ShopId='{0}'", _entity.ShopId);
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
                #endregion
                flage = str.ToString();
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, ProductTypeTable.Column, ProductTypeTable.Name, flage);
            return DBHelper.ReadCollection<ProductType>(Sql, null);
        }
        #endregion End Find
    }
}
