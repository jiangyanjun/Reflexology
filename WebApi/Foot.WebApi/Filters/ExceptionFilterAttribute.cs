using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kebue.Core.API.Filters
{
    /// <summary>
    /// 用于为应用程序执行异常处理策略。
    /// </summary>
    public class ExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        private readonly ILogger<ExceptionFilterAttribute> logger;

        public ExceptionFilterAttribute(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<ExceptionFilterAttribute>();
        }

        public void OnException(ExceptionContext context)
        {
            logger.LogError("异常过滤器Exception Execute! Message:" + context.Exception.Message);
            context.ExceptionHandled = true;
        }
    }
}
