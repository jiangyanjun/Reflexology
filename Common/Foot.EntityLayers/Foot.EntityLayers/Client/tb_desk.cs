// ***** Guidance generated code 版权所有：姜言俊 ***** //
using System;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_Desk 
    public partial class tb_Desk: Basic
    {
        #region Properties		

        /// 字段描述:桌台名称
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string Name { get; set; }

        /// 字段描述:桌台类型
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string TypeId { get; set; }

        /// 字段描述:桌台状态
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string DeskStatus { get; set; }


        /// 字段描述:服务员
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string Open_Waiter { get; set; }

        /// 字段描述:开单时间
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime Open_sj { get; set; }

        /// <summary>
        /// 字段描述:顾客人数
        /// 数据类型:string
        /// 数据长度:10
        /// 允许空值:False
        /// </summary>
        public string Open_Num { get; set; }

        #endregion Properties
    }
   
}

