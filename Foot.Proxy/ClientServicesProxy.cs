using Foot.WebApi.EntityLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kebue.Core.Util;

namespace Foot.Proxy
{
    public class ClientServicesProxy : ProxyBase
    {
        #region  tb_desk	
        public List<tb_desk> Find(tb_desk p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_desk)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_desk>>();
        }
        public int Add(tb_desk p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_desk), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_desk> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_desk), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_desk p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_desk), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_desk p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_desk), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_deskType	
        public List<tb_deskType> Find(tb_deskType p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_deskType)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_deskType>>();
        }
        public int Add(tb_deskType p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_deskType), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_deskType> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_deskType), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_deskType p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_deskType), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_deskType p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_deskType), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_deskXS	
        public List<tb_deskXS> Find(tb_deskXS p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_deskXS)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_deskXS>>();
        }
        public int Add(tb_deskXS p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_deskXS), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_deskXS> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_deskXS), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_deskXS p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_deskXS), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_deskXS p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_deskXS), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_duty	
        public List<tb_duty> Find(tb_duty p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_duty)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_duty>>();
        }
        public int Add(tb_duty p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_duty), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_duty> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_duty), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_duty p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_duty), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_duty p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_duty), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_goods	
        public List<tb_goods> Find(tb_goods p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_goods)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_goods>>();
        }
        public int Add(tb_goods p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goods), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_goods> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goods), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_goods p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_goods), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_goods p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_goods), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_goodsCF	
        public List<tb_goodsCF> Find(tb_goodsCF p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_goodsCF)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_goodsCF>>();
        }
        public int Add(tb_goodsCF p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsCF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_goodsCF> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsCF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_goodsCF p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_goodsCF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_goodsCF p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_goodsCF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_goodsCG	
        public List<tb_goodsCG> Find(tb_goodsCG p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_goodsCG)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_goodsCG>>();
        }
        public int Add(tb_goodsCG p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsCG), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_goodsCG> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsCG), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_goodsCG p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_goodsCG), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_goodsCG p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_goodsCG), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_goodsMX	
        public List<tb_goodsMX> Find(tb_goodsMX p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_goodsMX)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_goodsMX>>();
        }
        public int Add(tb_goodsMX p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsMX), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_goodsMX> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_goodsMX), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_goodsMX p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_goodsMX), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_goodsMX p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_goodsMX), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_member	
        public List<tb_member> Find(tb_member p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_member)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_member>>();
        }
        public int Add(tb_member p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_member), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_member> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_member), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_member p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_member), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_member p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_member), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_membertype	
        public List<tb_membertype> Find(tb_membertype p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_membertype)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_membertype>>();
        }
        public int Add(tb_membertype p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_membertype), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_membertype> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_membertype), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_membertype p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_membertype), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_membertype p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_membertype), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_memberXF	
        public List<tb_memberXF> Find(tb_memberXF p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_memberXF)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_memberXF>>();
        }
        public int Add(tb_memberXF p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_memberXF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_memberXF> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_memberXF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_memberXF p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_memberXF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_memberXF p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_memberXF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_Open	
        public List<tb_Open> Find(tb_Open p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_Open)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_Open>>();
        }
        public int Add(tb_Open p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Open), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_Open> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Open), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_Open p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_Open), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_Open p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_Open), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_power	
        public List<tb_power> Find(tb_power p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_power)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_power>>();
        }
        public int Add(tb_power p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_power), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_power> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_power), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_power p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_power), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_power p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_power), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_powertype	
        public List<tb_powertype> Find(tb_powertype p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_powertype)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_powertype>>();
        }
        public int Add(tb_powertype p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_powertype), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_powertype> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_powertype), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_powertype p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_powertype), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_powertype p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_powertype), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_qtxs	
        public List<tb_qtxs> Find(tb_qtxs p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_qtxs)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_qtxs>>();
        }
        public int Add(tb_qtxs p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_qtxs), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_qtxs> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_qtxs), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_qtxs p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_qtxs), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_qtxs p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_qtxs), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_User	
        public List<tb_User> Find(tb_User p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_User)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_User>>();
        }
        public int Add(tb_User p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_User), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_User> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_User), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_User p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_User), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_User p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_User), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_Waiter	
        public List<tb_Waiter> Find(tb_Waiter p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_Waiter)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_Waiter>>();
        }
        public int Add(tb_Waiter p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Waiter), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_Waiter> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_Waiter), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_Waiter p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_Waiter), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_Waiter p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_Waiter), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_warehouse	
        public List<tb_warehouse> Find(tb_warehouse p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_warehouse)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_warehouse>>();
        }
        public int Add(tb_warehouse p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_warehouse), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_warehouse> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_warehouse), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_warehouse p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_warehouse), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_warehouse p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_warehouse), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_XF	
        public List<tb_XF> Find(tb_XF p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_XF)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_XF>>();
        }
        public int Add(tb_XF p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_XF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_XF> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_XF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_XF p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_XF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_XF p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_XF), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_XFMX	
        public List<tb_XFMX> Find(tb_XFMX p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_XFMX)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_XFMX>>();
        }
        public int Add(tb_XFMX p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_XFMX), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_XFMX> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_XFMX), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_XFMX p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_XFMX), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_XFMX p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_XFMX), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
        #region  tb_yuding	
        public List<tb_yuding> Find(tb_yuding p)
        {
            string res = http.Get(new Uri(GetUrl(RequestEnum.tb_yuding)), p).ReadAsStringAsync().Result;
            return res.ToSerializer<List<tb_yuding>>();
        }
        public int Add(tb_yuding p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_yuding), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Add(List<tb_yuding> p)
        {
            string res = http.Post(GetUrl(RequestEnum.tb_yuding), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Update(tb_yuding p)
        {
            string res = http.Put(GetUrl(RequestEnum.tb_yuding), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        public int Delete(tb_yuding p)
        {
            string res = http.Delete(GetUrl(RequestEnum.tb_yuding), p).ReadAsStringAsync().Result;
            return res.ToSerializer<int>();
        }
        #endregion
    }
}

