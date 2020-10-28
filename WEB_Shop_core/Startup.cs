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
using WEB_Shop_core.Data;


using Microsoft.EntityFrameworkCore;

namespace WEB_Shop_core
{
    public class Startup
    {

        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //string connection = Configuration.GetConnectionString("DefaultConnection");
            //// добавляем контекст AppDBContext в качестве сервиса в приложение
            //services.AddDbContext<AppDBContent>(options => options.UseSqlServer(connection));
            string connection = "Server=DESKTOP-1CRVPTK\\ISIP_D_A_PAHOMOV;Database=Test;Trusted_Connection=True;";

            services.AddDbContext<AppDBContent>(op => op.UseSqlServer(connection));

            services.AddMvc();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseStaticFiles();



            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "Product_card",
                   pattern: "Product_card",
                   defaults: new { controller = "Home", action = "Product_card" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
