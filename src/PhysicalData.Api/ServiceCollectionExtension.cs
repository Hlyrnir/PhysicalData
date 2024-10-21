using Passport.Abstraction.Authentication;
using PhysicalData.Application;
using PhysicalData.Infrastructure;

namespace PhysicalData.Api
{
    public static class ServiceCollectionExtension
    {
        public static PhysicalDataServiceCollectionBuilder AddPhysicalDataServiceCollection<T>(this IServiceCollection cltService, Func<IServiceProvider, IAuthenticationTokenHandler<T>>? dlgAuthentication = null)
        {
            cltService.AddApplicationServiceCollection();
            cltService.AddInfrastructureServiceCollection();

            return new PhysicalDataServiceCollectionBuilder(cltService);
        }
    }
}