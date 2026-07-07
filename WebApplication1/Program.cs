using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.EfModels;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Models.EfModels;
using WebApplication1.Controllers;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ESTOReSQL2025Context>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ESTORESQL2025") ?? throw new InvalidOperationException("Connection string 'ESTORESQL2025Context' not found.")));
            

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<OrderService>();

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
