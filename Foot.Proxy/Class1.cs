using Foot.WebApi.EntityLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kebue.Core.Util;
namespace Foot.Proxy
{
    public class Class1 //: ProxyBase
    {
        public List<tb_User> Find(tb_User p)
        {
            var res = ProxyBase.http.Get(new Uri(ProxyBase.GetUrl(RequestEnum.tb_User)), p);//.ReadAsStringAsync().Result;
           // return res.ToSerializer<List<tb_User>>();
            return null;
        }
    }
}
