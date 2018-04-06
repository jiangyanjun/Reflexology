using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_XF 
    public partial class tb_XF
    {
        #region Properties		

        /// 字段描述:账单号
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        /// 主键
        public string XF_ID { get; set; }

        /// 字段描述:桌台号
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string XF_desk { get; set; }

        /// 字段描述:应收金额
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string XF_Ymoney { get; set; }

        /// 字段描述:折扣率
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string XF_ZK { get; set; }

        /// 字段描述:实收金额
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string XF_Smoney { get; set; }

        /// 字段描述:消费时间
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime XF_sj { get; set; }

        /// 字段描述:服务员
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string XF_waiter { get; set; }

        /// 字段描述:备注
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string beizhu { get; set; }

        #endregion Properties
    }
}
