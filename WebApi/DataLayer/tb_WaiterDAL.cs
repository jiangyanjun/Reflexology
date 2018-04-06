// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_WaiterDAL : DbBase<tb_Waiter>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_Waiter> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_WaiterTable.Name, tb_WaiterTable.Column, tb_WaiterTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_Waiter _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_WaiterTable.Name, tb_WaiterTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_Waiter _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_WaiterTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Waiter_ID.IsNotNull())
                {
                    str.Append("Waiter_ID=@Waiter_ID,");
                }
                if (_entity.Waiter_Nmae.IsNotNull())
                {
                    str.Append("Waiter_Nmae=@Waiter_Nmae,");
                }
                if (_entity.Waiter_Sex.IsNotNull())
                {
                    str.Append("Waiter_Sex=@Waiter_Sex,");
                }
                if (_entity.Waiter_Age.IsNotNull())
                {
                    str.Append("Waiter_Age=@Waiter_Age,");
                }
                if (_entity.Waiter_Phone.IsNotNull())
                {
                    str.Append("Waiter_Phone=@Waiter_Phone,");
                }
                if (_entity.Waiter_duty.IsNotNull())
                {
                    str.Append("Waiter_duty=@Waiter_duty,");
                }
                if (_entity.Waiter_pay.IsNotNull())
                {
                    str.Append("Waiter_pay=@Waiter_pay,");
                }
                if (_entity.Waiter_birthday.IsNotNull())
                {
                    str.Append("Waiter_birthday=@Waiter_birthday,");
                }
                if (_entity.Waiter_IDCard.IsNotNull())
                {
                    str.Append("Waiter_IDCard=@Waiter_IDCard,");
                }
                if (_entity.Waiter_Stime.IsNotNull())
                {
                    str.Append("Waiter_Stime=@Waiter_Stime,");
                }
                if (_entity.Waiter_Address.IsNotNull())
                {
                    str.Append("Waiter_Address=@Waiter_Address,");
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.Append("Beizhu=@Beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_WaiterTable.Name, upStr, string.Format("{0}=@{0}", tb_WaiterTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_Waiter> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_Waiter> Find(tb_Waiter _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_WaiterTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.Waiter_ID.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_ID='{0}'", _entity.Waiter_ID);
                }
                if (_entity.Waiter_Nmae.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_Nmae='{0}'", _entity.Waiter_Nmae);
                }
                if (_entity.Waiter_Sex.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_Sex='{0}'", _entity.Waiter_Sex);
                }
                if (_entity.Waiter_Age.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_Age='{0}'", _entity.Waiter_Age);
                }
                if (_entity.Waiter_Phone.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_Phone='{0}'", _entity.Waiter_Phone);
                }
                if (_entity.Waiter_duty.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_duty='{0}'", _entity.Waiter_duty);
                }
                if (_entity.Waiter_pay.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_pay='{0}'", _entity.Waiter_pay);
                }
                if (_entity.Waiter_birthday.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_birthday='{0}'", _entity.Waiter_birthday);
                }
                if (_entity.Waiter_IDCard.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_IDCard='{0}'", _entity.Waiter_IDCard);
                }
                if (_entity.Waiter_Stime.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_Stime='{0}'", _entity.Waiter_Stime);
                }
                if (_entity.Waiter_Address.IsNotNull())
                {
                    str.AppendFormat(" AND Waiter_Address='{0}'", _entity.Waiter_Address);
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND Beizhu='{0}'", _entity.Beizhu);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_WaiterTable.Column, tb_WaiterTable.Name, flage);
            return DBHelper.ReadCollection<tb_Waiter>(Sql, null);
        }
        #endregion End Find
    }
}


