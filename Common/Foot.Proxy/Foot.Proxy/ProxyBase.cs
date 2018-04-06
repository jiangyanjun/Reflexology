using Kebue.Core.Util;
using Kebue.RESTful;

namespace Foot.Proxy
{
    public class ProxyBase
    {
        static ProxyBase()
        {
            Initialization();
        }
        public static HttpHelper http;
        public static void Initialization(string areas = null)
        {
            if (http.IsNull())
            {
                string url = "http://localhost:58895/api/";
                if (areas.IsNotNull())
                {
                    url = string.Format("{0}/{1}/", url, areas);
                }
                HttpConfig config = new HttpConfig(url);
                http = HttpHelper.Builder(config);
            }
        }
        public static string GetUrl(RequestEnum enums)
        {
            string acction = enums.ToEnumDescription();
            string old = "Controller";
            if (acction.IsNotNull() && acction.Contains(old))
            {
                return acction.Replace(old, "");
            }
            return acction;
        }
    }
}
