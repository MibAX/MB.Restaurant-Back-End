using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MB.Restaurant.Ingredients
{
    public class IngredientAppService : 
        CrudAppService<
            Ingredient,
            IngredientDetailsDto,
            IngredientDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateIngredientDto,
            UpdateIngredientDto>,
        IIngredientAppService 
    {
        public IngredientAppService(IRepository<Ingredient, Guid> ingredientRepository) 
            : base(ingredientRepository) 
        {
            
        }
    }
}
