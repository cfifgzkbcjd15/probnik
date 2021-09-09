using probnik.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using probnik.Data;
using probnik.Hubs;

namespace probnik
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
            services.AddRazorPages()
        .AddRazorRuntimeCompilation();
            services.AddSignalR();
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;    // ���������� email
                opts.User.AllowedUserNameCharacters = ".@abcdefghijklmnopqrstuvwxyz0123456789";
                opts.Password.RequiredLength = 5;   // ����������� �����
                opts.Password.RequireNonAlphanumeric = false;   // ��������� �� �� ���������-�������� �������
                opts.Password.RequireLowercase = true; // ��������� �� ������� � ������ ��������
                opts.Password.RequireUppercase = false; // ��������� �� ������� � ������� ��������
                opts.Password.RequireDigit = true; // ��������� �� �����
            })
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();


            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            //app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();    // ����������� ��������������
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}