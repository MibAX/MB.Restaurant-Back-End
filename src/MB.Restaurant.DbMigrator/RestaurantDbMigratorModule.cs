using MB.Restaurant.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MB.Restaurant.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(RestaurantEntityFrameworkCoreModule),
    typeof(RestaurantApplicationContractsModule)
    )]
public class RestaurantDbMigratorModule : AbpModule
{
}
