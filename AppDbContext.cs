using Microsoft.EntityFrameworkCore;

namespace TestCoreWebAppMVC.Models.DataConn
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Items> Items { get; set; } 

    }
}
