using Data.Models;
using Data.Repositories;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data;

public static class ServiceCollectionExtensions
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services
            .AddScoped<ILocationsRepository, LocationRepository>();
        
        services.AddDbContext<DataContext>(options =>
        {
            options.UseInMemoryDatabase("InMemoryDatabase");
        });
    }
}