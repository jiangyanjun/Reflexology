using System.ComponentModel;

namespace Foot.Proxy
{
    public enum RequestEnum
    {
        [Description("OrderDetailedController")]
        OrderDetailed,

        [Description("OrdersController")]
        Orders,

        [Description("ProductController")]
        Product,

        [Description("ProductTypeController")]
        ProductType,

        [Description("ClientServicesController")]
        ClientServices,

        [Description("tb_DeskController")]
        tb_Desk,

        [Description("tb_DeskTypeController")]
        tb_DeskType,

        [Description("tb_DeskXSController")]
        tb_DeskXS,

        [Description("tb_dutyController")]
        tb_duty,

        [Description("tb_goodsController")]
        tb_goods,

        [Description("tb_goodsCFController")]
        tb_goodsCF,

        [Description("tb_goodsCGController")]
        tb_goodsCG,

        [Description("tb_goodsMXController")]
        tb_goodsMX,

        [Description("tb_memberController")]
        tb_member,

        [Description("tb_membertypeController")]
        tb_membertype,

        [Description("tb_memberXFController")]
        tb_memberXF,

        [Description("tb_OpenController")]
        tb_Open,

        [Description("tb_powerController")]
        tb_power,

        [Description("tb_powertypeController")]
        tb_powertype,

        [Description("tb_qtxsController")]
        tb_qtxs,

        [Description("tb_UserController")]
        tb_User,

        [Description("tb_WaiterController")]
        tb_Waiter,

        [Description("tb_warehouseController")]
        tb_warehouse,

        [Description("tb_XFController")]
        tb_XF,

        [Description("tb_XFMXController")]
        tb_XFMX,

        [Description("tb_BookedController")]
        tb_Booked,

    }
}
