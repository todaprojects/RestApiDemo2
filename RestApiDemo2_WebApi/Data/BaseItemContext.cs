using Microsoft.EntityFrameworkCore;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Data
{
    public class BaseItemContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<Cookware> Cookwares { get; set; }

        public BaseItemContext(DbContextOptions<BaseItemContext> options) : base(options)
        {
        }

        // Seeding the initial data.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fruit>().HasData(new Fruit[]
            {
                new Fruit {Id = 1, Name = "Apple", Price = 0.50M, Quantity = 10},
                new Fruit {Id = 2, Name = "Pear", Price = 1.20M, Quantity = 20},
                new Fruit {Id = 3, Name = "Orange", Price = 0.79M, Quantity = 50},
            });
        
            modelBuilder.Entity<Vegetable>().HasData(new Vegetable[]
            {
                new Vegetable {Id = 1, Name = "Carrot", Price = 0.45M, Quantity = 120},
                new Vegetable {Id = 2, Name = "Beet", Price = 0.65M, Quantity = 14},
                new Vegetable {Id = 3, Name = "Onion", Price = 0.20M, Quantity = 5},
            });
            
            modelBuilder.Entity<Cookware>().HasData(new Cookware[]
            {
                new Cookware {Id = 1, Name = "Plate", Price = 4.50M, Quantity = 40},
                new Cookware {Id = 2, Name = "Fork", Price = 2.90M, Quantity = 80},
                new Cookware {Id = 3, Name = "Spoon", Price = 1.90M, Quantity = 60},
            });
        
            base.OnModelCreating(modelBuilder);
        }
    }
}