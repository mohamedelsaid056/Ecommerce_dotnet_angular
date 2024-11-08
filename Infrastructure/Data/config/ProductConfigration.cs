using Core.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.config
{
    public class ProductConfigration : IEntityTypeConfiguration<product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<product> builder)
        {
            //builder.Property(p => p.Id).IsRequired();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Description).IsRequired().HasMaxLength(180);
            builder.Property(e => e.Price).IsRequired();
            builder.Property(e => e.PictureUrl).IsRequired();
            builder.HasOne(e => e.ProductBrand).WithMany().HasForeignKey(e => e.ProductBrandId);
            builder.HasOne(e => e.ProductType).WithMany().HasForeignKey(e => e.ProductTypeId);



        }


    }
}
