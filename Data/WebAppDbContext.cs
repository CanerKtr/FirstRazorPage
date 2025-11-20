using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class WebAppDbContext : DbContext
    {
        public WebAppDbContext(DbContextOptions<WebAppDbContext> options) : base(options)
        {
        }
        public DbSet<WebApplication1.Models.Pizza>? Pizzas { get; set; }
        public DbSet<WebApplication1.Models.Customer>? Customers  { get; set; }
    }
}
