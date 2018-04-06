using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Kebue.RESTful
{
    /// <summary>
    /// Http请求
    /// </summary>
    public class HttpRequest : IHttpRequest
    {
        #region 请求头
        private HttpConfig app;
        public HttpRequest(HttpConfig _config)
        {
            app = _config;
        }

        public void AddHeaderParamerter(string key, string value)
        {
            if (HttpSend.Header.ContainsKey(key))
            {
                HttpSend.Header[key] = value;
            }
            else
            {
                HttpSend.Header.Add(key, value);
            }
        }
        #endregion

        public HttpContent Delete(Uri uri)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Delete, uri);
        }

        public HttpContent Delete(Uri uri, HttpContent body)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Delete, uri, body);
        }

        public HttpContent Delete(string uri)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Delete, new UriBuilder(uri).Uri);
        }

        public HttpContent Delete(string uri, HttpContent body)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Delete, new UriBuilder(uri).Uri, body);
        }

        public HttpContent Get(Uri uri)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Get, uri);
        }

        public HttpContent Get(Uri uri, HttpContent body)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Get, uri, body);
        }

        public HttpContent Get(string uri)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Get, new UriBuilder(uri).Uri);
        }

        public HttpContent Get(string uri, HttpContent body)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Get, new UriBuilder(uri).Uri, body);
        }

        public HttpContent Post(Uri uri)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Post, uri);
        }

        public HttpContent Post(Uri uri, HttpContent body)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Post, uri, body);
        }

        public HttpContent Post(string uri)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Post, new UriBuilder(uri).Uri);
        }

        public HttpContent Post(string uri, HttpContent body)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Post, new UriBuilder(uri).Uri, body);
        }

        public HttpContent Put(Uri uri)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Put, uri);
        }

        public HttpContent Put(Uri uri, HttpContent body)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Put, uri, body);
        }

        public HttpContent Put(string uri)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Put, new UriBuilder(uri).Uri);
        }

        public HttpContent Put(string uri, HttpContent body)
        {
            return HttpSend.Builder(app).SendRequest(HttpMethod.Put, new UriBuilder(uri).Uri, body);
        }

        public void SetAuthentication(string scheme, string value)
        {
            HttpSend.Authentication = new AuthenticationHeaderValue(scheme, value);
        }
    }

}
