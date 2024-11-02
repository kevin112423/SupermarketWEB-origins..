using Microsoft.EntityFrameworkCore;
using SupermarketWEB_origins.Models;

namespace SupermarketWEB_origins.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
