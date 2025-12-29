using Microsoft.EntityFrameworkCore;
using PatrolApp.Application.Repositories;
using PatrolApp.Domain.Entities;
using PatrolApp.Persistence.Contexts;
using System.Linq.Expressions;

namespace PatrolApp.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly MSSQLDbContext _context;

        public ReadRepository(MSSQLDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public async Task<T> GetByIdAsync(int id)
            => await Table.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);
    }
}
