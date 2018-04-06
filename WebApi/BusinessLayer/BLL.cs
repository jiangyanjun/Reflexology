// ***** Guidance generated code ? Catharsis ***** //
using Foot.WebApi.BusinessLayer;
using Foot.WebApi.DataLayers;
using Foot.EntityLayers;
using System.Collections.Generic;

namespace Kebue.Core.API.BusinessLayer
{

    #region OrderDetailedBLL	
    public partial class OrderDetailedBLL : BaseBLL<OrderDetailed>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new OrderDetailedDAL();
        }
    }
    #endregion End OrderDetailedBLL

    #region OrdersBLL	
    public partial class OrdersBLL : BaseBLL<Orders>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new OrdersDAL();
        }
    }
    #endregion End OrdersBLL

    #region ProductBLL	
    public partial class ProductBLL : BaseBLL<Product>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new ProductDAL();
        }
    }
    #endregion End ProductBLL

    #region ProductBLL	
    public partial class ProductTypeBLL : BaseBLL<ProductType>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new ProductTypeDAL();
        }
    }
    #endregion End ProductBLL

    #region tb_DeskBLL	
    public partial class tb_DeskBLL : BaseBLL<tb_Desk>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_DeskDAL();
        }
    }
    #endregion End tb_DeskBLL

    #region tb_DeskTypeBLL	
    public partial class tb_DeskTypeBLL : BaseBLL<tb_DeskType>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_DeskTypeDAL();
        }
    }
    #endregion End tb_DeskTypeBLL

    #region tb_DeskXSBLL	
    public partial class tb_DeskXSBLL : BaseBLL<tb_DeskXS>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_DeskXSDAL();
        }
    }
    #endregion End tb_DeskXSBLL

    #region tb_dutyBLL	
    public partial class tb_dutyBLL : BaseBLL<tb_duty>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_dutyDAL();
        }
    }
    #endregion End tb_dutyBLL

    #region tb_goodsBLL	
    public partial class tb_goodsBLL : BaseBLL<tb_goods>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_goodsDAL();
        }
    }
    #endregion End tb_goodsBLL

    #region tb_goodsCFBLL	
    public partial class tb_goodsCFBLL : BaseBLL<tb_goodsCF>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_goodsCFDAL();
        }
    }
    #endregion End tb_goodsCFBLL

    #region tb_goodsCGBLL	
    public partial class tb_goodsCGBLL : BaseBLL<tb_goodsCG>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_goodsCGDAL();
        }
    }
    #endregion End tb_goodsCGBLL

    #region tb_goodsMXBLL	
    public partial class tb_goodsMXBLL : BaseBLL<tb_goodsMX>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_goodsMXDAL();
        }
    }
    #endregion End tb_goodsMXBLL

    #region tb_memberBLL	
    public partial class tb_memberBLL : BaseBLL<tb_member>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_memberDAL();
        }
    }
    #endregion End tb_memberBLL

    #region tb_membertypeBLL	
    public partial class tb_membertypeBLL : BaseBLL<tb_membertype>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_membertypeDAL();
        }
    }
    #endregion End tb_membertypeBLL

    #region tb_memberXFBLL	
    public partial class tb_memberXFBLL : BaseBLL<tb_memberXF>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_memberXFDAL();
        }
    }
    #endregion End tb_memberXFBLL

    #region tb_OpenBLL	
    public partial class tb_OpenBLL : BaseBLL<tb_Open>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_OpenDAL();
        }
    }
    #endregion End tb_OpenBLL

    #region tb_powerBLL	
    public partial class tb_powerBLL : BaseBLL<tb_power>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_powerDAL();
        }
    }
    #endregion End tb_powerBLL

    #region tb_powertypeBLL	
    public partial class tb_powertypeBLL : BaseBLL<tb_powertype>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_powertypeDAL();
        }
    }
    #endregion End tb_powertypeBLL

    #region tb_qtxsBLL	
    public partial class tb_qtxsBLL : BaseBLL<tb_qtxs>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_qtxsDAL();
        }
    }
    #endregion End tb_qtxsBLL

    #region tb_UserBLL	
    public partial class tb_UserBLL : BaseBLL<tb_User>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_UserDAL();
        }
    }
    #endregion End tb_UserBLL

    #region tb_WaiterBLL	
    public partial class tb_WaiterBLL : BaseBLL<tb_Waiter>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_WaiterDAL();
        }
    }
    #endregion End tb_WaiterBLL

    #region tb_warehouseBLL	
    public partial class tb_warehouseBLL : BaseBLL<tb_warehouse>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_warehouseDAL();
        }
    }
    #endregion End tb_warehouseBLL

    #region tb_XFBLL	
    public partial class tb_XFBLL : BaseBLL<tb_XF>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_XFDAL();
        }
    }
    #endregion End tb_XFBLL

    #region tb_XFMXBLL	
    public partial class tb_XFMXBLL : BaseBLL<tb_XFMX>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_XFMXDAL();
        }
        public List<tb_XFMX> GetHotProducts(string Sql)
        {
            return new tb_XFMXDAL().GetHotProducts(Sql);
        }
    }
    #endregion End tb_XFMXBLL

    #region tb_BookedBLL	
    public partial class tb_BookedBLL : BaseBLL<tb_Booked>
    {
        public override void SetCurrentDAL()
        {
            base.CurrentDAL = new tb_BookedDAL();
        }
    }
    #endregion End tb_BookedBLL

}

