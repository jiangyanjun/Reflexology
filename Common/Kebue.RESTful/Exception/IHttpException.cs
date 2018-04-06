using System;

namespace Kebue.RESTful
{
    /// <summary>
    /// 异常类基类
    /// </summary>
    public abstract class IHttpException : Exception
    {

        /// <summary>
        /// 错误代码
        /// </summary>
        public int Code { get; protected set; }

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="code">错误代码</param>
        /// <param name="msg">提示消息</param>
        public IHttpException(int code, string msg) : this(code, msg, null)
        {

        }

        /// <summary>
        /// 异常代码初始化
        /// </summary>
        /// <param name="code">错误代码</param>
        /// <param name="msg">提示消息</param>
        /// <param name="innerException">异常</param>
        public IHttpException(int code, string msg, Exception innerException) : base(msg, innerException)
        {
            this.Code = code;
        }

    }
}
