using BlazingShop.Models;
using Microsoft.EntityFrameworkCore;
namespace BlazingShop.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Product { get; set; }
}

