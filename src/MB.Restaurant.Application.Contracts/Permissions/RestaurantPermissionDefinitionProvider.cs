using MB.Restaurant.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MB.Restaurant.Permissions;

public class RestaurantPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(RestaurantPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(RestaurantPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<RestaurantResource>(name);
    }
}
