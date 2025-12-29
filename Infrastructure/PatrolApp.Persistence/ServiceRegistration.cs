using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PatrolApp.Persistence.Contexts;

namespace PatrolApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<MSSQLDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}

// burada UseSqlServer metodununun gelebilmesi icin Microsoft.EntityFrameworkCore.SqlServer db kutuphanesininin yuklenmesi gerekiyuor.