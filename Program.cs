using CeroCuadrado.Data.Repository.Implementations;
using CeroCuadrado.Data.Repository.Interfaces;
using CeroCuadrado.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Abstractions;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace CeroCuadrado
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://localhost:3000") // Reemplaza esta URL con la URL de tu aplicación frontend
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });
            //"ConnectionStrings:CeroCuadradoAPIDBConnectionString"
            builder.Services.AddDbContext<PresupuestoContext>(dbContextOptions => dbContextOptions.UseSqlServer(
                builder.Configuration["ConnectionStrings:CeroCuadradoAPIDBConnectionString"]));



            // ejemplo para armar  la inyeccion de dependencia en esta app
            #region DependencyInjections
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddScoped<IPresupRepository, PresupRepository>();
            #endregion





            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors();
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
