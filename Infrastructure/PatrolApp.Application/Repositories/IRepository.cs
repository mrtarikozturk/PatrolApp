using Microsoft.EntityFrameworkCore;

namespace PatrolApp.Application.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
    }
}


/*
 SRP ve Interface Sefgragation prensiplerine uygun hale gelir. 
- CQRS Mantığına Uyum

Bu yapı küçük bir CQRS alt yapısı gibi çalışır.

Büyük projelerde scaling ve maintainability ciddi anlamda kolaylaşır.

İleride istersen query tarafına caching, read database, projection gibi şeyler çok rahat eklenir.

Command tarafına transaction ve domain event desteği çok rahat eklenir.
Test Edilebilirlik Artar

- Unit test’lerde:
    Query testleri ayrı
    Command testleri ayrı
    daha okunabilir ve izole hale gelir.
- IReadRepository içinde IQueryable döndürüp:
    LINQ kullanılmasına izin verebilirsin
    Over abstraction sorununu azaltırsın

- Gereksiz Abstraction Yaratma: Sırf pattern olsun diye repository yazma.EF Core zaten güçlü bir abstraction.
- Generic Repository Overkill Hatasına Düşme: Her şeyi aşırı generic yaparsan okunabilirlik düşer. Pragmatik ol. 
- Transaction ve SaveChanges Stratejisini Net Belirle: SaveChanges() repository’de mi?  UnitOfWork mü var? Yoksa servis katmanında mı?

*/