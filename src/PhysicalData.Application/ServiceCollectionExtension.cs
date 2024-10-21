using Microsoft.Extensions.DependencyInjection;

namespace PhysicalData.Application
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServiceCollection(this IServiceCollection cltService)
        {
            // Add mediator
            cltService.AddMediator(
                mdtOptions =>
                {
                    mdtOptions.ServiceLifetime = ServiceLifetime.Scoped;
                });

            return cltService;
        }
    }
}
