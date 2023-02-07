using Aspect_Injector.Sample.Repositories.DBContext;
using Aspect_Injector.Sample.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using StackExchange.Profiling;
using StackExchange.Profiling.SqlFormatters;

namespace Aspect_Injector.Sample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(
                    "v1", new OpenApiInfo {Title = "Aspect_Injector.Sample", Version = "v1"});
            });
            services.AddMiniProfiler(options =>
            {
                //访问地址路由根目录；默认为：/mini-profiler-resources
                options.RouteBasePath = "/profiler";
                //数据缓存时间
                // (options.Storage as MemoryCacheStorage).CacheDuration = TimeSpan.FromMinutes(60);
                //sql格式化设置
                options.SqlFormatter = new InlineFormatter();
                //跟踪连接打开关闭
                options.TrackConnectionOpenClose = true;
                //界面主题颜色方案;默认浅色
                options.ColorScheme = ColorScheme.Dark;

                //控制访问页面授权，默认所有人都能访问
                //options.ResultsAuthorize;
                //要控制分析哪些请求，默认说有请求都分析
                //options.ShouldProfile;

                //内部异常处理
                //options.OnInternalError = e => MyExceptionLogger(e);
            }).AddEntityFramework();
            services.AddDbContext<EPKDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("EPKDBConnection"));
                options.EnableSensitiveDataLogging();
            });
            
            
            services.AddScoped<ISampleService, SampleService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Aspect_Injector.Sample v1"));
            }

            app.UseMiniProfiler();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}