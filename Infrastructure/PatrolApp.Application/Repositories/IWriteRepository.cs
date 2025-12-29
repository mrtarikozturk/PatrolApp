namespace PatrolApp.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T item);
        Task<bool> AddAsync(List<T> items);
        Task<bool> Remove(T item);
        Task<bool> UpdateAsync(T item);
    }
}
