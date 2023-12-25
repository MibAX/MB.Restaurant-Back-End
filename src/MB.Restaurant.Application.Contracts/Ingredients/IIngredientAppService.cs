using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MB.Restaurant.Ingredients
{
    public interface IIngredientAppService :
        ICrudAppService<
            IngredientDetailsDto,
            IngredientDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateIngredientDto,
            UpdateIngredientDto>
    {
    }
}
