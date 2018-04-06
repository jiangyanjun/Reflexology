using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_goodsCG 
    public partial class tb_goodsCG
    {
        #region Properties		

        /// 字段描述:进货编号
        /// 数据类型:string
        /// 数据长度:15
        /// 允许空值:False
        /// 主键
        public string CG_ID { get; set; }

        /// 字段描述:进货时间
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime CG_sj { get; set; }

        /// 字段描述:供货商
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string CG_ghs { get; set; }

        /// 字段描述:采购员
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string CG_buyer { get; set; }

        /// 字段描述:商品总金额
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string CG_Allprice { get; set; }

        /// 字段描述:备注
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string CG_beizhu { get; set; }

        #endregion Properties
    }
}
