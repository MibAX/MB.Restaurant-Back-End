using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace MB.Restaurant.Ingredients
{
    public class UpdateIngredientDto : EntityDto<Guid>
    {
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }
        public double Price { get; set; }
    }
}
