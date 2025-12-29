using PatrolApp.Application.Repositories;
using PatrolApp.Domain.Entities;
using PatrolApp.Persistence.Contexts;

namespace PatrolApp.Persistence.Repositories
{
    public class OfficerWriteRepository : WriteRepository<Officer>, IOfficerWriteRepository
    {
        public OfficerWriteRepository(MSSQLDbContext context) : base(context)
        {
        }
    }
}
