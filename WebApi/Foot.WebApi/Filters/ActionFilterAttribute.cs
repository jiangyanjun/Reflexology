using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kebue.Core.API.Filters
{
    /// <summary>
    /// 使用率最高的过滤器，在调用 Acioin 方法之前和之后执行代码。跟 Resource Filter 很类似，但 Model Binding 在之后执行。
    /// </summary>
    public class ActionFilterAttribute : Attribute, IActionFilter
    {
        private readonly ILogger<ActionFilterAttribute> logger;

        public ActionFilterAttribute(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<ActionFilterAttribute>();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            logger.LogInformation("调用 Acioin 方法后 ActionFilter Executed!");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            logger.LogInformation("调用 Acioin 方法前 ActionFilter Executing!");
        }
    }
}
