using Microsoft.EntityFrameworkCore;

namespace BOK.Models
{
    public class BOKDbContext : DbContext
    {
        public BOKDbContext(DbContextOptions<BOKDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}