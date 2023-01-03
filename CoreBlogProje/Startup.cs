using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogProje
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>();
            services.AddControllersWithViews();
            //Proje bazl� authorize i�lemi ba�lang��
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
            //E�er  sayfaya girme yetkisi yoksa uyar� mesaj� verdirme ba�lang��
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10000); //oturumun a��k kalma s�resi
                options.AccessDeniedPath = "/ErrorPage/Index/";
                options.LoginPath = "/Login/Index/";
            });
            //E�er  sayfaya girme yetkisi yoksa uyar� mesaj� verdirme biti�
            //Proje bazl� authorize i�lemi biti�
            services.AddIdentity<WriterUser, WriterRole>().AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();
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
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Page404/");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            //Error Sayfa ba�lang��

            //Error Sayfa Biti�
            //Login i�leminden sonra kullan�c� bilgilerine eri�mek i�in  Authentication tan�mlamas� ba�lang�c
            app.UseAuthentication();
            //Login i�leminden sonra kullan�c� bilgilerine eri�mek i�in  Authentication tan�mlamas� biti�
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blog}/{action=Index}/{id?}");
            });
            //Area ekledim
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
               name: "Areas",
               pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
