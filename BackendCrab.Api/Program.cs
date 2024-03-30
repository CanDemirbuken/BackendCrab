
using Autofac.Extensions.DependencyInjection;
using Autofac;
using BackendCrab.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using BackendCrab.Api.Modules;
using BackendCrab.BusinessLayer.Mapping;
using BackendCrab.BusinessLayer.Validation;
using FluentValidation.AspNetCore;

namespace BackendCrab.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddFluentValidation(x =>
            {
                x.RegisterValidatorsFromAssemblyContaining<CompanyDTOValidator>();
                x.RegisterValidatorsFromAssemblyContaining<EmployeeDTOValidator>();
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
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
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
