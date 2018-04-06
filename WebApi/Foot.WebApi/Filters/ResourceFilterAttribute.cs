using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kebue.Core.API.Filters
{
    /// <summary>
    /// 资源过滤器是第二个运行，在 Authorization Filter 之后，Model Binding 之前执行。在性能方面，资源过滤器在实现缓存或截断过滤器管道尤为重要。
    /// </summary>
    public class ResourceFilterAttribute : Attribute, IResourceFilter
    {
        private readonly ILogger<ResourceFilterAttribute> logger;

        public ResourceFilterAttribute(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<ResourceFilterAttribute>();
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            logger.LogInformation("资源过滤器ResourceFilter Executed!");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            logger.LogInformation("资源过滤器ResourceFilter Executing!");
        }
    }
}
