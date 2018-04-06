using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_Open 
    public partial class tb_Open:Basic
    {
        #region Properties		


        /// 字段描述:桌台类型
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string TypeId { get; set; }

        /// 字段描述:桌台名称
        /// 数据类型:string
        /// 数据长度:20
        /// 允许空值:False
        public string DeskId { get; set; }

        /// <summary>
        /// 顾客人数
        /// </summary>
        public int CustomersNumber { get; set; }
        #endregion Properties
    }
}
