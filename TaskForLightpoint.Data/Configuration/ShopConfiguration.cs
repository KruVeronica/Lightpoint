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
                        Name = "Gippo",
                        Adress = "g. Minsk, Igumenskiy trakt, 30",
                        OpeningHours = "10-20"
                },
                new Shop
                {
                    Id = Guid.NewGuid(),
                    Name = "Evroopt",
                    Adress = "g. Minsk, ul. I.Goshkevicha, 3",
                    OpeningHours = "8-22"
                }
            );
        }
    }
}
