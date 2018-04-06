using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_warehouse 
    public partial class tb_warehouse
    {
        #region Properties		

        /// 字段描述:仓库编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// 主键
        public int CK_ID { get; set; }

        /// 字段描述:仓库名称
        /// 数据类型:string
        /// 数据长度:30
        /// 允许空值:False
        public string CK_Name { get; set; }

        #endregion Properties
    }
}
