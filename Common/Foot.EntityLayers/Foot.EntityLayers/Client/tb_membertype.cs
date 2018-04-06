using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_membertype 
    public partial class tb_membertype
    {
        #region Properties		

        /// 字段描述:编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// 主键
        public int Mt_ID { get; set; }

        /// 字段描述:会员等级
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string Mt_Name { get; set; }

        /// 字段描述:初始积分
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string Mt_csjf { get; set; }

        /// 字段描述:折扣率
        /// 数据类型:double
        /// 数据长度:8
        /// 允许空值:False
        public double Mt_agio { get; set; }

        #endregion Properties
    }
}
