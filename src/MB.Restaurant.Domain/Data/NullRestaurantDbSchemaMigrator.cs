using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MB.Restaurant.Data;

/* This is used if database provider does't define
 * IRestaurantDbSchemaMigrator implementation.
 */
public class NullRestaurantDbSchemaMigrator : IRestaurantDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
