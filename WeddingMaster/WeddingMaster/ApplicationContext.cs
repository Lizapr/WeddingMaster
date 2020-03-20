using Microsoft.EntityFrameworkCore;
using WeddingMaster.Models;

namespace WeddingMaster
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Review> Reviews{ get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}