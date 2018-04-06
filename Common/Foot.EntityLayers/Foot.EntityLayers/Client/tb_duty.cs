using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_duty 
    public partial class tb_duty
    {
        #region Properties		

        /// 字段描述:编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// 主键
        public int Duty_ID { get; set; }

        /// 字段描述:职务名称
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string Duty_Name { get; set; }

        #endregion Properties
    }
}
