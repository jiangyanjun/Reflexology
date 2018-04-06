using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Kebue.RESTful
{
    public class HttpSend
    {
        #region 单例模式
        private HttpSend() { }
        private static HttpConfig app;
        private static HttpSend _httpsend;
        public static HttpSend Builder(HttpConfig config)
        {
            if (_httpsend == null && config != null)
            {
                _httpsend = new HttpSend();
                app = config;
            }
            return _httpsend;
        }
        #endregion

        /// <summary>
        /// 授权头部
        /// </summary>
        public static AuthenticationHeaderValue Authentication { get; set; }
        public static Dictionary<string, string> Header { get; set; }

        /// 发送Http请求
        /// </summary>
        /// <param name="method">请求方法</param>
        /// <param name="uri">请求地址</param>
        /// <param name="parameter">请求参数</param>
        /// <returns>请求结果</returns>
        public HttpContent SendRequest(HttpMethod method, Uri uri, HttpContent body = null)
        {
            try
            {
                //logger.InfoFormat("正在以{0}方式请求资源：{1}", method.ToString(), uri.AbsoluteUri);
                HttpClient client = CreateHttpClient(uri);
                string requestUri = uri.AbsoluteUri;
                if (!string.IsNullOrEmpty(uri.Query))
                {
                    requestUri = string.Format("{0}{1}", uri.AbsolutePath, uri.Query);
                }

                Task<HttpResponseMessage> response = SendRequest(client, method, requestUri, body);

                return OnHandleResponse(response.Result);
            }
            catch (Exception e)
            {
                throw new HttpException(string.Format("{0} request error.", method), e);
            }
        }
        /// <summary>
        /// 处理应答
        /// </summary>
        /// <param name="response">应答</param>
        /// <returns>应答内容</returns>
        protected virtual HttpContent OnHandleResponse(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            return response.Content;
        }
        private Task<HttpResponseMessage> SendRequest(HttpClient client, HttpMethod method, string url, HttpContent body)
        {
            if (method == HttpMethod.Get)
            {
                return client.GetAsync(url);
            }
            else if (method == HttpMethod.Delete)
            {
                return client.DeleteAsync(url);
            }
            else if (method == HttpMethod.Post)
            {
                return client.PostAsync(url, body);
            }
            else if (method == HttpMethod.Put)
            {
                return client.PutAsync(url, body);
            }
            else
            {
                throw new HttpException(string.Format("Unsupported http request method {0}.", method));
            }
        }

        /// <summary>
        /// 创建HttpClient
        /// </summary>
        /// <param name="uri">请求地址</param>
        /// <returns>HttpClient</returns>
        public virtual HttpClient CreateHttpClient(Uri uri)
        {
            //见识查是否有效的http请求
            Uri baseUri = new UriBuilder(uri.Scheme, uri.Host, uri.Port).Uri;

            HttpClientHandler handler = new HttpClientHandler()
            {
                //设置HttpClientHandler的重定向响应
                AllowAutoRedirect = false,
                //设置HttpClientHandler的重定向次数
                //MaxAutomaticRedirections = 100,
                CookieContainer = new CookieContainer(),
                //设置HttpClientHandler的AutomaticDecompression
                AutomaticDecompression = DecompressionMethods.GZip,
                //设置HttpClientHandler的请求内容缓冲大小
                MaxRequestContentBufferSize = app.ContentSize,

            };
            HttpClient client = new HttpClient(handler);
            client.BaseAddress = baseUri;
            client.MaxResponseContentBufferSize = app.ContentSize;
            client.Timeout = TimeSpan.FromSeconds(app.Timeout);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(app.ContentType));
            OnHttpClientCreated(client, app);
            return client;
        }
        /// <summary>
        /// 创建HttpClient
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="config">配置信息</param>
        public virtual void OnHttpClientCreated(HttpClient client, HttpConfig config)
        {
            if (Header != null)
            {
                foreach (string key in Header.Keys)
                {
                    string headerValue = HttpUtility.UrlEncode(Header[key], Encoding.UTF8);
                    client.DefaultRequestHeaders.Add(key, headerValue);
                }
            }
            if (Authentication != null)
            {
                client.DefaultRequestHeaders.Authorization = Authentication;
            }
        }

    }
}
