﻿using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class MarketContext:DbContext
    {
        public MarketContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Beverage", Description = "Beverage" },
                new Category { CategoryId = 2, Name = "Bakery", Description = "Bakery" },
                new Category { CategoryId = 3, Name = "Meat", Description = "Meat" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, Name = "Bournvita", Quantity = 100, Price = 750 },
                new Product { ProductId = 2, CategoryId = 1, Name = "Frosty Ale", Quantity = 200, Price = 500 },
                new Product { ProductId = 3, CategoryId = 2, Name = "SugarVille Coconut Bread", Quantity = 300, Price = 500 },
                new Product { ProductId = 4, CategoryId = 2, Name = "SugarVille Banana Bread", Quantity = 100, Price = 3500 }
                );
        }

    }
}