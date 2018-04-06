using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Kebue.RESTful
{
    public class CreateBody
    {
        #region 创建请求Body
        /// <summary>
        /// 创建请求Body
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="parameter">参数</param>
        /// <returns>请求Body</returns>
        public static HttpContent Body<T>(T parameter)
        {
            HttpContentTypeAttribute attribute = (HttpContentTypeAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(HttpContentTypeAttribute), false);
            if (attribute == null)
            {
                attribute = new HttpContentTypeAttribute(HttpContentTypeEnum.Json);
                //throw new HttpException("HttpContentTypeEnum attribute is undefined.");
            }
            if (parameter != null)
            {
                string body = parameter.SerializeString<T>();
                switch (attribute.Type)
                {
                    case HttpContentTypeEnum.FormUrl:
                        if (!(parameter is IEnumerable<KeyValuePair<string, string>>))
                        {
                            throw new HttpException("Parameter unrealized IEnumerable<KeyValuePair<string, string>> interface.");
                        }
                        return new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)parameter);
                    case HttpContentTypeEnum.Json:
                        StringContent json = new StringContent(body, Encoding.UTF8);
                        json.Headers.ContentType = new MediaTypeHeaderValue("application/json")
                        {
                            CharSet = "utf-8"
                        };
                        return json;
                    case HttpContentTypeEnum.Xml:
                        body = parameter.XmlSerializerString<T>();
                        StringContent xml = new StringContent(body);
                        xml.Headers.ContentType = new MediaTypeHeaderValue("application/xml")
                        {
                            CharSet = "utf-8"
                        };
                        return xml;
                    //case HttpContentTypeEnum.Stream:
                    //    if (parameter == null) return null;
                    //    if (!(parameter is byte[])) {

                    //    }
                    //    return new StreamContent(new MemoryStream((byte[])parameter));
                    default:
                        throw new HttpException("Unsupported http content type.");

                }
            }

            //if (logger.IsDebugEnabled)
            //{
            //    logger.DebugFormat("Request Parameters : {0}", JsonKit.Serialize(parameter));
            //}
            switch (attribute.Type)
            {
                case HttpContentTypeEnum.FormUrl:
                    if (!(parameter is IEnumerable<KeyValuePair<string, string>>))
                    {
                        throw new HttpException("Parameter unrealized IEnumerable<KeyValuePair<string, string>> interface.");
                    }
                    return new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)parameter);
                case HttpContentTypeEnum.Json:
                    string body = parameter.SerializeString<T>();
                    StringContent json = new StringContent(parameter == null ? string.Empty : body, Encoding.UTF8);
                    json.Headers.ContentType = new MediaTypeHeaderValue("application/json")
                    {
                        CharSet = "utf-8"
                    };
                    return json;
                case HttpContentTypeEnum.Xml:
                    StringContent xml = new StringContent(parameter == null ? string.Empty : parameter.SerializeString<T>());
                    xml.Headers.ContentType = new MediaTypeHeaderValue("application/xml")
                    {
                        CharSet = "utf-8"
                    };
                    return xml;
                //case HttpContentTypeEnum.Stream:
                //    if (parameter == null) return null;
                //    if (!(parameter is byte[])) {

                //    }
                //    return new StreamContent(new MemoryStream((byte[])parameter));
                default:
                    throw new HttpException("Unsupported http content type.");

            }
        } 
        #endregion
    }
}
