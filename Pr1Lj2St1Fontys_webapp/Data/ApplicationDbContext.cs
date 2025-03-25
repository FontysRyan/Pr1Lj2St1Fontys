using Microsoft.EntityFrameworkCore;
using Pr1Lj2St1Fontys_webapp.Models;

namespace Pr1Lj2St1Fontys_webapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EventModel> Events { get; set; } // This bind the database with the Event-class
        public object Evenementen { get; internal set; }
    }
}
