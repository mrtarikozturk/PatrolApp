using PatrolApp.Domain.Entities;

namespace PatrolApp.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T item);
        Task<bool> AddAsync(List<T> items);
        bool Remove(T item);
        Task<bool> Remove(int id);
        bool Update(T item);

        Task<int> SaveAsync();
    }
}
