using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;

namespace Kebue.RESTful
{
    /// <summary>
    /// 请求发送者
    /// </summary>
    public class HttpHelper : IHttpHelper
    {
        #region 单例模式
        private HttpHelper() { }
        private static HttpHelper _httpHelper;
        public static HttpHelper Builder(HttpConfig config)
        {
            if (_httpHelper == null && config != null)
            {
                _httpHelper = new HttpHelper();
                _http = new HttpRequest(config);
            }
            return _httpHelper;
        }
        #endregion

        private static IHttpRequest _http;

        #region Delete

        public HttpContent Delete(KeyValuePair<string, string> action)
        {
            return _http.Delete(BuildUri.Build(action));
        }

        public HttpContent Delete<Parameter>(KeyValuePair<string, string> action, Parameter parameter)
        {
            return _http.Delete(BuildUri.Build(action, parameter));
        }

        public HttpContent Delete(string controllerName)
        {
            return _http.Delete(BuildUri.Build(controllerName));
        }

        public HttpContent Delete<Parameter>(string controllerName, Parameter parameter)
        {
            return _http.Delete(BuildUri.Build(controllerName, parameter));
        }

        public HttpContent Delete(Uri _url)
        {
            return _http.Delete(_url);
        }

        public HttpContent Delete(IHttpRequest header, KeyValuePair<string, string> action)
        {
            return header.Delete(BuildUri.Build(action));
        }

        public HttpContent Delete<Parameter>(IHttpRequest header, KeyValuePair<string, string> action, Parameter parameter)
        {
            return header.Delete(BuildUri.Build(action, parameter));
        }
        //public HttpContent Delete<Parameter>(Uri _url, Parameter parameter)
        //{
        //    return _http.Delete(_url, CreateBody.Body(parameter));
        //}

        #endregion

        #region Get
        public HttpContent Get(KeyValuePair<string, string> action)
        {
            return _http.Get(BuildUri.Build(action));
        }
        public HttpContent Get<Parameter>(KeyValuePair<string, string> action, Parameter parameter)
        {
            return _http.Get(BuildUri.Build(action, parameter));
        }
        public HttpContent Get(string controllerName)
        {
            return _http.Get(BuildUri.Build(controllerName));
        }
        public HttpContent Get<Parameter>(string controllerName, Parameter parameter)
        {
            return _http.Get(BuildUri.Build(controllerName, parameter));
        }
        public HttpContent Get(Uri _url)
        {
            return _http.Get(_url);
        }
        public HttpContent Get(IHttpRequest header, KeyValuePair<string, string> action)
        {
            return header.Get(BuildUri.Build(action));
        }
        public HttpContent Get<Parameter>(IHttpRequest header, KeyValuePair<string, string> action, Parameter parameter)
        {
            return header.Get(BuildUri.Build(action, parameter));
        }
        #endregion

       
        #region Post

        public HttpContent Post(KeyValuePair<string, string> action)
        {
            return _http.Post(BuildUri.Build(action));
        }
        public HttpContent Post<Parameter>(KeyValuePair<string, string> action, Parameter parameter)
        {
            return _http.Post(BuildUri.Build(action), CreateBody.Body(parameter));
        }
        public HttpContent Post(string controllerName)
        {
            return _http.Post(BuildUri.Build(controllerName));
        }
        public HttpContent Post<Parameter>(string controllerName, Parameter parameter)
        {
            return _http.Post(BuildUri.Build(controllerName), CreateBody.Body(parameter));
        }
        public HttpContent Post(Uri _url)
        {
            return _http.Post(_url);
        }
        public HttpContent Post<Parameter>(Uri _url, Parameter parameter)
        {
            return _http.Post(_url, CreateBody.Body(parameter));
        }
        public HttpContent Post(IHttpRequest header, KeyValuePair<string, string> action)
        {
            return header.Post(BuildUri.Build(action));
        }
        public HttpContent Post<Parameter>(IHttpRequest header, KeyValuePair<string, string> action, Parameter parameter)
        {
            return header.Post(BuildUri.Build(action), CreateBody.Body(parameter));
        }
        #endregion

        #region Put
        public HttpContent Put(KeyValuePair<string, string> action)
        {
            return _http.Put(BuildUri.Build(action));
        }
        public HttpContent Put<Parameter>(KeyValuePair<string, string> action, Parameter parameter)
        {
            return _http.Put(BuildUri.Build(action), CreateBody.Body(parameter));
        }
        public HttpContent Put(string controllerName)
        {
            return _http.Put(BuildUri.Build(controllerName));
        }
        public HttpContent Put<Parameter>(string controllerName, Parameter parameter)
        {
            return _http.Put(BuildUri.Build(controllerName), CreateBody.Body(parameter));
        }
        public HttpContent Put(Uri _url)
        {
            return _http.Put(_url);
        }
        public HttpContent Put(IHttpRequest header, KeyValuePair<string, string> action)
        {
            return header.Put(BuildUri.Build(action));
        }
        public HttpContent Put<Parameter>(IHttpRequest header, KeyValuePair<string, string> action, Parameter parameter)
        {
            return header.Put(BuildUri.Build(action), CreateBody.Body(parameter));
        }
        public HttpContent Put<Parameter>(Uri _url, Parameter parameter)
        {
            return _http.Put(_url, CreateBody.Body(parameter));
        }
        #endregion
    }
}
