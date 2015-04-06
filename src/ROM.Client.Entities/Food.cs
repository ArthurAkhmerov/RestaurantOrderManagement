using Core.Common.Core;

namespace ROM.Business.Entities
{
    public class Food : ObjectBase
    {
        public int FoodId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Type { get; set; }
    }
}
