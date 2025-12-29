using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PatrolApp.Application.Repositories;
using PatrolApp.Persistence.Contexts;
using PatrolApp.Persistence.Repositories;

namespace PatrolApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<MSSQLDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IOfficerReadRepository, OfficerReadRepository>();
            services.AddScoped<IOfficerWriteRepository, OfficerWriteRepository>();
        }
    }
}

// burada UseSqlServer metodununun gelebilmesi icin Microsoft.EntityFrameworkCore.SqlServer db kutuphanesininin yuklenmesi gerekiyuor.