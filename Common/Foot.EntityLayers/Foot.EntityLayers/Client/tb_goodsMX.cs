using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_goodsMX 
    public partial class tb_goodsMX
    {
        #region Properties		

        /// 字段描述:编号
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// 主键
        public int MX_ID { get; set; }

        /// 字段描述:进货编号
        /// 数据类型:string
        /// 数据长度:15
        /// 允许空值:False
        public string MX_CGID { get; set; }

        /// 字段描述:  商品名称
        /// 数据类型:string
        /// 数据长度:30
        /// 允许空值:False
        public string MX_name { get; set; }

        /// 字段描述:商品类型
        /// 数据类型:string
        /// 数据长度:30
        /// 允许空值:False
        public string Goods_type { get; set; }

        /// 字段描述:进价
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string MX_price { get; set; }

        /// 字段描述:数量
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string MX_num { get; set; }

        /// 字段描述:金额
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string MX_allprice { get; set; }

        /// 字段描述:备注
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string MX_beizhu { get; set; }

        #endregion Properties
    }
}
