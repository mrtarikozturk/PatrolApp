using PatrolApp.Application.Repositories;
using PatrolApp.Domain.Entities;
using PatrolApp.Persistence.Contexts;

namespace PatrolApp.Persistence.Repositories
{
    public class OfficerReadRepository : ReadRepository<Officer>, IOfficerReadRepository
    {
        public OfficerReadRepository(MSSQLDbContext context) : base(context)
        {
        }
    }
}
