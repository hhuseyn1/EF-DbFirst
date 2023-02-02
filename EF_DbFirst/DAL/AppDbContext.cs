using Microsoft.EntityFrameworkCore;

namespace EF_DbFirst.DAL;

public class AppDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }

}
