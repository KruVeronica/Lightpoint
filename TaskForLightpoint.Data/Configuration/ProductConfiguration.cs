using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskForLightpoint.Models;

namespace TaskForLightpoint.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.Property(p => p.Name)
                .IsRequired(true);
            builder.Property(p => p.Description)
                .IsRequired(true);

            builder.HasData
            (
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Gas grill Spirit II E-210",
                    Description = "Sleek Spirit II E-210 gas grill"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Hair Shampoo With Macadamia Oil",
                    Description = "KAYPRO shampoo 1000ml"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Toy for dogs with a squeaker (Raccoon)",
                    Description = "Triol toy 31cm"
                }
            );
        }
    }
}
