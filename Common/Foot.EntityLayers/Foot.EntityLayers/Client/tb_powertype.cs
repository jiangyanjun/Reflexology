using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_powertype 
    public partial class tb_powertype
    {
        #region Properties		

        /// 字段描述:
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// 主键
        public int Pt_ID { get; set; }

        /// 字段描述:权限名称
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string Pt_Name { get; set; }

        #endregion Properties
    }
}
