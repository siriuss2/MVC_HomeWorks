using BurgerApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.DataAccess.DataContext
{
    public class BurgerAppDbContext : DbContext
    {
        public BurgerAppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Burger>()
                .Property(x => x.Price)
                .HasColumnType("decimal(6, 2)");

            modelBuilder.Entity<Burger>()
                .HasMany(x => x.OrderBurger)
                .WithOne(x => x.Burger)
                .HasForeignKey(x => x.BurgerId);

            modelBuilder.Entity<Order>()
                .HasMany(x => x.OrderBurger)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Location>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId);

            modelBuilder.Entity<Burger>()
                .HasData(
                new Burger
                {
                    Id = 1,
                    Name = "Chicken Burger",
                    HasFries = true,
                    IsVegan = true,
                    IsVegetarian = false,
                    Price = 3.99m
                },
                new Burger
                {
                    Id = 2,
                    Name = "Beyond Burger",
                    HasFries = false,
                    IsVegan = false,
                    IsVegetarian = true,
                    Price = 4.99m
                });

            modelBuilder.Entity<Order>()
                .HasData(
                new Order
                {
                    Id = 1,
                    IsDelivered = true,
                    FullName = "John Doe",
                    Address = "Partizanska 10",
                    LocationId = 2,
                },
                new Order
                {
                    Id = 2,
                    IsDelivered = false,
                    FullName = "Kate Katesky",
                    Address = "Mladinska 1",
                    LocationId = 1,
                });

            modelBuilder.Entity<Location>()
                .HasData(
                new Location
                {
                    Id = 1,
                    Name = "Pizza Pizza",
                    OpensAt = "10:00",
                    ClosesAt = "23:00",
                    Address = "Opstina Centar"
                },
                new Location
                {
                    Id = 2,
                    Name = "Pizza Skopje",
                    OpensAt = "09:00",
                    ClosesAt = "22:00",
                    Address = "Opstina Kisela Voda"
                });
        }
    }
}
