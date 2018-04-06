using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_member 
    public partial class tb_member
    {
        #region Properties		

        /// 字段描述:会员编号
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        /// 主键
        public string member_ID { get; set; }

        /// 字段描述:会员姓名
        /// 数据类型:string
        /// 数据长度:30
        /// 允许空值:False
        public string member_Name { get; set; }

        /// 字段描述:会员等级
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        public int Member_DJ { get; set; }

        /// 字段描述:性别
        /// 数据类型:string
        /// 数据长度:5
        /// 允许空值:False
        public string member_Sex { get; set; }

        /// 字段描述:会员生日
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime Member_birthday { get; set; }

        /// 字段描述:会员电话
        /// 数据类型:string
        /// 数据长度:15
        /// 允许空值:True
        public string Member_Phone { get; set; }

        /// 字段描述:会员登记日期
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime Member_DJRQ { get; set; }

        /// 字段描述:积分
        /// 数据类型:string
        /// 数据长度:25
        /// 允许空值:False
        public string Member_JF { get; set; }

        /// 字段描述:会员状态
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string Member_type { get; set; }

        /// 字段描述:身份证号码
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string member_IDCard { get; set; }

        /// 字段描述:备注
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string Beizhu { get; set; }

        #endregion Properties
    }
}
