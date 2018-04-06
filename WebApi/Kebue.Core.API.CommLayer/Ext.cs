using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Kebue.Core.API.CommLayer
{
    public static class Ext
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

        #endregion

        #region 对象非空判断
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
        public static bool IsNotNull(this object obj)
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
        public static string ToSerializer<T>(this T obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer jsonSerialize = new DataContractJsonSerializer(typeof(T));
                jsonSerialize.WriteObject(stream, obj);
                return Encoding.UTF8.GetString(stream.ToArray());
            }

        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        private static T ToObject<T>(string jsonStr)
        {
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonStr)))
            {
                DataContractJsonSerializer jsonSerialize = new DataContractJsonSerializer(typeof(T));
                return (T)jsonSerialize.ReadObject(stream);
            }
        }
        #endregion
    }
}
