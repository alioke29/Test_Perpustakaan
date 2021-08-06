using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

using Microsoft.AspNetCore.Authentication.Cookies;

using TestPerpustakaan_VS2019.Models;
using TestPerpustakaan_VS2019.Library.Entities;
using TestPerpustakaan_VS2019.Library.Utilities;

using Microsoft.Extensions.Primitives;

using Microsoft.Extensions.Hosting;
using NWebsec.AspNetCore.Core;
using NWebsec.AspNetCore.Middleware;

using Microsoft.EntityFrameworkCore.InMemory;


namespace TestPerpustakaan_VS2019
{
    public class Startup
    {
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
        {

            var builder = new ConfigurationBuilder()
                             .AddJsonFile("appsettings.json")
                             .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                builder.SetBasePath(env.ContentRootPath);
            }


            builder.AddEnvironmentVariables();
            Configuration = builder.Build();

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlServer()
                    .AddDbContext<ApplicationDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")))
                     .AddDbContext<DatabaseContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));


            // FOR IDENTITY USER AND COOKIE
            //services.AddDbContext<ApplicationDbContext>(options =>
            //                options.UseInMemoryDatabase("InMemoryDB"));

            //services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            //services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();


            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "InMemoryDB";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/Login/Index"; // Set here login path.
                options.SlidingExpiration = true; // resets cookie expiration if more than half way through lifespan
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            });


            // FOR SESSION
            services.AddTransient<SessionUtility>();
            services.AddHttpContextAccessor();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.IsEssential = true;
            });



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddMvc().AddJsonOptions(o =>
            {
                o.JsonSerializerOptions.PropertyNamingPolicy = null;
                o.JsonSerializerOptions.DictionaryKeyPolicy = null;
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => false; // Default is true, make it false
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            // HTTP Strict Transport Security
            services.AddHsts(options =>
            {
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(365);
                options.Preload = true;
            });
               

            // Add framework services.
            services.AddControllersWithViews();

            services.AddRazorPages();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // [HSTS] HTTP Strict Transport Security Header
                app.UseHsts();

                // X-Content-Type-Options Header
                app.UseXContentTypeOptions();

                // X-XSS-Protection Header
                app.UseXXssProtection(options => options.EnabledWithBlockMode());

                // X-Frame-Options Header
                app.UseXfo(options => options.SameOrigin());

                // Referrer-Policy Http Reader
                app.UseReferrerPolicy(options => options.NoReferrer());

                //Feature-Policy
                app.Use(async (context, next) =>
                {
                    if (!context.Response.Headers.ContainsKey("Feature-Policy"))
                    {
                        context.Response.Headers.Add("Feature-Policy", "accelerometer 'none'; camera 'none'; microphone 'none';");
                    }
                    await next();
                });

            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    //pattern: "{controller=Home}/{action=Index}/{id?}");
                    pattern: "{controller=Login}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });

      
        }

    }
}
