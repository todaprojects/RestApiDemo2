using Microsoft.EntityFrameworkCore;
using RestApiDemo2_WebApi.Models;

namespace RestApiDemo2_WebApi.Data
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
                new Fruit {Id = 1, Name = "Apple"},
                new Fruit {Id = 2, Name = "Pear"},
                new Fruit {Id = 3, Name = "Orange"},
            });

            modelBuilder.Entity<Vegetable>().HasData(new Vegetable[]
            {
                new Vegetable {Id = 1, Name = "Carrot"},
                new Vegetable {Id = 2, Name = "Beet"},
                new Vegetable {Id = 3, Name = "Onion"},
            });
            
            modelBuilder.Entity<Cookware>().HasData(new Cookware[]
            {
                new Cookware {Id = 1, Name = "Plate"},
                new Cookware {Id = 2, Name = "Fork"},
                new Cookware {Id = 3, Name = "Spoon"},
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}