using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity ProductType 
    public partial class ProductType:Basic
    {
        #region Properties		
        /// <summary>
        /// 字段描述:
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        /// </summary>
        public string Name { get; set; }
    #endregion Properties
}
}
