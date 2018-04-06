using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_memberXF 
    public partial class tb_memberXF
    {
        #region Properties		

        /// 字段描述:会员编号
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string HY_ID { get; set; }

        /// 字段描述:会员姓名
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string HY_Name { get; set; }

        /// 字段描述:账单号
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        /// 主键
        public string YH_Zdh { get; set; }

        /// 字段描述:桌台号
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        public string YH_desk { get; set; }

        /// 字段描述:消费金额
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:False
        public decimal YH_money { get; set; }

        /// 字段描述:消费时间
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime YH_sj { get; set; }

        /// 字段描述:备注
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string Beizhu { get; set; }

        #endregion Properties
    }
}
