using MB.Restaurant.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MB.Restaurant;

[DependsOn(
    typeof(RestaurantEntityFrameworkCoreTestModule)
    )]
public class RestaurantDomainTestModule : AbpModule
{

}
