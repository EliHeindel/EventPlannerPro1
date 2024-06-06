using EventPlannerPro.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace EventPlannerPro.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
