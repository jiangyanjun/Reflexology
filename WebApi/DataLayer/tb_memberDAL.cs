// ***** Guidance generated code 版权所有：姜言俊 ***** //
using Foot.EntityLayers;
using Kebue.Core.Database;
using Kebue.Core.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.WebApi.DataLayers
{

    public class tb_memberDAL : DbBase<tb_member>
    {
        #region Add	新增	
        public override int Add(IEnumerable<tb_member> _entity)
        {
            string Sql = string.Format(DbSqlFormat.InsertForm, tb_memberTable.Name, tb_memberTable.Column, tb_memberTable._ColumnN);
            return DBHelper.SaveCollection(Sql, _entity);
        }
        #endregion End Add

        #region Delete	按主键删除	
        public override int Delete(tb_member _entity)
        {
            string Sql = string.Format(DbSqlFormat.DeleteForm, tb_memberTable.Name, tb_memberTable.PrimaryKey);
            return DBHelper.ExcuteSQL(Sql, null);
        }
        #endregion End Delete

        #region Update 按主键更新			
        public override int Update(tb_member _entity)
        {
            StringBuilder str = new StringBuilder();
            if (_entity.IsNotNull() && tb_memberTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.member_ID.IsNotNull())
                {
                    str.Append("member_ID=@member_ID,");
                }
                if (_entity.member_Name.IsNotNull())
                {
                    str.Append("member_Name=@member_Name,");
                }
                if (_entity.Member_DJ.IsNotNull())
                {
                    str.Append("Member_DJ=@Member_DJ,");
                }
                if (_entity.member_Sex.IsNotNull())
                {
                    str.Append("member_Sex=@member_Sex,");
                }
                if (_entity.Member_birthday.IsNotNull())
                {
                    str.Append("Member_birthday=@Member_birthday,");
                }
                if (_entity.Member_Phone.IsNotNull())
                {
                    str.Append("Member_Phone=@Member_Phone,");
                }
                if (_entity.Member_DJRQ.IsNotNull())
                {
                    str.Append("Member_DJRQ=@Member_DJRQ,");
                }
                if (_entity.Member_JF.IsNotNull())
                {
                    str.Append("Member_JF=@Member_JF,");
                }
                if (_entity.Member_type.IsNotNull())
                {
                    str.Append("Member_type=@Member_type,");
                }
                if (_entity.member_IDCard.IsNotNull())
                {
                    str.Append("member_IDCard=@member_IDCard,");
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.Append("Beizhu=@Beizhu,");
                }
                #endregion
                var upStr = str.ToString();
                upStr = upStr.Substring(0, upStr.Length - 1);
                string Sql = String.Format(DbSqlFormat.UpdateForm, tb_memberTable.Name, upStr, string.Format("{0}=@{0}", tb_memberTable.PrimaryKey));
                return DBHelper.SaveCollection(Sql, new List<tb_member> { _entity });
            }
            else
            {
                throw new Exception("修改主键不可为NULL");
            }
        }
        #endregion End Update	

        #region Find 按主键查询		
        public override List<tb_member> Find(tb_member _entity)
        {
            StringBuilder str = new StringBuilder();
            string flage = string.Empty;
            if (_entity.IsNotNull() && tb_memberTable.PrimaryKey.IsNotNull())
            {
                #region 拼接sql
                if (_entity.member_ID.IsNotNull())
                {
                    str.AppendFormat(" AND member_ID='{0}'", _entity.member_ID);
                }
                if (_entity.member_Name.IsNotNull())
                {
                    str.AppendFormat(" AND member_Name='{0}'", _entity.member_Name);
                }
                if (_entity.Member_DJ.IsNotNull())
                {
                    str.AppendFormat(" AND Member_DJ='{0}'", _entity.Member_DJ);
                }
                if (_entity.member_Sex.IsNotNull())
                {
                    str.AppendFormat(" AND member_Sex='{0}'", _entity.member_Sex);
                }
                if (_entity.Member_birthday.IsNotNull())
                {
                    str.AppendFormat(" AND Member_birthday='{0}'", _entity.Member_birthday);
                }
                if (_entity.Member_Phone.IsNotNull())
                {
                    str.AppendFormat(" AND Member_Phone='{0}'", _entity.Member_Phone);
                }
                if (_entity.Member_DJRQ.IsNotNull())
                {
                    str.AppendFormat(" AND Member_DJRQ='{0}'", _entity.Member_DJRQ);
                }
                if (_entity.Member_JF.IsNotNull())
                {
                    str.AppendFormat(" AND Member_JF='{0}'", _entity.Member_JF);
                }
                if (_entity.Member_type.IsNotNull())
                {
                    str.AppendFormat(" AND Member_type='{0}'", _entity.Member_type);
                }
                if (_entity.member_IDCard.IsNotNull())
                {
                    str.AppendFormat(" AND member_IDCard='{0}'", _entity.member_IDCard);
                }
                if (_entity.Beizhu.IsNotNull())
                {
                    str.AppendFormat(" AND Beizhu='{0}'", _entity.Beizhu);
                }
                #endregion
                flage = str.ToString();
                //flage = flage.Substring(0, flage.Length - 1);
            }
            string Sql = string.Format(DbSqlFormat.SelectForm, tb_memberTable.Column, tb_memberTable.Name, flage);
            return DBHelper.ReadCollection<tb_member>(Sql, null);
        }
        #endregion End Find
    }
}


