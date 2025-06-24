using Bookstore.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace Bookstore.Web.Startup
{
    public static class MiddlewareSetup
    {
        public static async Task<WebApplication> ConfigureMiddlewareAsync(this WebApplication app)
        {
            app.Use((context, next) =>
            {
                context.Request.Scheme = "https";
                return next(context);
            });

            if (app.Environment.IsDevelopment())
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
            app.UseSession();

            app.MapAreaControllerRoute(
                name: "Admin",
                areaName: "Admin",
                pattern: "Admin/{controller=Orders}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Create the database
            using (var scope = app.Services.CreateAsyncScope())
            {
                var dbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();

                if (dbContext == null)
                {
                    Console.WriteLine("❌ ApplicationDbContext е null. Провери дали е регистриран во ConfigureServices.");
                }
                else
                {
                    try
                    {
                        Console.WriteLine("⏳ Pokušuvam EnsureCreatedAsync...");
                        await dbContext.Database.EnsureCreatedAsync();
                        Console.WriteLine("✅ Database ensured.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"❌ Грешка при EnsureCreatedAsync: {ex.Message}");
                    }
                }
            }


            return app;
        }
    }
}
