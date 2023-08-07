using DietProgram.Core.BaseEntities;
using DietProgram.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Entities
{
    public class UserFoodInfo : BaseEntity
    {
        public int? UserId { get; set; }
        public int? FoodId { get; set; }
        public string  FoodName { get; set; }
        public double Kcal { get; set; }

        public int? Portion { get; set; }
        public string MealName { get; set; }
        public DateTime? EatDate { get; set; }
        public int TakenCalorie { get; set; }
         public double Protein { get; set; }
        public double Carbonhydrate { get; set; }
        public double Fat { get; set; }
        
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public UserFoodInfo()
        {
            Users= new HashSet<User>();
            Foods= new HashSet<Food>();
        }

    }
}
