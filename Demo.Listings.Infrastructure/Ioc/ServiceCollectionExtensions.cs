using Demo.Listings.Domain.Interfaces;
using Demo.Listings.Domain.Services;
using Demo.Listings.Infrastructure.DataAccess;
using Demo.Listings.Infrastructure.DataAccess.EF;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        services.AddSingleton(new ListingsDbContext());
        services.AddScoped<ListingsService>();
        services.AddScoped<IListingsRepository, ListingsRepository>();
        
        return services;
    }
}

