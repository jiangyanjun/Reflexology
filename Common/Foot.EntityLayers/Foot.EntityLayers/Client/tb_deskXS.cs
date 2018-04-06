using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_DeskXS 
    public partial class tb_DeskXS
    {
        #region Properties		

        /// 字段描述:编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// 主键
        public int XS_ID { get; set; }

        /// 字段描述:桌台名称
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string XS_DeskName { get; set; }

        /// 字段描述:销售商品名称
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string XS_goodsName { get; set; }

        /// 字段描述:商品单价
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string XS_dj { get; set; }

        /// 字段描述:数量
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string XS_Sum { get; set; }

        /// 字段描述:销售商品价格
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:False
        public decimal XS_allprice { get; set; }

        /// 字段描述:消费时间
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime XS_sj { get; set; }

        /// 字段描述:
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string beizhu { get; set; }

        #endregion Properties
        /// 字段描述:服务员
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string Open_Waiter { get; set; }
    }
}
