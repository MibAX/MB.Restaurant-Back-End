using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MB.Restaurant.Data;
using Volo.Abp.DependencyInjection;

namespace MB.Restaurant.EntityFrameworkCore;

public class EntityFrameworkCoreRestaurantDbSchemaMigrator
    : IRestaurantDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreRestaurantDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the RestaurantDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<RestaurantDbContext>()
            .Database
            .MigrateAsync();
    }
}
