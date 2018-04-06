using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Kebue.Core.Util
{
    public class HttpHelpers
    {
        public static string HttpRequest(HttpWebRequest request, string parameter)
        {
            string req = string.Empty;
            if (parameter.IsNotNull())
            {
                byte[] byteData = UTF8Encoding.UTF8.GetBytes(parameter);
                request.ContentLength = byteData.Length;
                using (Stream postStream = request.GetRequestStream())
                {
                    postStream.Write(byteData, 0, byteData.Length);
                }
            }
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                req = reader.ReadToEnd();
            }
            return req;
        }

        #region RESTful API  Request Method
        public static string HttpRequest(string Method, string url, string parameter, int timeout = 20000)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = Method;
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36";
            request.Timeout = timeout;
            request.Credentials = new NetworkCredential("username", "password");
            return HttpRequest(request, parameter);
        }

        public static string Get(string url, string parameter, int timeout = 20000)
        {
            return HttpRequest("GET", url, parameter, timeout);
        }

        public static string Post(string url, string parameter, int timeout = 20000)
        {
            return HttpRequest("POST", url, parameter, timeout);
        }

        public static string Put(string url, string parameter, int timeout = 20000)
        {
            return HttpRequest("PUT", url, parameter, timeout);
        }

        public static string Delete(string url, string parameter, int timeout = 20000)
        {
            return HttpRequest("DELETE", url, parameter, timeout);
        }

        public static T Get<T>(string url, string parameter, int timeout = 20000)
        {
            return HttpRequest("GET", url, parameter, timeout).ToDeserialize<T>();
        }

        public static T Post<T>(string url, string parameter, int timeout = 20000)
        {
            return HttpRequest("POST", url, parameter, timeout).ToDeserialize<T>();
        }

        public static T Put<T>(string url, string parameter, int timeout = 20000)
        {
            return HttpRequest("PUT", url, parameter, timeout).ToDeserialize<T>();
        }

        public static T Delete<T>(string url, string parameter, int timeout = 20000)
        {
            return HttpRequest("DELETE", url, parameter, timeout).ToDeserialize<T>();
        }
        #endregion


        public static string Post_HttpClientHandler<Parameter>(string url, Parameter RequestParameter)
        {
            string reResponse = string.Empty;
            HttpClientHandler handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip };
            using (var http = new HttpClient(handler))
            {
                HttpRequestHeaders header = http.DefaultRequestHeaders;
                string timeStamp = StaticStr.GetTimeStamp;
                string nonce = StaticStr.GetRandom;
                //加入头信息
                header.Add("staffid", "1000"); //当前请求用户StaffId
                header.Add("timestamp", timeStamp); //发起请求时的时间戳（单位：毫秒）
                header.Add("nonce", nonce); //发起请求时的时间戳（单位：毫秒）
                                            // header.Add("signature", GetSignature(timeStamp, nonce, staffId, null)); //当前请求内容的数字签名

                var parameter = RequestParameter.GetObjectPropertyValue();
                var content = new FormUrlEncodedContent(parameter);
                var response = http.PostAsync(url, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    reResponse = response.Content.ReadAsStringAsync().Result;
                }
            }
            return reResponse;
        }

        public static string Post<Parameter>(string url, Parameter RequestParameter)
        {
            string strResult = string.Empty;
            #region HttpWebRequest
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(RequestParameter.ToSerialize());
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //写数据
                request.Method = "POST";
                request.ContentLength = bytes.Length;
                request.ContentType = StaticStr.ApplicationJson;
                Stream reqstream = request.GetRequestStream();
                reqstream.Write(bytes, 0, bytes.Length);

                //读数据
                request.Timeout = 300000;
                request.Headers.Set("Pragma", "no-cache");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(streamReceive, Encoding.UTF8);
                strResult = streamReader.ReadToEnd();

                //关闭流
                reqstream.Close();
                streamReader.Close();
                streamReceive.Close();
                request.Abort();
                response.Close();
            }
            catch (Exception ex)
            {
            }
            #endregion
            return strResult;
        }

        public static string RequestData(string POSTURL, string PostData)
        {
            //发送请求的数据
            WebRequest myHttpWebRequest = WebRequest.Create(POSTURL);
            myHttpWebRequest.Method = "POST";
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] byte1 = encoding.GetBytes(PostData);
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = byte1.Length;
            Stream newStream = myHttpWebRequest.GetRequestStream();
            newStream.Write(byte1, 0, byte1.Length);
            newStream.Close();

            //发送成功后接收返回的XML信息
            HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            string lcHtml = string.Empty;
            Encoding enc = Encoding.GetEncoding("UTF-8");
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream, enc);
            lcHtml = streamReader.ReadToEnd();
            return lcHtml;
        }



    }
}
