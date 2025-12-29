using PatrolApp.Domain.Entities;
using System.Linq.Expressions;

namespace PatrolApp.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(int id);

    }
}

/*
 
IQueryable, LINQ sorgularının veritabanı gibi uzak veri kaynaklarına “sorgu olarak taşınmasını” sağlayan arayüzdür.
Yani sorgun C# içinde çalışmaz; SQL’e dönüştürülüp database tarafında çalışır.

IQueryable, LINQ sorgularını ertelenmiş (deferred) şekilde tutar ve yürütmeyi veri kaynağına bırakır.
Sonuç ancak .ToList(), .First(), .Single() gibi bir “materialize” işlemi yapıldığında çekilir.

- Server-Side Execution:Sorgu SQL’e çevrilir ve veritabanında çalışır.
    Daha hızlı
    Daha az veri taşınır
    Performans artar
- Deferred Execution (Ertelenmiş Çalışma): Sorgu hemen çalışmaz. Sen geliştirmeye devam ettikçe büyür. Son noktada çalışır → esneklik sağlar.
- Expression Tree Kullanır: IQueryable, sorguyu expression tree olarak taşır. EF Core veya provider bunu SQL’e dönüştürür.
- Filtreleme, Paging, Projection Her Şey DB’de Çalışır:
    ✔ Where
    ✔ Select
    ✔ OrderBy
    ✔ Skip / Take
    ✔ Join
Hepsi database tarafında yapılır → performans

Dikkat Edilecek Noktalar:
    - ToList() erken çağrılırsa avantaj kaybedersin
    - IQueryable üzerinde C# çalışamayan methodlar hata verir
    - Client evaluation yapılırsa performans düşebilir

 */