using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace Kebue.Core.Util
{
    public static partial class Ext
    {
        #region 字符串非空判断
        public static bool IsNull(this string str)
        {
            if (str == null)
            {
                return true;
            }
            else if (str.Trim() == null)
            {
                return true;
            }
            else if (string.IsNullOrEmpty(str.Trim()))
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsNotNull(this string str)
        {
            return !IsNull(str);
        }
        public static bool IsNotNull(this int str)
        {
            return !IsNull(str);
        }
        public static bool IsNull(this int str)
        {
            return str <= 0;
        }
        #endregion

        #region 对象非空判断
        public static bool IsNull(this double obj)
        {
            return obj <= 0;
        }
        public static bool IsNotNull(this double obj)
        {
            return !IsNull(obj);
        }
        public static bool IsNull(this decimal obj)
        {
            return obj <= 0;
        }
        public static bool IsNotNull(this decimal obj)
        {
            return !IsNull(obj);
        }
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
        public static bool IsNotNull(this object obj)
        {
            return !IsNull(obj);
        }
        public static bool IsNull<T>(this IList<T> obj)
        {
            if (obj != null)
            {
                return obj.Count <= 0;
            }
            else
            {
                return true;
            }
        }
        public static bool IsNotNull<T>(this IList<T> obj)
        {
            return !IsNull(obj);
        }
        public static bool IsNull(this DateTime obj)
        {
            return obj < StaticStr.dateTime.AddYears(-10);
        }
        public static bool IsNotNull(this DateTime obj)
        {
            return !IsNull(obj);
        }
        public static bool IsNotNull<T>(this object obj)
        {
            return !IsNull<T>(obj);
        }
        public static bool IsNull<T>(this object obj)
        {
            if (obj == null)
            {
                return true;
            }
            else if (obj is ICollection<T>)
            {
                var list = obj as ICollection<T>;
                return list.Count > 0;
            }
            else if (obj is Array)
            {
                var list = obj as Array;
                return list.Length > 0;
            }
            else
                return false;
        }
        #endregion

        #region 序列化与反序列化
        /// <summary>
        /// 对象序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToSerialize<T>(this T obj)
        {
            JavaScriptSerializer jsonSerialize = new JavaScriptSerializer();
            return jsonSerialize.Serialize(obj);
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    DataContractJsonSerializer jsonSerialize = new DataContractJsonSerializer(typeof(T));
            //    jsonSerialize.WriteObject(stream, obj);
            //    return Encoding.UTF8.GetString(stream.ToArray());
            //}

        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T ToDeserialize<T>(this string jsonStr)
        {
            JavaScriptSerializer jsonSerialize = new JavaScriptSerializer();
            return jsonSerialize.Deserialize<T>(jsonStr);
            //using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonStr)))
            //{
            //    DataContractJsonSerializer jsonSerialize = new DataContractJsonSerializer(typeof(T));
            //    return (T)jsonSerialize.ReadObject(stream);
            //}
        }
        #endregion

        #region 获取中英字符串长度
        /// <summary>
        /// 获取字符串长度，中文占2个子节
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ToLength(this string str)
        {
            int len = 0;
            byte[] b;
            for (int i = 0; i < str.Length; i++)
            {
                b = Encoding.Default.GetBytes(str.Substring(i, 1));
                if (b.Length > 1)
                    len += 2;
                else
                    len++;
            }
            return len;
        }
        #endregion

        #region 过滤标记(包括HTML，脚本，数据库关键字，特殊字符的源码)
        /// <summary>
        /// 过滤标记
        /// </summary>
        /// <param name="NoHTML">包括HTML，脚本，数据库关键字，特殊字符的源码 </param>
        /// <returns>已经去除标记后的文字</returns>
        public static string ToFilterMark(this string Htmlstring)
        {
            if (Htmlstring == null)
            {
                return "";
            }
            else
            {
                //删除脚本
                Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
                //删除HTML
                Htmlstring = Regex.Replace(Htmlstring, @"<(.[^>]*)>", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"([\r\n])[\s]+", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"-->", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"<!--.*", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(quot|#34);", "\"", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(amp|#38);", "&", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(lt|#60);", "<", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(gt|#62);", ">", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(nbsp|#160);", " ", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(iexcl|#161);", "\xa1", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(cent|#162);", "\xa2", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(pound|#163);", "\xa3", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&(copy|#169);", "\xa9", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, @"&#(\d+);", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "xp_cmdshell", "", RegexOptions.IgnoreCase);

                //删除与数据库相关的词
                Htmlstring = Regex.Replace(Htmlstring, "select", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "insert", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "delete from", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "count''", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "drop table", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "truncate", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "asc", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "mid", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "char", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "xp_cmdshell", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "exec master", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "net localgroup administrators", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "and", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "net user", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "or", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "net", "", RegexOptions.IgnoreCase);
                //Htmlstring = Regex.Replace(Htmlstring,"*", "", RegexOptions.IgnoreCase);
                //Htmlstring = Regex.Replace(Htmlstring,"-", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "delete", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "drop", "", RegexOptions.IgnoreCase);
                Htmlstring = Regex.Replace(Htmlstring, "script", "", RegexOptions.IgnoreCase);

                //特殊的字符
                Htmlstring = Htmlstring.Replace("<", "");
                Htmlstring = Htmlstring.Replace(">", "");
                Htmlstring = Htmlstring.Replace("*", "");
                Htmlstring = Htmlstring.Replace("-", "");
                Htmlstring = Htmlstring.Replace("?", "");
                Htmlstring = Htmlstring.Replace(",", "");
                Htmlstring = Htmlstring.Replace("/", "");
                Htmlstring = Htmlstring.Replace(";", "");
                Htmlstring = Htmlstring.Replace("*/", "");
                Htmlstring = Htmlstring.Replace("\r\n", "");
                Htmlstring = WebUtility.HtmlEncode(Htmlstring).Trim();
                return Htmlstring;
            }

        }
        #endregion

        #region 截取指定长度字符串(按字节算
        /// <summary>
        /// 截取指定长度字符串(按字节算)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="length">从0开始截取的长度</param>
        /// <returns></returns>
        public static string ToStrCut(this string str, int length)
        {
            int len = 0;
            byte[] b;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                b = Encoding.Default.GetBytes(str.Substring(i, 1));
                if (b.Length > 1)
                    len += 2;
                else
                    len++;

                if (len >= length)
                    break;

                sb.Append(str[i]);
            }

            return sb.ToString();
        }
        #endregion

        #region ToHttpResponseMessage
        public static HttpResponseMessage ToHttpResponseMessage<T>(this T p)
        {
            String str;
            if (p is String || p is Char)
            {
                str = p.ToString();
            }
            else
            {
                str = p.ToSerialize<T>();
            }
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }
        #endregion

        #region 返回字段名称和值
        /// <summary>
        /// 返回字段名称和值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ToPropertyValue<T>(this T t)
        {
            Dictionary<string, string> x = new Dictionary<string, string>();
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property != null && t != null)
                {

                    if (t is String || t is Char)
                    {
                        t = (T)Convert.ChangeType(t, typeof(T));
                    }

                    object o = property.GetValue(t, null);
                    if (o != null)
                    {
                        x.Add(property.Name, o.ToString());
                    }
                }
            }
            return x;
        }
        #endregion

        #region 字符串转Int类型
        /// <summary>
        /// 字符串转Int类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(this string obj)
        {
            int r = 0;
            if (obj.IsNotNull())
                int.TryParse(obj, out r);
            return r;
        }
        #endregion
        #region 字符串转Int类型
        /// <summary>
        /// 字符串转decimal类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(this decimal obj)
        {
            int r = 0;
            if (obj.IsNotNull())
                int.TryParse(obj.ToString(), out r);
            return r;
        }
        #endregion
        #region 字符串转decimal类型
        /// <summary>
        /// 字符串转Int类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string obj)
        {
            decimal r = 0;
            if (obj.IsNotNull())
                decimal.TryParse(obj, out r);
            return r;
        }
        public static decimal ToDecimal(this object obj)
        {
            decimal r = 0;
            if (obj.IsNotNull())
                decimal.TryParse(obj.ToString(), out r);
            return r;
        }
        #endregion

        #region 获得枚举的Description
        /// <summary>
        /// 获得枚举的Description
        /// </summary>
        /// <param name="value">枚举值</param>
        /// <param name="nameInstend">当枚举没有定义DescriptionAttribute,是否用枚举名代替，默认使用</param>
        /// <returns>枚举的Description</returns>
        public static string ToEnumDescription(this Enum value, bool nameInstend = true)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                return null;
            }
            FieldInfo field = type.GetField(name);
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (attribute == null && nameInstend == true)
            {
                return name;
            }
            return attribute == null ? null : attribute.Description;
        }

        #endregion

        #region 转换
        public static byte[] ToConvertByte(this string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }
        public static string ToConvertString(this byte[] p)
        {
            return Encoding.ASCII.GetString(p);
        }
        #endregion

        #region 对象转Dictionary<string, string>
        /// <summary>
        /// T对象转Dictionary<string, string>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetObjectPropertyValue<T>(this T t)
        {
            Dictionary<string, string> x = new Dictionary<string, string>();
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property != null && t != null)
                {

                    if (t is String || t is Char)
                    {
                        t = (T)Convert.ChangeType(t, typeof(T));
                    }

                    object o = property.GetValue(t, null);
                    if (o != null)
                    {
                        x.Add(property.Name, o.ToString());
                    }
                }
            }
            return x;
        }

        #endregion

        /// <summary>  
        /// 反射得到实体类的字段名称和值  
        /// var dict = GetProperties(model);  
        /// </summary>  
        /// <typeparam name="T">实体类</typeparam>  
        /// <param name="t">实例化</param>  
        /// <returns></returns>  
        public static Dictionary<object, object> GetProperties<T>(this T t)
        {
            var ret = new Dictionary<object, object>();
            if (t == null) { return null; }
            PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            if (properties.Length <= 0) { return null; }
            foreach (PropertyInfo item in properties)
            {
                string name = item.Name;
                object value = item.GetValue(t, null);
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    ret.Add(name, value);
                }
            }
            return ret;
        }

        public static bool IsEquals(this string str, string str2)
        {
            if (str.IsNotNull() && str2.IsNotNull())
            {
                return str.ToUpper().Trim().Equals(str2.ToUpper().Trim());
            }
            return false;
        }
        public static bool IsEquals(this string str, Enum str2)
        {
            if (str.IsNotNull() && str2.IsNotNull())
            {
                return str.ToUpper().Equals(str2.ToString().ToUpper());
            }
            return false;
        }
        public static bool IsEquals(this string str, int str2)
        {
            if (str.IsNotNull() && str2.IsNotNull())
            {
                return str.ToUpper().Equals(str2.ToString().ToUpper());
            }
            return false;
        }
        public static bool IsContains(this string str, string str2)
        {
            if (str.IsNotNull() && str2.IsNotNull())
            {
                return str.ToUpper().Contains(str2.ToString().ToUpper());
            }
            return false;
        }
    }
}
