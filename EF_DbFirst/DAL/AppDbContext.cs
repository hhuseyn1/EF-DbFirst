using Microsoft.EntityFrameworkCore;

namespace EF_DbFirst.DAL;

public class AppDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-HUSEYN;Initial Catalog=Test;Integrated Security=True;");
    }

}
