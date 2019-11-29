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
                    Name = "Test 1.0",
                    Description = "Test 1.1"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Test 2.0",
                    Description = "Test 2.1"
                }
            );
        }
    }
}
