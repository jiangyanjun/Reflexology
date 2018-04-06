using System;
using System.Net.Http;

namespace Kebue.RESTful
{
    /// <summary>
    /// Http请求
    /// </summary>
    public interface IHttpRequest
    {

        #region 添加头部参数
        /// <summary>
        /// 添加头部参数
        /// </summary>
        void AddHeaderParamerter(string key, string value);
        #endregion

        #region 设置授权信息
        /// <summary>
        /// 设置授权信息
        /// </summary>
        /// <param name="scheme">模式</param>
        /// <param name="value">值
        void SetAuthentication(string scheme, string value);

        #endregion

        #region Get
        HttpContent Get(Uri uri);
        //HttpContent Get(Uri uri, HttpContent body);
        HttpContent Get(string uri);
        //HttpContent Get(string uri, HttpContent body);
        #endregion

        #region Post
        HttpContent Post(Uri uri);
        HttpContent Post(Uri uri, HttpContent body);
        HttpContent Post(string uri);
        HttpContent Post(string uri, HttpContent body);
        #endregion

        #region Put
        HttpContent Put(Uri uri);
        HttpContent Put(Uri uri, HttpContent body);
        HttpContent Put(string uri);
        HttpContent Put(string uri, HttpContent body);
        #endregion

        #region Delete
        HttpContent Delete(Uri uri);
        //HttpContent Delete(Uri uri, HttpContent body);
        HttpContent Delete(string uri);
        //HttpContent Delete(string uri, HttpContent body); 
        #endregion
    }
}
