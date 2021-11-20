using lab5.Entities;
using Microsoft.EntityFrameworkCore;

namespace lab5.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
