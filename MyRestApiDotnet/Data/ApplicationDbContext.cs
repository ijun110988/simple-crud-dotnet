using Microsoft.EntityFrameworkCore;
// using MyRestApi.Models;
namespace MyRestApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
    
}