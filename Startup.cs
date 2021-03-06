using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DutchTreat
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
            //services.AddRazorPages();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Add an error page
            }
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello world!");
            //});
            //app.UseDefaultFiles(); 
            app.UseStaticFiles(); // for opening html files from wwwroot directory   
            //app.useNodeModules(); axal versiebshi ar mushaobs
            app.UseRouting();
            app.UseEndpoints(cfg => {
                cfg.MapControllerRoute(name: "Fallback", pattern: "{controller}/{action}/{id?}",
                    new { controller = "App", action = "Index"}); 
            });
        }
    }
}
