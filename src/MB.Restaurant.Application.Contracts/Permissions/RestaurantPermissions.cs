namespace MB.Restaurant.Permissions;

public static class RestaurantPermissions
{
    public const string RestaurantGroup = "Restaurant";

    public static class Ingredients
    {
        public const string Default = RestaurantGroup + ".Ingredients";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }

    public static class Meals
    {
        public const string Default = RestaurantGroup + ".Meals";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
