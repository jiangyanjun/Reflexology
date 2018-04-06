// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_DeskDAL : DbBase<tb_Desk>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_Desk> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_DeskTable.Name, tb_DeskTable.Column, tb_DeskTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_Desk _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_DeskTable.Name, tb_DeskTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_Desk _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_DeskTable.PrimaryKey.IsNotNull())
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
                if (_entity.TypeId.IsNotNull())
                {
                    str.Append("TypeId=@TypeId,");
                }
                if (_entity.ShopId.IsNotNull())
                {
                    str.Append("ShopId=@ShopId,");
                }
                if (_entity.Status.IsNotNull())
                {
                    str.Append("Status=@Status,");
                }
                if (_entity.DeskStatus.IsNotNull())
                {
                    str.Append("DeskStatus=@DeskStatus,");
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
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_DeskTable.Name, upStr, string.Format("{0}=@{0}", tb_DeskTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_Desk> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_Desk> Find(tb_Desk _entity)
        {
            if (_entity.IsNotNull() && _entity.TypeId.IsNotNull())
            {
                switch (_entity.TypeId)
                {
                    case "GetDTType":
                        string str_sql = string.Format("select b.DT_type from tb_DeskType b,tb_Desk a where a.TypeId=b.Id and Id='{0}'", _entity.Id);
                        var result = ExecuteScalarString(str_sql);
                        return new List<tb_Desk> { new tb_Desk { TypeId = result } };
                    case "设置视图为详细信息":
                        return DBHelper.ReadCollection<tb_Desk>("select  a.Name,a.Id,a.DeskStatus,a.TypeId,b.Open_sj ,b.Open_Num ,b.Open_Waiter, b.Beizhu from tb_Desk a,tb_Open b where a.Id=b.Open_Name", null);
                }
            }
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_DeskTable.PrimaryKey.IsNotNull())
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
                if (_entity.TypeId.IsNotNull())
                {
                    str.AppendFormat(" AND TypeId='{0}'", _entity.TypeId);
                }
                if (_entity.ShopId.IsNotNull())
                {
                    str.AppendFormat(" AND ShopId='{0}'", _entity.ShopId);
                }
                if (_entity.Status.IsNotNull())
                {
                    str.AppendFormat(" AND Status='{0}'", _entity.Status);
                }
                if (_entity.DeskStatus.IsNotNull())
                {
                    str.AppendFormat(" AND DeskStatus='{0}'", _entity.DeskStatus);
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
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_DeskTable.Column, tb_DeskTable.Name, flage);
            return DBHelper.ReadCollection<tb_Desk>(Sql, null);
        }
        #endregion End Find
    }
}


