using AutoMapper;

namespace MB.Restaurant.Ingredients
{
    public class IngredientAutoMapperProfile : Profile
    {
        public IngredientAutoMapperProfile()
        {
            CreateMap<Ingredient, IngredientDto>();
            CreateMap<Ingredient, IngredientDetailsDto>();
            CreateMap<CreateIngredientDto, Ingredient>();
            CreateMap<UpdateIngredientDto, Ingredient>();
        }
    }
}
