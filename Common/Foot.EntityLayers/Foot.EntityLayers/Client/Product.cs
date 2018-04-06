namespace Foot.EntityLayers
{
    /// <summary>
    /// Entity Product 
    public partial class Product:Basic
    {
        #region Properties		

        /// <summary>
        /// 字段描述:
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        /// </summary>
        public string ProductTypeId { get; set; }

        /// <summary>
        /// 字段描述:
        /// 数据类型:string
        /// 数据长度:50
        /// 允许空值:True
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 字段描述:成本价格
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:True
        /// </summary>
        public decimal? CostPrice { get; set; }

        /// <summary>
        /// 字段描述:对外销售价格
        /// 数据类型:decimal
        /// 数据长度:9
        /// 允许空值:True
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// 字段描述:总库存
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:True
        /// </summary>
        public int? StockQuantity { get; set; }

        /// <summary>
        /// 字段描述:剩余库存量
        /// 数据类型:int
        /// 数据长度:4
        /// 允许空值:True
        /// </summary>
        public int? Inventory { get; set; }
        public string QRode { get; set; }

        #endregion Properties
    }
}
