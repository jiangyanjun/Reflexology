using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Kebue.RESTful
{
    public class BuildUri
    {
        static string UrlPath
        {
            get
            {
                if (string.IsNullOrEmpty(HttpConfig.BaseUrl))
                {
                    throw new HttpException("BaseUrl is undefined.");
                }
                string baseUrl = HttpConfig.BaseUrl.Trim();
                if (baseUrl.EndsWith("/") || baseUrl.EndsWith("\\"))
                {
                    baseUrl = baseUrl.TrimEnd('/', '\\');
                }
                return baseUrl;
            }
        }
        #region 构造请求URL 
        public static Uri Build(string controllerName)
        {
            return new UriBuilder(Replace(string.Format("{0}\\{1}", UrlPath, controllerName))).Uri;
        }
        public static Uri Build<T>(string controllerName, T parameter)
        {
            return new UriBuilder(Replace(string.Format("{0}\\{1}?{2}", UrlPath, controllerName, BuildString(parameter)))).Uri;
        }
        public static Uri Build(KeyValuePair<string, string> action)
        {
            return new UriBuilder(Replace(string.Format("{0}\\{1}\\{2}", UrlPath, action.Key, action.Value))).Uri;
        }
        public static Uri Build<T>(KeyValuePair<string, string> action, T parameter)
        {
            return new UriBuilder(Replace(string.Format("{0}\\{1}\\{2}?{3}", UrlPath, action.Key, action.Value, BuildString(parameter)))).Uri;
        }
        public static string BuildStr<T>(KeyValuePair<string, string> action, T parameter)
        {
            return Replace(string.Format("{0}\\{1}\\{2}?{3}", UrlPath, action.Key, action.Value, BuildString(parameter)));
        }
        public static string BuildString<T>(T t)
        {
            var args = GetProperties(t);
            StringBuilder sb = new StringBuilder();
            if (args != null && args.Count > 0)
            {
                int i = 0;
                Array.ForEach(args.ToArray(), r =>
                {
                    if (i > 0)
                        sb.Append("&");
                    sb.Append(r.Key + "=" + r.Value);
                    i++;
                });
            }
            return sb.ToString();
        }
        public static Dictionary<object, object> GetProperties<T>(T t)
        {
            var ret = new Dictionary<object, object>();
            if (t == null) { return null; }
            if (t is string)
            {
                ret.Add("Parameter", t);
            }
            else if (t is Dictionary<object, object>)
            {
                return t as Dictionary<object, object>;
            }
            else
            {
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
            }
            return ret;
        }
        #endregion

        #region 构造请求QueryString参数
        /// <summary>
        /// 构造请求QueryString参数
        /// </summary>
        public static string BuildQueryStringParameter(IDictionary<string, string> args)
        {
            StringBuilder sb = new StringBuilder();
            if (args != null && args.Count > 0)
            {
                int i = 0;
                Array.ForEach(args.ToArray(), r =>
                {
                    if (i > 0)
                        sb.Append("&");
                    sb.Append(r.Key + "=" + r.Value);
                    i++;
                });
            }
            return sb.ToString();
        }
        #endregion

        static string Replace(string oldValue)
        {
            string _x = "/\\";
            if (oldValue != null && _x != null && oldValue.Contains(_x))
            {
                oldValue = oldValue.Replace(_x, "\\");
            }
            _x = @"/\";
            if (oldValue.Contains(_x))
            {
                oldValue = oldValue.Replace(_x, "\\");
            }
            return oldValue;
        }

    }
}
