// ***** Guidance generated code ? Catharsis ***** //
using System;



namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity tb_Booked 
    public partial class tb_Booked: Basic
    {
        #region Properties		
        /// 字段描述:预定顾客姓名
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string GuestName { get; set; }

        /// 字段描述:预定顾客电话
        /// 数据类型:string
        /// 数据长度:15
        /// 允许空值:False
        public string GuestTelePhone { get; set; }

        /// 字段描述:预定桌台类型编号
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string BookedDeskTypeId { get; set; }

        /// 字段描述:预定桌台编号
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        public string BookedDeskId { get; set; }

        /// 字段描述:预定时间
        /// 数据类型:DateTime
        /// 数据长度:8
        /// 允许空值:False
        public DateTime BookedDateTime { get; set; }

        #endregion Properties
    }
}

