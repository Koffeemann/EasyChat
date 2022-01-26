using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace EasyChat
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IHostingEnvironment hostEnv) {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbconf.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(options => options.UseNpgsql(_confString.GetConnectionString("DefaultConnection")));
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chat");
            });
        }
    }
}
