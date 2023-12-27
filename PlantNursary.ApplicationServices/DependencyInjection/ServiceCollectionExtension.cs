using Microsoft.Extensions.DependencyInjection;
using PlantNursary.ApplicationServices;

namespace PlantNursary.ApplicationServices.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) =>
           services
            .AddScoped<ImportService>()
            .AddScoped<EventService>()
            .AddScoped<PlantRemovalService>()
            .AddScoped<PlantsTransportationService>()
            .AddScoped<ReservationService>()
            .AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(ServiceCollectionExtension).Assembly);
            });
    }
}
