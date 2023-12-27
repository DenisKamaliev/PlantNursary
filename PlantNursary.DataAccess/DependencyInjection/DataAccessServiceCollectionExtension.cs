using Microsoft.Extensions.DependencyInjection;
using PlantNursary.DataAccess;


namespace PlantNursary.DataAccess.DependencyInjection;

public static class DataAccessServiceCollectionExtension
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services) =>
       services
        .AddSingleton(serviceProvider =>
        {

            return new NursaryContextFactory();
        });

}

