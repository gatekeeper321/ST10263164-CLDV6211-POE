using Microsoft.Extensions.Options;
using ST10263164_CLDV6211_POE.Models;

namespace ST10263164_CLDV6211_POE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //----------------------------------------------------------------------------------------------------------------------------------------------------
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(Options =>
            {
                Options.IdleTimeout = TimeSpan.FromMinutes(120);
            });
            //----------------------------------------------------------------------------------------------------------------------------------------------------

            builder.Services.AddSingleton<LoginModel>(); // Add LoginModel to the container

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Shared/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //----------------------------------------------------------------------------------------------------------------------------------------------------
            app.UseSession();
            //----------------------------------------------------------------------------------------------------------------------------------------------------

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}


