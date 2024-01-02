using MB.Restaurant.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MB.Restaurant.Permissions;

public class RestaurantPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var restaurantGroup = context.AddGroup(RestaurantPermissions.RestaurantGroup, L("Permission:Restaurant"));


        var ingredientsPermission = restaurantGroup.AddPermission(RestaurantPermissions.Ingredients.Default, L("Permission:Ingredients"));
        ingredientsPermission.AddChild(RestaurantPermissions.Ingredients.Create, L("Permission:Ingredients.Create"));
        ingredientsPermission.AddChild(RestaurantPermissions.Ingredients.Edit, L("Permission:Ingredients.Edit"));
        ingredientsPermission.AddChild(RestaurantPermissions.Ingredients.Delete, L("Permission:Ingredients.Delete"));

        var mealsPermission = restaurantGroup.AddPermission(RestaurantPermissions.Meals.Default, L("Permission:Meals"));
        mealsPermission.AddChild(RestaurantPermissions.Meals.Create, L("Permission:Meals.Create"));
        mealsPermission.AddChild(RestaurantPermissions.Meals.Edit, L("Permission:Meals.Edit"));
        mealsPermission.AddChild(RestaurantPermissions.Meals.Delete, L("Permission:Meals.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<RestaurantResource>(name);
    }
}
