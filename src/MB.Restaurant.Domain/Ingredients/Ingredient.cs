using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MB.Restaurant.Ingredients
{
    public class Ingredient : AuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
    }
}
