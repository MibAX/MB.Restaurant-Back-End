using Volo.Abp.Modularity;

namespace MB.Restaurant;

[DependsOn(
    typeof(RestaurantApplicationModule),
    typeof(RestaurantDomainTestModule)
    )]
public class RestaurantApplicationTestModule : AbpModule
{

}
