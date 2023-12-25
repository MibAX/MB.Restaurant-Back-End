using System;
using Volo.Abp.Application.Dtos;

namespace MB.Restaurant.Ingredients
{
    public class IngredientDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
    }
}
