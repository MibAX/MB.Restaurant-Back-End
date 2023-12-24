using System.Threading.Tasks;

namespace MB.Restaurant.Data;

public interface IRestaurantDbSchemaMigrator
{
    Task MigrateAsync();
}
