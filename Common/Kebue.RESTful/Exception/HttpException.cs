using System;

namespace Kebue.RESTful
{
    /// <summary>
    /// Http驱动异常
    /// </summary>
    public class HttpException : IHttpException
    {

        /// <summary>
        /// 错误代码
        /// </summary>
        public static readonly int CODE = 8000;

        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="msg">错误消息</param>
        public HttpException(string msg) : this(msg, null)
        {

        }

        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="msg">错误消息</param>
        /// <param name="innerException">内部异常</param>
        public HttpException(string msg, Exception innerException) : base(CODE, msg, innerException)
        {

        }
    }
}
