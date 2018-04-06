using Foot.EntityLayers;
using Kebue.Core.Util;
using System.Collections.Generic;
using System.Data;

namespace Foot.Proxy
{
    public class ClientServicesProxy : ProxyBase
    {
        public DataSet GetDataSet(string sql)
        {
            var p = new Dictionary<object, object>();
            p.Add("sql", sql);
            string res = http.Get(GetUrl(RequestEnum.ClientServices), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<DataSet>();
        }
        public string GetDTType(string desk_ID)
        {
            var p = new Dictionary<object, object>();
            p.Add("desk_ID", desk_ID);
            string res = http.Get(GetUrl(RequestEnum.tb_Desk), p).ReadAsStringAsync().Result;
            return res;
        }

        #region  OrderDetailed	
        public List<OrderDetailed> Find(OrderDetailed p)
        {
            string res = http.Get(GetUrl(RequestEnum.OrderDetailed), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<OrderDetailed>>();
        }
        public int Add(OrderDetailed p)
        {
            string res = http.Post(GetUrl(RequestEnum.OrderDetailed), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<OrderDetailed> p)
        {
            string res = http.Post(GetUrl(RequestEnum.OrderDetailed), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(OrderDetailed p)
        {
            string res = http.Put(GetUrl(RequestEnum.OrderDetailed), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(OrderDetailed p)
        {
            string res = http.Delete(GetUrl(RequestEnum.OrderDetailed), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  Orders	
        public List<Orders> Find(Orders p)
        {
            string res = http.Get(GetUrl(RequestEnum.Orders), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<Orders>>();
        }
        public int Add(Orders p)
        {
            string res = http.Post(GetUrl(RequestEnum.Orders), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<Orders> p)
        {
            string res = http.Post(GetUrl(RequestEnum.Orders), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(Orders p)
        {
            string res = http.Put(GetUrl(RequestEnum.Orders), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(Orders p)
        {
            string res = http.Delete(GetUrl(RequestEnum.Orders), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  ProductType	
        public List<ProductType> Find(ProductType p)
        {
            string res = http.Get(GetUrl(RequestEnum.ProductType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<ProductType>>();
        }
        public int Add(ProductType p)
        {
            string res = http.Post(GetUrl(RequestEnum.ProductType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<ProductType> p)
        {
            string res = http.Post(GetUrl(RequestEnum.ProductType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(ProductType p)
        {
            string res = http.Put(GetUrl(RequestEnum.ProductType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(ProductType p)
        {
            string res = http.Delete(GetUrl(RequestEnum.ProductType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  Product	
        public List<Product> Find(Product p)
        {
            string res = http.Get(GetUrl(RequestEnum.Product), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<Product>>();
        }
        public int Add(Product p)
        {
            string res = http.Post(GetUrl(RequestEnum.Product), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<Product> p)
        {
            string res = http.Post(GetUrl(RequestEnum.Product), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(Product p)
        {
            string res = http.Put(GetUrl(RequestEnum.Product), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(Product p)
        {
            string res = http.Delete(GetUrl(RequestEnum.Product), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_Desk	
        public List<tb_Desk> Find(tb_Desk p)
        {
            if (p.ShopId.IsNull())
                p.ShopId = App.CertificationUser.ShopId;
            if (p.Status.IsNull())
                p.Status = StatusEnum.True.ToString();
            string res = http.Get(GetUrl(RequestEnum.tb_Desk), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_Desk>>();
        }
        public int Add(tb_Desk p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Desk), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_Desk> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Desk), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_Desk p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_Desk), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_Desk p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_Desk), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_DeskType	
        public List<tb_DeskType> Find(tb_DeskType p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_DeskType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_DeskType>>();
        }
        public int Add(tb_DeskType p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_DeskType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_DeskType> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_DeskType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_DeskType p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_DeskType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_DeskType p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_DeskType), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_DeskXS	
        public List<tb_DeskXS> Find(tb_DeskXS p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_DeskXS), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_DeskXS>>();
        }
        public int Add(tb_DeskXS p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_DeskXS), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_DeskXS> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_DeskXS), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_DeskXS p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_DeskXS), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_DeskXS p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_DeskXS), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_duty	
        public List<tb_duty> Find(tb_duty p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_duty), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_duty>>();
        }
        public int Add(tb_duty p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_duty), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_duty> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_duty), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_duty p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_duty), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_duty p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_duty), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_goods	
        public List<tb_goods> Find(tb_goods p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_goods), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_goods>>();
        }
        public int Add(tb_goods p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goods), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_goods> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goods), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_goods p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_goods), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_goods p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_goods), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_goodsCF	
        public List<tb_goodsCF> Find(tb_goodsCF p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_goodsCF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_goodsCF>>();
        }
        public int Add(tb_goodsCF p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsCF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_goodsCF> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsCF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_goodsCF p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_goodsCF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_goodsCF p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_goodsCF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_goodsCG	
        public List<tb_goodsCG> Find(tb_goodsCG p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_goodsCG), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_goodsCG>>();
        }
        public int Add(tb_goodsCG p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsCG), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_goodsCG> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsCG), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_goodsCG p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_goodsCG), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_goodsCG p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_goodsCG), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_goodsMX	
        public List<tb_goodsMX> Find(tb_goodsMX p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_goodsMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_goodsMX>>();
        }
        public int Add(tb_goodsMX p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_goodsMX> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_goodsMX p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_goodsMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_goodsMX p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_goodsMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_member	
        public List<tb_member> Find(tb_member p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_member), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_member>>();
        }
        public int Add(tb_member p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_member), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_member> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_member), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_member p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_member), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_member p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_member), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_membertype	
        public List<tb_membertype> Find(tb_membertype p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_membertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_membertype>>();
        }
        public int Add(tb_membertype p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_membertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_membertype> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_membertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_membertype p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_membertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_membertype p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_membertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_memberXF	
        public List<tb_memberXF> Find(tb_memberXF p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_memberXF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_memberXF>>();
        }
        public int Add(tb_memberXF p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_memberXF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_memberXF> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_memberXF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_memberXF p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_memberXF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_memberXF p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_memberXF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_Open	
        public List<tb_Open> Find(tb_Open p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_Open), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_Open>>();
        }
        public int Add(tb_Open p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Open), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_Open> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Open), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_Open p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_Open), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_Open p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_Open), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_power	
        public List<tb_power> Find(tb_power p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_power), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_power>>();
        }
        public int Add(tb_power p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_power), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_power> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_power), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_power p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_power), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_power p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_power), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_powertype	
        public List<tb_powertype> Find(tb_powertype p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_powertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_powertype>>();
        }
        public int Add(tb_powertype p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_powertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_powertype> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_powertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_powertype p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_powertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_powertype p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_powertype), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_qtxs	
        public List<tb_qtxs> Find(tb_qtxs p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_qtxs), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_qtxs>>();
        }
        public int Add(tb_qtxs p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_qtxs), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_qtxs> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_qtxs), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_qtxs p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_qtxs), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_qtxs p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_qtxs), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_User	
        public List<tb_User> Find(tb_User p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_User), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_User>>();
        }
        public int Add(tb_User p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_User), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_User> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_User), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_User p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_User), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_User p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_User), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_Waiter	
        public List<tb_Waiter> Find(tb_Waiter p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_Waiter), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_Waiter>>();
        }
        public int Add(tb_Waiter p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Waiter), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_Waiter> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Waiter), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_Waiter p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_Waiter), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_Waiter p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_Waiter), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_warehouse	
        public List<tb_warehouse> Find(tb_warehouse p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_warehouse), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_warehouse>>();
        }
        public int Add(tb_warehouse p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_warehouse), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_warehouse> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_warehouse), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_warehouse p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_warehouse), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_warehouse p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_warehouse), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_XF	
        public List<tb_XF> Find(tb_XF p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_XF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_XF>>();
        }
        public int Add(tb_XF p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_XF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_XF> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_XF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_XF p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_XF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_XF p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_XF), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_XFMX	
        public List<tb_XFMX> Find(tb_XFMX p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_XFMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_XFMX>>();
        }
        public int Add(tb_XFMX p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_XFMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_XFMX> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_XFMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_XFMX p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_XFMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_XFMX p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_XFMX), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
        #region  tb_Booked	
        public List<tb_Booked> Find(tb_Booked p)
        {
            string res = http.Get(GetUrl(RequestEnum.tb_Booked), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<List<tb_Booked>>();
        }
        public int Add(tb_Booked p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Booked), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Add(List<tb_Booked> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Booked), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Update(tb_Booked p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_Booked), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        public int Delete(tb_Booked p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_Booked), p).ReadAsStringAsync().Result;
            return res.ToDeserialize<int>();
        }
        #endregion
    }
}

