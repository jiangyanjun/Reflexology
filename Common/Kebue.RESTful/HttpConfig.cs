namespace Kebue.RESTful
{
    /// <summary>
    /// Http请求参数
    /// </summary>
    public class HttpConfig
    {
        public HttpConfig(string controllerName)
        {
            BaseUrl = controllerName;
        }
        /// <summary>
        /// 根路径
        /// </summary>
        internal static string BaseUrl { get; set; }

        /// <summary>
        /// 内容类型
        /// </summary>
        public string _contentType;
        public string ContentType
        {
            get
            {
                if (string.IsNullOrEmpty(_contentType))
                {
                    _contentType = "application/json";
                }
                return _contentType;
            }
            set
            {
                value = _contentType;
            }
        }

        /// <summary>
        /// 请求内容缓冲大小
        /// </summary>
        public long _contentSize;
        public long ContentSize
        {
            get
            {
                if (_contentSize <= 0)
                {
                    _contentSize = int.MaxValue;
                }
                return _contentSize;
            }
            set
            {
                value = _contentSize;
            }
        }

        /// <summary>
        /// 超时时间
        /// </summary>
        private double _timeout;
        public double Timeout
        {
            get
            {
                if (_timeout <= 0)
                {
                    _timeout = 3000;
                }
                return _timeout;
            }
            set
            {
                value = _timeout;
            }
        }
    }
}
