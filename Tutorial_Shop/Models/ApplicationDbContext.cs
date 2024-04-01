using Microsoft.EntityFrameworkCore;
using Tutorial_Shop.Models.Entities;

namespace Tutorial_Shop.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Banner> Banners { get; set; }
    }
}
