using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {
        }
        public DbSet<WebApplication1.Models.Pizza>? Pizzas { get; set; }
        public DbSet<WebApplication1.Models.Customer>? Customers { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var pizzaNameConverter = new EnumToStringConverter<PizzaType>();
            var pizzaSizeConverter = new EnumToStringConverter<PizzaSize>();

            modelBuilder.Entity<Pizza>()
                .Property(p => p.PizzaName)
                .HasConversion(pizzaNameConverter);

            modelBuilder.Entity<Pizza>()
                .Property(p => p.Size)
                .HasConversion(pizzaSizeConverter);

            base.OnModelCreating(modelBuilder);
        }
    }
}