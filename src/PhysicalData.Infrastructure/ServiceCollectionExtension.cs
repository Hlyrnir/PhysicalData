using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PhysicalData.Application.Default;
using PhysicalData.Application.Interface;
using PhysicalData.Infrastructure.Persistance;

namespace PhysicalData.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructureServiceCollection(this IServiceCollection cltService)
        {
            cltService.TryAddKeyedScoped<IUnitOfWork, UnitOfWork>(DefaultKeyedServiceName.PhysicalData);

            cltService.TryAddTransient<IPhysicalDimensionRepository, PhysicalDimensionRepository>();
            cltService.TryAddTransient<ITimePeriodRepository, TimePeriodRepository>();

            return cltService;
        }

        public static IServiceCollection AddSqliteDatabase(this IServiceCollection cltService, string sConnectionStringName)
        {
            cltService.TryAddKeyedScoped<IDataAccess>(DefaultKeyedServiceName.PhysicalData, (prvService, sName) =>
            {
                IConfiguration cfgConfiguration = prvService.GetRequiredService<IConfiguration>();

                return new SqliteDataAccess(cfgConfiguration, sConnectionStringName);
            });

            return cltService;
        }
    }
}
