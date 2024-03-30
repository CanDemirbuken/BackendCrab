using Autofac.Extensions.DependencyInjection;
using Autofac;
using BackendCrab.BusinessLayer.Mapping;
using BackendCrab.BusinessLayer.Validation;
using BackendCrab.Core.DTOs.CompanyDTOs;
using BackendCrab.DataAccessLayer;
using BackendCrab.UI.Modules;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using BackendCrab.UI.Services;
using Autofac.Core;

namespace BackendCrab.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews().AddFluentValidation(x =>
            {
                x.RegisterValidatorsFromAssemblyContaining<CompanyDTOValidator>();
                x.RegisterValidatorsFromAssemblyContaining<EmployeeDTOValidator>();
            });

            builder.Services.AddHttpClient<CompanyApiService>(client =>
            {
                client.BaseAddress = new Uri(builder.Configuration["BaseUrl"]);
            });

            builder.Services.AddHttpClient<EmployeeApiService>(client =>
            {
                client.BaseAddress = new Uri(builder.Configuration["BaseUrl"]);
            });

            builder.Services.AddAutoMapper(typeof(MapProfile));

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), opt =>
                {
                    opt.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
                });
            });

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new CustomModule()));

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
