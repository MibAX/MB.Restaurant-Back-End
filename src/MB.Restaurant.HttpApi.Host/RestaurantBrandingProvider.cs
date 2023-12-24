using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MB.Restaurant;

[Dependency(ReplaceServices = true)]
public class RestaurantBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Restaurant";
}
