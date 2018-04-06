using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_qtxs 
    public partial class tb_qtxs
    {
        #region Properties		

        /// 字段描述:编号
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string QT_ID { get; set; }

        /// 字段描述:MX_Goods
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string QT_Goods { get; set; }

        /// 字段描述:消费商品类别
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string QT_goodstype { get; set; }

        /// 字段描述:消费 单价
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string QT_dj { get; set; }

        /// 字段描述:消费商品数量
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string QT_Num { get; set; }

        /// 字段描述:消费商品总价
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:False
        public decimal QT_Allprice { get; set; }

        /// 字段描述:备注
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string Beizhu { get; set; }

        #endregion Properties
    }
}
