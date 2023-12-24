using System;
using System.Collections.Generic;
using System.Text;
using MB.Restaurant.Localization;
using Volo.Abp.Application.Services;

namespace MB.Restaurant;

/* Inherit your application services from this class.
 */
public abstract class RestaurantAppService : ApplicationService
{
    protected RestaurantAppService()
    {
        LocalizationResource = typeof(RestaurantResource);
    }
}
