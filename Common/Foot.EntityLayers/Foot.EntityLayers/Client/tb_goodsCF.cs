using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_goodsCF 
    public partial class tb_goodsCF
    {
        #region Properties		

        /// 字段描述:编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// 主键
        public int ID { get; set; }

        /// 字段描述:仓库编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        public int CF_ID { get; set; }

        /// 字段描述:商品编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        public int CF_GoodsID { get; set; }

        #endregion Properties
    }
}
