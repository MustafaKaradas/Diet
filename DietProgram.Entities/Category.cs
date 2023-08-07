using DietProgram.Core.BaseEntities;

namespace DietProgram.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int? FoodId { get; set; }
        public ICollection<Food> Foods { get; set; }

        public Category()
        {
            Foods = new HashSet<Food>();
        }

    }
}