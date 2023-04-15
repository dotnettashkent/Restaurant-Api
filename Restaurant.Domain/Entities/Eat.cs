using Restaurant.Domain.Commons;
using Restaurant.Domain.Enums;

namespace Restaurant.Domain.Entities
{
    public class Eat : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType Type { get; set; }
        public decimal Price { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }
    }
}
