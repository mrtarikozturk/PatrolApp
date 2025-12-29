using Microsoft.EntityFrameworkCore;
using PatrolApp.Domain.Entities;

namespace PatrolApp.Persistence.Contexts
{
    public class MSSQLDbContext : DbContext
    {
        public MSSQLDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Officer> Officers { get; set; }
    }
}
