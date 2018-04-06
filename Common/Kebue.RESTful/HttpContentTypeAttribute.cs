using System;

namespace Kebue.RESTful
{
    [AttributeUsage(AttributeTargets.Class)]
    [Serializable]
    public class HttpContentTypeAttribute : Attribute
    {

        /// <summary>
        /// 内容类型
        /// </summary>
        public HttpContentTypeEnum Type { get; set; }

        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="type">表名</param>
        public HttpContentTypeAttribute(HttpContentTypeEnum type)
        {
            this.Type = type;
        }
    }
}
