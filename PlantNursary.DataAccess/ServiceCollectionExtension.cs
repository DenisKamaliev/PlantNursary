
using PlantNursary.DataAccess;


namespace Microsoft.Extensions.DependencyInjection;

public static class DataAccessServiceCollectionExtension
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services) =>
       services
        .AddSingleton<NursaryContextFactory>(serviceProvider =>
        {

            return new NursaryContextFactory();
        });

}

