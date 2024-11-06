using Core.models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>().HasData(
                new product { Id = 1, Name = "Product 1", Description = "Description for Product 1", Price = 10.99, PictureUrl = "url1.jpg" },
                new product { Id = 2, Name = "Product 2", Description = "Description for Product 2", Price = 20.99, PictureUrl = "url2.jpg" },
                new product { Id = 3, Name = "Product 3", Description = "Description for Product 3", Price = 30.99, PictureUrl = "url3.jpg" }
            );
        }
    }
}
