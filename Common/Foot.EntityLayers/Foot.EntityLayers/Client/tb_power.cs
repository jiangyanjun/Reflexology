using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_power 
    public partial class tb_power
    {
        #region Properties		

        /// 字段描述:编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// 主键
        public int power_ID { get; set; }

        /// 字段描述:权限类型
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        public int power_type { get; set; }

        /// 字段描述:权限名称
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string power_Name { get; set; }

        /// 字段描述:权限标识
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        public int pope { get; set; }

        #endregion Properties
    }
}
