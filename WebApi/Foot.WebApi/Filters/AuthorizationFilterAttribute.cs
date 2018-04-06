using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Kebue.Core.API.Filters
{
    /// <summary>
    /// 授权过滤器 在过滤器管道中第一个执行，通常用于验证当前请求的合法性，不合法后面的管道会直接跳过。它们只有一个Before方法，不像其它大多数过滤器支持前置阶段方法和后置阶段方法。注意，您不要在授权过滤器中抛出异常，因为没有任何代码来处理异常（异常过滤器不处理它们）。
    /// </summary>
    public class AuthorizationFilterAttribute : Attribute, IAuthorizationFilter
    {
        private readonly ILogger<AuthorizationFilterAttribute> logger;

        public AuthorizationFilterAttribute(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<AuthorizationFilterAttribute>();
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string authParameter = null;

            var authValue = context.HttpContext.Request.Headers;//.Authorization;  //actionContext：Action方法请求上下文
            //if (authValue != null && authValue. == "Basic")
            //    authParameter = authValue.Parameter;  //authparameter:获取请求中经过Base64编码的（用户：密码）

            //if (string.IsNullOrEmpty(authParameter))

            //    return null;
            logger.LogInformation("授权过滤器  OnAuthorization 方法!");
        }
    }
}
