namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity Orders 
    public partial class Orders : Basic
    {
        #region Properties		

        /// <summary>
        /// 字段描述:
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        /// </summary>
        public string DeskId { get; set; }

        /// <summary>
        /// 字段描述:客户人数
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// </summary>
        public int CustomerNumber { get; set; }

        /// <summary>
        /// 字段描述:类型Id
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        /// 字段描述:会员Id
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 字段描述:流程状态
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// </summary>
        public string FlowStatus { get; set; }
        public string PackageId { get; set; }
        /// <summary>
        /// 字段描述:总额
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:True
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// 字段描述:免费金额
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:True
        /// </summary>
        public decimal? FreeAmount { get; set; }

        /// <summary>
        /// 字段描述:支付金额
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:True
        /// </summary>
        public decimal? PaymentAmount { get; set; }

        public string CustomerName { get; set; }

        public string TelePhone { get; set; }

        #endregion Properties
    }
}
