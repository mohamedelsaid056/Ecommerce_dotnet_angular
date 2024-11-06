using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // add connection string to the builder
            builder.Services.AddDbContext<ApplicationDbContext>(x => // corrected spelling of ApplicationDbContext
             {
                 x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection")); // changed to UseSqlServer
             });

            builder.services.AddScoped<IProductRepository, ProductRepository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // app.UseHttpsRedirection(); remove 

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
