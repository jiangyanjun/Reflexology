using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_Waiter 
    public partial class tb_Waiter
    {
        #region Properties		

        /// 字段描述:员工编号
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string Waiter_ID { get; set; }

        /// 字段描述:员工姓名
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string Waiter_Nmae { get; set; }

        /// 字段描述:性别
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string Waiter_Sex { get; set; }

        /// 字段描述:年龄
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string Waiter_Age { get; set; }

        /// 字段描述:员工电话
        /// 数据类型:string
        /// 数据长度:30
        /// 允许空值:True
        public string Waiter_Phone { get; set; }

        /// 字段描述:职务
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        public int Waiter_duty { get; set; }

        /// 字段描述:员工工资
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:True
        public string Waiter_pay { get; set; }

        /// 字段描述:员工生日
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime Waiter_birthday { get; set; }

        /// 字段描述:身份证号码
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string Waiter_IDCard { get; set; }

        /// 字段描述:上班时间
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime Waiter_Stime { get; set; }

        /// 字段描述:家庭住址
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string Waiter_Address { get; set; }

        /// 字段描述:备注
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string Beizhu { get; set; }

        #endregion Properties
    }
}
