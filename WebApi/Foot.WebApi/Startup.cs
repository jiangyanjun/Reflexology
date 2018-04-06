using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Kebue.Core.Util;
using Kebue.Core.API.Filters;

namespace Foot.WebApi
{
    public class Startup
    {
        public const string Cors = "CorsAllowDomain";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            #region 读取配置文件
            StaticStr.DatabaseConnectionStr = Configuration.GetConnectionString(Configuration["ConnectionDatabaseType"]);
            #endregion
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            #region 注入MVC框架
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(AuthorizationFilterAttribute));
                options.Filters.Add(typeof(ResourceFilterAttribute));
                options.Filters.Add(typeof(ActionFilterAttribute));
                options.Filters.Add(typeof(ExceptionFilterAttribute));
                options.Filters.Add(typeof(ResultFilterAttribute));
            });
            #endregion

            #region 跨域访问注册
            services.AddCors(o => o.AddPolicy(Cors, p => p.
                   WithOrigins(Configuration[Cors].Split(",")).//允许来源主机访问
                   AllowAnyMethod().
                   AllowAnyHeader().
                   AllowCredentials()//允许指定处理Cookie
               ));
            #endregion
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            #region 路由注册
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=api}/{action=Default}/{id?}");
            });
            #endregion

            #region 跨域调用
            app.UseCors(Cors);
            #endregion

            #region 环境判断
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            #endregion
        }
    }
}
