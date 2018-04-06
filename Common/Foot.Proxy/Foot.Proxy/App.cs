using Foot.EntityLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foot.Proxy
{
    public class App
    {
        /// <summary>
        /// 当前系统登陆用户
        /// </summary>
        public static tb_User CertificationUser { get; set; }
        public static string GetGuid
        {
            get
            {
                return Guid.NewGuid().ToString("N");
            }
        }
        public static DateTime GetDateTime
        {
            get
            {
                return System.DateTime.Now;
            }
        }
    }
}
