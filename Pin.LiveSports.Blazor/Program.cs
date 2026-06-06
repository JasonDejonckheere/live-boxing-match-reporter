using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Pin.LiveSports.Blazor.Data;
using Pin.LiveSports.Blazor.Hubs;
using Pin.LiveSports.Core.Entities;
using Pin.LiveSports.Infrastructure.Data;
using Pin.LiveSports.Infrastructure.Services;
using Pin.LiveSports.Core.Interfaces;
using Pin.LiveSports.Blazor.Services;
using Pin.LiveSports.Blazor.Services.Interfaces;

namespace Pin.LiveSports.Blazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();

            builder.Services.AddDbContext<BoxingDbContext>(options => 
                options.UseSqlServer(connectionString: builder.Configuration.GetConnectionString("BoxingDb")));

            //di
            builder.Services.AddScoped<ICrudService<Fighter>, FighterDbCrudService>();
            builder.Services.AddScoped<ICrudService<BoxingMatch>, BoxingMatchDbCrudService>();
            builder.Services.AddScoped<IInMemoryMatchReportService, InMemoryMatchReportService>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapHub<BoxingHub>("/sporthub");

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}