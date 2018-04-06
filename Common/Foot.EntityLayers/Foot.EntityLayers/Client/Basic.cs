using System;

namespace Foot.EntityLayers
{
    public class Basic
    {
        /// 字段描述:预定编号
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        /// 主键
        public string Id { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最近操作人
        /// </summary>
        public string LastOperationUserId { get; set; }

        /// <summary>
        /// 最近操作时间
        /// </summary>
        public DateTime LastOperationTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 店铺Id
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        public string ShopId { get; set; }
    }
}
