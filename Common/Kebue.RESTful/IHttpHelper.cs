using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Kebue.RESTful
{
    public interface IHttpHelper
    {
        #region Get
        HttpContent Get(Uri _url);
        HttpContent Get(string controllerName);
        HttpContent Get<Parameter>(string controllerName, Parameter parameter);
        HttpContent Get(KeyValuePair<string, string> action);
        HttpContent Get<Parameter>(KeyValuePair<string, string> action, Parameter parameter);
        HttpContent Get(IHttpRequest header, KeyValuePair<string, string> action);
        HttpContent Get<Parameter>(IHttpRequest header, KeyValuePair<string, string> action, Parameter parameter);
        #endregion

        #region Post
        HttpContent Post(Uri _url);
        HttpContent Post<Parameter>(Uri url, Parameter parameter);
        HttpContent Post(string controllerName);
        HttpContent Post<Parameter>(string controllerName, Parameter parameter);
        HttpContent Post(KeyValuePair<string, string> action);
        HttpContent Post<Parameter>(KeyValuePair<string, string> action, Parameter parameter);
        HttpContent Post(IHttpRequest header, KeyValuePair<string, string> action);
        HttpContent Post<Parameter>(IHttpRequest header, KeyValuePair<string, string> action, Parameter parameter);
        #endregion

        #region Put
        HttpContent Put(Uri _url);
        HttpContent Put<Parameter>(Uri url, Parameter parameter);
        HttpContent Put(string controllerName);
        HttpContent Put<Parameter>(string controllerName, Parameter parameter);
        HttpContent Put(KeyValuePair<string, string> action);
        HttpContent Put<Parameter>(KeyValuePair<string, string> action, Parameter parameter);
        HttpContent Put(IHttpRequest header, KeyValuePair<string, string> action);
        HttpContent Put<Parameter>(IHttpRequest header, KeyValuePair<string, string> action, Parameter parameter);
        #endregion

        #region Delete
        HttpContent Delete(Uri _url);
        //HttpContent Delete<Parameter>(Uri url, Parameter parameter);
        HttpContent Delete(string controllerName);
        HttpContent Delete<Parameter>(string controllerName, Parameter parameter);
        HttpContent Delete(KeyValuePair<string, string> action);
        HttpContent Delete<Parameter>(KeyValuePair<string, string> action, Parameter parameter);
        HttpContent Delete(IHttpRequest header, KeyValuePair<string, string> action);
        HttpContent Delete<Parameter>(IHttpRequest header, KeyValuePair<string, string> action, Parameter parameter);
        #endregion
    }
}
