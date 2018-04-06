using System;
using System.Collections.Generic;
using System.Text;

namespace Kebue.Core.Util
{
    public static class StaticStr
    {
        public static string DatabaseConnectionStr { get; set; }
        public static string Guid = System.Guid.NewGuid().ToString("N");
        public static DateTime dateTime = System.DateTime.Now;
        public static string Time = dateTime.ToString(yyyy_MM_dd_HH_mm_ss);
        public const string yyyy_MM_dd_HH_mm_ss = "yyyy-MM-dd HH:mm:ss";
        public const string yyyy_MM_dd_HH_mm = "yyyy-MM-dd HH:mm";
        public const string yyyy_MM_dd_HH = "yyyy-MM-dd HH";
        public const string yyyy_MM_dd = "yyyy-MM-dd";
        public const string MM_dd_HH_mm_ss = "MM-dd HH:mm:ss";
        public const string MM_dd_HH_mm = "MM-dd HH:mm";
        public const string MM_dd_HH = "MM-dd HH";
        public const string MM_dd = "MM-dd";
        public const string dd_HH_mm_ss = "dd HH:mm:ss";
        public const string ApplicationJson = "application/json";
        #region 获取时间戳
        /// <summary>  
        /// 获取时间戳  
        /// </summary>  
        /// <returns></returns>  
        public static string GetTimeStamp
        {
            get
            {
                TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
                return Convert.ToInt64(ts.TotalMilliseconds).ToString();
            }
        }
        #endregion

        #region 获取随机数
        /// <summary>  
        /// 获取随机数
        /// </summary>  
        /// <returns></returns>  
        public static string GetRandom
        {
            get
            {
                Random rd = new Random(DateTime.Now.Millisecond);
                int i = rd.Next(0, int.MaxValue);
                return i.ToString();
            }
        }
        #endregion

        public static StatusEnum GetStatusEnum(string str)
        {
            if (str.IsEquals(StatusEnum.True))
            {
                return StatusEnum.True;
            }
            else if (str.IsEquals(StatusEnum.False))
            {
                return StatusEnum.False;
            }
            else if (str.IsEquals(StatusEnum.Normal))
            {
                return StatusEnum.Normal;
            }
            else if (str.IsEquals(StatusEnum.Reserved))
            {
                return StatusEnum.Reserved;
            }
            else if (str.IsEquals(StatusEnum.Using))
            {
                return StatusEnum.Using;
            }
            else if (str.IsEquals(StatusEnum.Clean))
            {
                return StatusEnum.Clean;
            }
            else if (str.IsEquals(StatusEnum.Malfunction))
            {
                return StatusEnum.Malfunction;
            }
            return StatusEnum.Unknown;
        }

    }
}
