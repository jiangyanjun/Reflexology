using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kebue.Core.API.Filters
{
    /// <summary>
    /// 当 Action 执行完成后，最后会执行过滤器。用于处理ActionResult结果输出策略。
    /// </summary>
    public class ResultFilterAttribute : Attribute, IResultFilter
    {
        private readonly ILogger<ResultFilterAttribute> logger;

        public ResultFilterAttribute(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<ResultFilterAttribute>();
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            logger.LogInformation("Action 执行完成后返回后ResultFilter Executd!");
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            logger.LogInformation("Action 执行完成后 返回前ResultFilter Executing!");
        }
    }
}
