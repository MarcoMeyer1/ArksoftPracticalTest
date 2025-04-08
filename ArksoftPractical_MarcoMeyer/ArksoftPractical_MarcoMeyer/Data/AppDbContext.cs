using Microsoft.EntityFrameworkCore;
using ArksoftPractical_MarcoMeyer.Models;

namespace ArksoftPractical_MarcoMeyer.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
