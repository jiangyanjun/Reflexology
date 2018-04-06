namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity OrderDetailed 
    public partial class OrderDetailed: Basic
    {
        #region Properties		
        /// <summary>
        /// 字段描述:订单Id
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        /// </summary>
        public string IId { get; set; }

        /// <summary>
        /// 字段描述:商品Id
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:False
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 字段描述:商品价格
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:False
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 字段描述:商品数量
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:False
        /// </summary>
        public int Quantity { get; set; }
        #endregion Properties
    }
}
