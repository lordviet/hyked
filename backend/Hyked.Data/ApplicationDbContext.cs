using Hyked.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hyked.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Trip> Trips { get; set; }

        //public DbSet<CarMeta> Cars { get; set; }
    }
}
