using Foot.EntityLayers;
using Kebue.Core.API.BusinessLayer;
using Kebue.Core.Util;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Foot.WebApi.Areas.Client.Controllers
{
    #region ClientServices
    [Route("api/[controller]")]
    public class ClientServicesController : Controller
    {
        [HttpGet]
        public string Get(string sql)
        {
            var result = new tb_DeskBLL().GetDataSet(sql, null);
            return result.ToSerialize();
        }
        [HttpPost]
        public string GetDTType([FromBody]string desk_ID)
        {
            string str_sql = "select b.DT_type from tb_DeskType b,tb_Desk a where a.TypeId=b.Id and Id='" + desk_ID + "'";
            var result = new tb_DeskBLL().ExecuteScalarString(str_sql);
            return result.ToSerialize();
        }
    }
    #endregion

    #region  OrderDetailed	

    [Route("api/[controller]")]
    public class OrderDetailedController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<OrderDetailed> Get(OrderDetailed parameter)
        {
            OrderDetailedBLL bll = new OrderDetailedBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]OrderDetailed parameter)
        {
            OrderDetailedBLL bll = new OrderDetailedBLL();
            return bll.Add(parameter);
        }
        //[HttpPost]
        //public int Post([FromBody]List<OrderDetailed> parameter)
        //{
        //    OrderDetailedBLL bll = new OrderDetailedBLL();
        //    return bll.Add(parameter);
        //}
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]OrderDetailed parameter)
        {
            OrderDetailedBLL bll = new OrderDetailedBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(OrderDetailed parameter)
        {
            OrderDetailedBLL bll = new OrderDetailedBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  Orders	

    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<Orders> Get(Orders parameter)
        {
            OrdersBLL bll = new OrdersBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]Orders parameter)
        {
            OrdersBLL bll = new OrdersBLL();
            return bll.Add(parameter);
        }
        //[HttpPost]
        //public int Post([FromBody]Orders parameter)
        //{
        //    OrdersBLL bll = new OrdersBLL();
        //    return bll.Add(parameter);
        //}
        //[HttpPost]
        //public int Post([FromBody]List<Orders> parameter)
        //{
        //    OrdersBLL bll = new OrdersBLL();
        //    return bll.Add(parameter);
        //}
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]Orders parameter)
        {
            OrdersBLL bll = new OrdersBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(Orders parameter)
        {
            OrdersBLL bll = new OrdersBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  Product	

    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<Product> Get(Product parameter)
        {
            ProductBLL bll = new ProductBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]Product parameter)
        {
            ProductBLL bll = new ProductBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]Product parameter)
        {
            ProductBLL bll = new ProductBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(Product parameter)
        {
            ProductBLL bll = new ProductBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  ProductType	

    [Route("api/[controller]")]
    public class ProductTypeController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<ProductType> Get(ProductType parameter)
        {
            ProductTypeBLL bll = new ProductTypeBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]ProductType parameter)
        {
            ProductTypeBLL bll = new ProductTypeBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]ProductType parameter)
        {
            ProductTypeBLL bll = new ProductTypeBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(ProductType parameter)
        {
            ProductTypeBLL bll = new ProductTypeBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_Desk	

    [Route("api/[controller]")]
    public class tb_DeskController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_Desk> Get(tb_Desk parameter)
        {
            tb_DeskBLL bll = new tb_DeskBLL();
            return bll.Find(parameter);
        }

        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_Desk parameter)
        {
            tb_DeskBLL bll = new tb_DeskBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_Desk> parameter)
        {
            tb_DeskBLL bll = new tb_DeskBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_Desk parameter)
        {
            tb_DeskBLL bll = new tb_DeskBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_Desk parameter)
        {
            tb_DeskBLL bll = new tb_DeskBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_DeskType	

    [Route("api/[controller]")]
    public class tb_DeskTypeController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_DeskType> Get(tb_DeskType parameter)
        {
            tb_DeskTypeBLL bll = new tb_DeskTypeBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_DeskType parameter)
        {
            tb_DeskTypeBLL bll = new tb_DeskTypeBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_DeskType> parameter)
        {
            tb_DeskTypeBLL bll = new tb_DeskTypeBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_DeskType parameter)
        {
            tb_DeskTypeBLL bll = new tb_DeskTypeBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_DeskType parameter)
        {
            tb_DeskTypeBLL bll = new tb_DeskTypeBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_DeskXS	

    [Route("api/[controller]")]
    public class tb_DeskXSController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_DeskXS> Get(tb_DeskXS parameter)
        {
            tb_DeskXSBLL bll = new tb_DeskXSBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_DeskXS parameter)
        {
            tb_DeskXSBLL bll = new tb_DeskXSBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_DeskXS> parameter)
        {
            tb_DeskXSBLL bll = new tb_DeskXSBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_DeskXS parameter)
        {
            tb_DeskXSBLL bll = new tb_DeskXSBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_DeskXS parameter)
        {
            tb_DeskXSBLL bll = new tb_DeskXSBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_duty	

    [Route("api/[controller]")]
    public class tb_dutyController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_duty> Get(tb_duty parameter)
        {
            tb_dutyBLL bll = new tb_dutyBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_duty parameter)
        {
            tb_dutyBLL bll = new tb_dutyBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_duty> parameter)
        {
            tb_dutyBLL bll = new tb_dutyBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_duty parameter)
        {
            tb_dutyBLL bll = new tb_dutyBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_duty parameter)
        {
            tb_dutyBLL bll = new tb_dutyBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_goods	

    [Route("api/[controller]")]
    public class tb_goodsController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_goods> Get(tb_goods parameter)
        {
            tb_goodsBLL bll = new tb_goodsBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_goods parameter)
        {
            tb_goodsBLL bll = new tb_goodsBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_goods> parameter)
        {
            tb_goodsBLL bll = new tb_goodsBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_goods parameter)
        {
            tb_goodsBLL bll = new tb_goodsBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_goods parameter)
        {
            tb_goodsBLL bll = new tb_goodsBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_goodsCF	

    [Route("api/[controller]")]
    public class tb_goodsCFController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_goodsCF> Get(tb_goodsCF parameter)
        {
            tb_goodsCFBLL bll = new tb_goodsCFBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_goodsCF parameter)
        {
            tb_goodsCFBLL bll = new tb_goodsCFBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_goodsCF> parameter)
        {
            tb_goodsCFBLL bll = new tb_goodsCFBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_goodsCF parameter)
        {
            tb_goodsCFBLL bll = new tb_goodsCFBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_goodsCF parameter)
        {
            tb_goodsCFBLL bll = new tb_goodsCFBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_goodsCG	

    [Route("api/[controller]")]
    public class tb_goodsCGController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_goodsCG> Get(tb_goodsCG parameter)
        {
            tb_goodsCGBLL bll = new tb_goodsCGBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_goodsCG parameter)
        {
            tb_goodsCGBLL bll = new tb_goodsCGBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_goodsCG> parameter)
        {
            tb_goodsCGBLL bll = new tb_goodsCGBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_goodsCG parameter)
        {
            tb_goodsCGBLL bll = new tb_goodsCGBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_goodsCG parameter)
        {
            tb_goodsCGBLL bll = new tb_goodsCGBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_goodsMX	

    [Route("api/[controller]")]
    public class tb_goodsMXController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_goodsMX> Get(tb_goodsMX parameter)
        {
            tb_goodsMXBLL bll = new tb_goodsMXBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_goodsMX parameter)
        {
            tb_goodsMXBLL bll = new tb_goodsMXBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_goodsMX> parameter)
        {
            tb_goodsMXBLL bll = new tb_goodsMXBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_goodsMX parameter)
        {
            tb_goodsMXBLL bll = new tb_goodsMXBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_goodsMX parameter)
        {
            tb_goodsMXBLL bll = new tb_goodsMXBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_member	

    [Route("api/[controller]")]
    public class tb_memberController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_member> Get(tb_member parameter)
        {
            tb_memberBLL bll = new tb_memberBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_member parameter)
        {
            tb_memberBLL bll = new tb_memberBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_member> parameter)
        {
            tb_memberBLL bll = new tb_memberBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_member parameter)
        {
            tb_memberBLL bll = new tb_memberBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_member parameter)
        {
            tb_memberBLL bll = new tb_memberBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_membertype	

    [Route("api/[controller]")]
    public class tb_membertypeController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_membertype> Get(tb_membertype parameter)
        {
            tb_membertypeBLL bll = new tb_membertypeBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_membertype parameter)
        {
            tb_membertypeBLL bll = new tb_membertypeBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_membertype> parameter)
        {
            tb_membertypeBLL bll = new tb_membertypeBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_membertype parameter)
        {
            tb_membertypeBLL bll = new tb_membertypeBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_membertype parameter)
        {
            tb_membertypeBLL bll = new tb_membertypeBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_memberXF	

    [Route("api/[controller]")]
    public class tb_memberXFController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_memberXF> Get(tb_memberXF parameter)
        {
            tb_memberXFBLL bll = new tb_memberXFBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_memberXF parameter)
        {
            tb_memberXFBLL bll = new tb_memberXFBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_memberXF> parameter)
        {
            tb_memberXFBLL bll = new tb_memberXFBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_memberXF parameter)
        {
            tb_memberXFBLL bll = new tb_memberXFBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_memberXF parameter)
        {
            tb_memberXFBLL bll = new tb_memberXFBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_Open	

    [Route("api/[controller]")]
    public class tb_OpenController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_Open> Get(tb_Open parameter)
        {
            tb_OpenBLL bll = new tb_OpenBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_Open parameter)
        {
            tb_OpenBLL bll = new tb_OpenBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_Open> parameter)
        {
            tb_OpenBLL bll = new tb_OpenBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_Open parameter)
        {
            tb_OpenBLL bll = new tb_OpenBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_Open parameter)
        {
            tb_OpenBLL bll = new tb_OpenBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_power	

    [Route("api/[controller]")]
    public class tb_powerController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_power> Get(tb_power parameter)
        {
            tb_powerBLL bll = new tb_powerBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_power parameter)
        {
            tb_powerBLL bll = new tb_powerBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_power> parameter)
        {
            tb_powerBLL bll = new tb_powerBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_power parameter)
        {
            tb_powerBLL bll = new tb_powerBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_power parameter)
        {
            tb_powerBLL bll = new tb_powerBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_powertype	

    [Route("api/[controller]")]
    public class tb_powertypeController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_powertype> Get(tb_powertype parameter)
        {
            tb_powertypeBLL bll = new tb_powertypeBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_powertype parameter)
        {
            tb_powertypeBLL bll = new tb_powertypeBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_powertype> parameter)
        {
            tb_powertypeBLL bll = new tb_powertypeBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_powertype parameter)
        {
            tb_powertypeBLL bll = new tb_powertypeBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_powertype parameter)
        {
            tb_powertypeBLL bll = new tb_powertypeBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_qtxs	

    [Route("api/[controller]")]
    public class tb_qtxsController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_qtxs> Get(tb_qtxs parameter)
        {
            tb_qtxsBLL bll = new tb_qtxsBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_qtxs parameter)
        {
            tb_qtxsBLL bll = new tb_qtxsBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_qtxs> parameter)
        {
            tb_qtxsBLL bll = new tb_qtxsBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_qtxs parameter)
        {
            tb_qtxsBLL bll = new tb_qtxsBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_qtxs parameter)
        {
            tb_qtxsBLL bll = new tb_qtxsBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_User	

    [Route("api/[controller]")]
    public class tb_UserController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_User> Get(tb_User parameter)
        {
            tb_UserBLL bll = new tb_UserBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_User parameter)
        {
            tb_UserBLL bll = new tb_UserBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_User> parameter)
        {
            tb_UserBLL bll = new tb_UserBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_User parameter)
        {
            tb_UserBLL bll = new tb_UserBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_User parameter)
        {
            tb_UserBLL bll = new tb_UserBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_Waiter	

    [Route("api/[controller]")]
    public class tb_WaiterController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_Waiter> Get(tb_Waiter parameter)
        {
            tb_WaiterBLL bll = new tb_WaiterBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_Waiter parameter)
        {
            tb_WaiterBLL bll = new tb_WaiterBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_Waiter> parameter)
        {
            tb_WaiterBLL bll = new tb_WaiterBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_Waiter parameter)
        {
            tb_WaiterBLL bll = new tb_WaiterBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_Waiter parameter)
        {
            tb_WaiterBLL bll = new tb_WaiterBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_warehouse	

    [Route("api/[controller]")]
    public class tb_warehouseController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_warehouse> Get(tb_warehouse parameter)
        {
            tb_warehouseBLL bll = new tb_warehouseBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_warehouse parameter)
        {
            tb_warehouseBLL bll = new tb_warehouseBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_warehouse> parameter)
        {
            tb_warehouseBLL bll = new tb_warehouseBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_warehouse parameter)
        {
            tb_warehouseBLL bll = new tb_warehouseBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_warehouse parameter)
        {
            tb_warehouseBLL bll = new tb_warehouseBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_XF	

    [Route("api/[controller]")]
    public class tb_XFController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_XF> Get(tb_XF parameter)
        {
            tb_XFBLL bll = new tb_XFBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_XF parameter)
        {
            tb_XFBLL bll = new tb_XFBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_XF> parameter)
        {
            tb_XFBLL bll = new tb_XFBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_XF parameter)
        {
            tb_XFBLL bll = new tb_XFBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_XF parameter)
        {
            tb_XFBLL bll = new tb_XFBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_XFMX	

    [Route("api/[controller]")]
    public class tb_XFMXController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_XFMX> Get(tb_XFMX parameter)
        {
            tb_XFMXBLL bll = new tb_XFMXBLL();
            if (parameter.IsNotNull() && parameter.Beizhu.IsNotNull())
            {
                switch (parameter.Beizhu)
                {
                    case "GetHotProducts":
                        string str_sql = "select top 3 count(*) as a,MX_Goods from tb_xfmx group by MX_Goods order by a desc";
                        return bll.GetHotProducts(str_sql);
                }
            }
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_XFMX parameter)
        {
            tb_XFMXBLL bll = new tb_XFMXBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_XFMX> parameter)
        {
            tb_XFMXBLL bll = new tb_XFMXBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_XFMX parameter)
        {
            tb_XFMXBLL bll = new tb_XFMXBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_XFMX parameter)
        {
            tb_XFMXBLL bll = new tb_XFMXBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion

    #region  tb_Booked	

    [Route("api/[controller]")]
    public class tb_BookedController : Controller
    {
        #region HttpGet
        [HttpGet]
        public IEnumerable<tb_Booked> Get(tb_Booked parameter)
        {
            tb_BookedBLL bll = new tb_BookedBLL();
            return bll.Find(parameter);
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public int Post([FromBody]tb_Booked parameter)
        {
            tb_BookedBLL bll = new tb_BookedBLL();
            return bll.Add(parameter);
        }
        [HttpPost]
        public int Post([FromBody]List<tb_Booked> parameter)
        {
            tb_BookedBLL bll = new tb_BookedBLL();
            return bll.Add(parameter);
        }
        #endregion

        #region HttpPut
        [HttpPut]
        public int Put([FromBody]tb_Booked parameter)
        {
            tb_BookedBLL bll = new tb_BookedBLL();
            return bll.Update(parameter);
        }
        #endregion

        #region HttpDelete
        [HttpDelete]
        public int Delete(tb_Booked parameter)
        {
            tb_BookedBLL bll = new tb_BookedBLL();
            return bll.Delete(parameter);
        }
        #endregion
    }
    #endregion
}

