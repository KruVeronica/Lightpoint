using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskForLightpoint.Models;
using Microsoft.EntityFrameworkCore;
using TaskForLightpoint.Configuration;

namespace TaskForLightpoint.Data
{
    public class TaskForLightpointContext : DbContext
    {
        public TaskForLightpointContext(DbContextOptions<TaskForLightpointContext> options) : base(options)
        {

        }

        public DbSet<Shop> Shop { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ShopProduct> ShopProduct {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopProduct>()
                .HasKey(sp => new { sp.ShopFK, sp.ProductFK });
            modelBuilder.Entity<ShopProduct>()
                .HasOne(sp => sp.Shop)
                .WithMany(s => s.ShopProducts)
                .HasForeignKey(sp => sp.ShopFK); 
            modelBuilder.Entity<ShopProduct>()
                .HasOne(sp => sp.Product)
                .WithMany(p => p.ShopProducts)
                .HasForeignKey(sp => sp.ProductFK);

            modelBuilder.ApplyConfiguration(new ShopConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
