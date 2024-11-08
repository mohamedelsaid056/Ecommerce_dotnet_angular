using Core.models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //  i need to add the configuration for the product entity
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            SeedData(modelBuilder);

        }

        private void SeedData(ModelBuilder modelBuilder)
        {

            // Add the new products to the seeding data
            var products = CreateProducts();
            modelBuilder.Entity<product>().HasData(products);

            // Add the new product brands to the seeding data
            var productBrands = CreateProductBrands();
            modelBuilder.Entity<ProductBrand>().HasData(productBrands);

            // Add the new product types to the seeding data
            var productTypes = CreateProductTypes();
            modelBuilder.Entity<ProductType>().HasData(productTypes);
        }

        private List<product> CreateProducts()
        {
            return new List<product>
    {
        new product
        {
            Id = 1,
            Name = "Angular Speedster Board 2000",
            Description = "Description 1",
            Price = 200,
            PictureUrl = "images/products/sb-ang1.png",
            ProductTypeId = 1,
            ProductBrandId = 1
        },
        new product
        {
            Id = 2,
            Name = "Green Angular Board 3000",
            Description = "Description 2",
            Price = 150,
            PictureUrl = "images/products/sb-ang2.png",
            ProductTypeId = 1,
            ProductBrandId = 1
        },
        new product
        {
            Id = 3,
            Name = "Core Board Speed Rush 3",
            Description = "Description 3",
            Price = 180,
            PictureUrl = "images/products/sb-core1.png",
            ProductTypeId = 1,
            ProductBrandId = 2
        },
        new product
        {
            Id = 4,
            Name = "Net Core Super Board",
            Description = "Description 4",
            Price = 300,
            PictureUrl = "images/products/sb-core2.png",
            ProductTypeId = 1,
            ProductBrandId = 2
        },
        new product
        {
            Id = 5,
            Name = "React Board Super Whizzy Fast",
            Description = "Description 5",
            Price = 250,
            PictureUrl = "images/products/sb-react1.png",
            ProductTypeId = 1,
            ProductBrandId = 4
        },
        new product
        {
            Id = 6,
            Name = "Typescript Entry Board",
            Description = "Description 6",
            Price = 120,
            PictureUrl = "images/products/sb-ts1.png",
            ProductTypeId = 1,
            ProductBrandId = 5
        },
        new product
        {
            Id = 7,
            Name = "Core Blue Hat",
            Description = "Description 7",
            Price = 10,
            PictureUrl = "images/products/hat-core1.png",
            ProductTypeId = 2,
            ProductBrandId = 2
        },
        new product
        {
            Id = 8,
            Name = "Green React Woolen Hat",
            Description = "Description 8",
            Price = 8,
            PictureUrl = "images/products/hat-react1.png",
            ProductTypeId = 2,
            ProductBrandId = 4
        },
        new product
        {
            Id = 9,
            Name = "Purple React Woolen Hat",
            Description = "Description 9",
            Price = 15,
            PictureUrl = "images/products/hat-react2.png",
            ProductTypeId = 2,
            ProductBrandId = 4
        },
        new product
        {
            Id = 10,
            Name = "Blue Code Gloves",
            Description = "Description 10",
            Price = 18,
            PictureUrl = "images/products/glove-code1.png",
            ProductTypeId = 4,
            ProductBrandId = 3
        },
        new product
        {
            Id = 11,
            Name = "Green Code Gloves",
            Description = "Description 11",
            Price = 15,
            PictureUrl = "images/products/glove-code2.png",
            ProductTypeId = 4,
            ProductBrandId = 3
        },
        new product
        {
            Id = 12,
            Name = "Purple React Gloves",
            Description = "Description 12",
            Price = 16,
            PictureUrl = "images/products/glove-react1.png",
            ProductTypeId = 4,
            ProductBrandId = 4
        },
        new product
        {
            Id = 13,
            Name = "Green React Gloves",
            Description = "Description 13",
            Price = 14,
            PictureUrl = "images/products/glove-react2.png",
            ProductTypeId = 4,
            ProductBrandId = 4
        },
        new product
        {
            Id = 14,
            Name = "Redis Red Boots",
            Description = "Description 14",
            Price = 250,
            PictureUrl = "images/products/boot-redis1.png",
            ProductTypeId = 3,
            ProductBrandId = 6
        },
        new product
        {
            Id = 15,
            Name = "Core Red Boots",
            Description = "Description 15",
            Price = 189.99,
            PictureUrl = "images/products/boot-core2.png",
            ProductTypeId = 3,
            ProductBrandId = 2
        },
        new product
        {
            Id = 16,
            Name = "Core Purple Boots",
            Description = "Description 16",
            Price = 199.99,
            PictureUrl = "images/products/boot-core1.png",
            ProductTypeId = 3,
            ProductBrandId = 2
        },
        new product
        {
            Id = 17,
            Name = "Angular Purple Boots",
            Description = "Description 17",
            Price = 150,
            PictureUrl = "images/products/boot-ang2.png",
            ProductTypeId = 3,
            ProductBrandId = 1
        },
        new product
        {
            Id = 18,
            Name = "Angular Blue Boots",
            Description = "Description 18",
            Price = 180,
            PictureUrl = "images/products/boot-ang1.png",
            ProductTypeId = 3,
            ProductBrandId = 1
        }
    };
        }


        private List<ProductBrand> CreateProductBrands()
        {
            return new List<ProductBrand>
            {
                new ProductBrand
                {
                    Id = 1,
                    Name = "Angular"
                },
                new ProductBrand
                {
                    Id = 2,
                    Name = "NetCore"
                },
                new ProductBrand
                {
                    Id = 3,
                    Name = "VS Code"
                },
                new ProductBrand
                {
                    Id = 4,
                    Name = "React"
                },
                new ProductBrand
                {
                    Id = 5,
                    Name = "Typescript"
                },
                new ProductBrand
                {
                    Id = 6,
                    Name = "Redis"
                }
            };
        }

        private List<ProductType> CreateProductTypes()
        {
            return new List<ProductType>
            {
                new ProductType
                {
                    Id = 1,
                    Name = "Boards"
                },
                new ProductType
                {
                    Id = 2,
                    Name = "Hats"
                },
                new ProductType
                {
                    Id = 3,
                    Name = "Boots"
                },
                new ProductType
                {
                    Id = 4,
                    Name = "Gloves"
                }
            };
        }


    }





}

