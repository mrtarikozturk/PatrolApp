using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PatrolApp.Application.Repositories;
using PatrolApp.Domain.Entities;
using PatrolApp.Persistence.Contexts;

namespace PatrolApp.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly MSSQLDbContext _context;

        public WriteRepository(MSSQLDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T item)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(item);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddAsync(List<T> items)
        {
            await Table.AddRangeAsync(items);
            return true;
        }

        public bool Remove(T item)
        {
            EntityEntry<T> entityEntry = Table.Remove(item);
            return entityEntry.State == EntityState.Deleted;
        }
        public async Task<bool> Remove(int Id)
        {
            T item = await Table.FirstOrDefaultAsync(x => x.Id == Id);
            return Remove(item);
        }

        public bool Update(T item)
        {
            EntityEntry<T> entityEntry = Table.Update(item);
            return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

    }
}
