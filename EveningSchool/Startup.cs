using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EveningSchool.Business.Interfaces;
using EveningSchool.Business.Services;
using EveningSchool.Migrations;
using EveningSchool.Models;
using EveningSchool.ViewModels.Mappings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EveningSchool
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
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IScheduleService, ScheduleService>();
            services.AddScoped<ISeedDatabaseService, SeedDatabaseService>();
            services.AddScoped<IArticleService, ArticleService>();
            
            services.AddAutoMapper(typeof(UserMappingProfile));
            services.AddControllersWithViews();
            
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            
            services.AddDbContext<ApplicationContext>(
                options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection"),
                        x => x.MigrationsAssembly("EveningSchool")));
            services.AddIdentity<User, IdentityRole>(options =>
                {
                    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                                                             "0123456789абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМН" +
                                                             "ОПРСТУФХЦЧШЩЪЫЬЭЮЯ_ ";
                    options.User.RequireUniqueEmail = true;
                })
                .AddEntityFrameworkStores<ApplicationContext>();
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
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseUserDestroyer();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}