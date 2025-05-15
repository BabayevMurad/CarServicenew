using CarService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarService.DataAccess
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<CarRepair> CarsRepair { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detail>()
                .Property(d => d.Price)
                .HasColumnType("DECIMAL(18,2)");

            modelBuilder.Entity<CartDetail>()
              .Property(d => d.Price)
              .HasColumnType("DECIMAL(18,2)");

            modelBuilder.Entity<User>()
              .Property(d => d.Money)
              .HasColumnType("DECIMAL(18,2)");
        }
    }
}
