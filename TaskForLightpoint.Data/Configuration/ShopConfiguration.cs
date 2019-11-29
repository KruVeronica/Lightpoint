using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskForLightpoint.Models;

namespace TaskForLightpoint.Configuration
{
    public class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable("Shop");
            builder.Property(s => s.Name)
                .IsRequired(true);
            builder.Property(s => s.Adress)
                .IsRequired(true);
            builder.Property(s => s.OpeningHours)
                .IsRequired(true);
            
            builder.HasData
            (
                new Shop
                {
                    Id = Guid.NewGuid(),
                        Name = "Test 1.0",
                        Adress = "Test 1.1",
                        OpeningHours = "Test1.2"
                },
                new Shop
                {
                    Id = Guid.NewGuid(),
                    Name = "Test 2.0",
                    Adress = "Test 2.1",
                    OpeningHours = "Test2.2"
                }
            );
        }
    }
}
