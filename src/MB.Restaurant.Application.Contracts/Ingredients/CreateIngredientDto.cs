using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace MB.Restaurant.Ingredients
{
    public class CreateIngredientDto : EntityDto
    {
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }
        public double Price { get; set; }
    }
}
