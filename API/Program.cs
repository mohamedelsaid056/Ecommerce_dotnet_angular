using Core.Interfaces;
using Infrastructure;
using Infrastructure.Data;
using Infrastructure.ProductRepository;
using Microsoft.EntityFrameworkCore;
using API.MiddleWare;

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

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            //add service for gereic repository
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseMiddleware<EcepttionMiddleWare>();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // app.UseHttpsRedirection(); remove 
            app.UseStaticFiles();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();

            //  Apply migrations at startup
            // using (var scope = app.Services.CreateScope())
            // {
            //     var services = scope.ServiceProvider;
            //     try
            //     {
            //         var context = services.GetRequiredService<ApplicationDbContext>();

            //         // Check if there are any pending migrations
            //         if (context.Database.GetPendingMigrations().Any())
            //         {
            //             // Apply any pending migrations
            //             context.Database.Migrate();

            //             // Optionally seed the database
            //             if (!context.Products.Any()) // Example check for empty table
            //             {
            //                // SeedData.Initialize(context);
            //             }
            //         }

            //         app.Logger.LogInformation("Database migrated successfully");
            //     }
            //     catch (Exception ex)
            //     {
            //         var logger = services.GetRequiredService<ILogger<Program>>();
            //         logger.LogError(ex, "An error occurred while migrating the database");
            //         throw;
            //     }
            // }



        }
    }
}
