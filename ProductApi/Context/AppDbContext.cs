using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }

        public DbSet<Product> Products { get; set; }
    }
}
