using Restaurant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Service.DTOs.Eats
{
    public class EatUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType Type { get; set; }
        public decimal Price { get; set; }
    }
}
