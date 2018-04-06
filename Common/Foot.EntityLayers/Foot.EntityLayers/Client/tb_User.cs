using System;
using System.Collections.Generic;
using System.Text;

namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_User 
    public partial class tb_User: Basic
    {
        #region Properties		

        /// 字段描述:用户名称
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string User_Name { get; set; }

        /// 字段描述:用户密码
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string User_Pwd { get; set; }

        /// 字段描述:用户权限
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        public int power { get; set; }
        #endregion Properties
    }
}
