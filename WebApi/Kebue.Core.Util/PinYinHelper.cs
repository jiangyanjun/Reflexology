using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebue.Core.Util
{
    /// <summary>
    /// 中文字符串转换为拼音或者拼音首字母的辅助类
    /// </summary>
    public class PinYinHelper
    {
        /// <summary> 
        /// 汉字转化为拼音
        /// </summary> 
        /// <param name="str">汉字</param> 
        /// <returns>全拼</returns> 
        public static string GetPinyin(string str)
        {
            StringBuilder r = new StringBuilder();
            foreach (char obj in str)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(obj);
                    string t = chineseChar.Pinyins[0].ToString();
                    r.Append(t.Substring(0, t.Length - 1));
                }
                catch
                {
                    r.Append(obj.ToString());
                }
            }
            return r.ToString().ToUpper();
        }

        /// <summary> 
        /// 汉字转化为拼音首字母
        /// </summary> 
        /// <param name="str">汉字</param> 
        /// <returns>首字母</returns> 
        public static string GetFirstPinyin(string str)
        {
            StringBuilder r = new StringBuilder();
            foreach (char obj in str)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(obj);
                    string t = chineseChar.Pinyins[0].ToString();
                    r.Append(t.Substring(0, 1));
                }
                catch
                {
                    r.Append(obj.ToString());
                }
            }
            return r.ToString().ToUpper();
        }
    }
}
