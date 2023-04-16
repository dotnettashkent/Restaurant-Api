using Restaurant.Domain.Enums;

namespace Restaurant.Service.DTOs.Eats
{
    public class EatCreationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType Type { get; set; }
        public decimal Price { get; set; }
    }
}
