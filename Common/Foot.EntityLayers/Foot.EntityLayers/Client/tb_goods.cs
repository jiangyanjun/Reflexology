using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_goods 
    public partial class tb_goods
    {
        #region Properties		

        /// 字段描述:商品编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// 主键
        public int goods_ID { get; set; }

        /// 字段描述:商品名称
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string goods_Name { get; set; }

        /// 字段描述:商品类型
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string Goods_type { get; set; }

        /// 字段描述:商品销售单价
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string Goods_Xsprice { get; set; }

        /// 字段描述:商品库存量
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string Goods_num { get; set; }

        /// 字段描述:进货数量
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string Goods_Jhnum { get; set; }

        /// 字段描述:商品进货单价
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string Goods_Jhprice { get; set; }

        /// 字段描述:商品总金额
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:False
        public decimal Goods_allprice { get; set; }

        /// 字段描述:商品存放仓库
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        public int Goods_CKID { get; set; }

        /// 字段描述:备注
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string Beizhu { get; set; }

        #endregion Properties
    }
}
