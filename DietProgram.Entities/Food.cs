using DietProgram.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Entities
{
    public class Food : BaseEntity
    {

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public string FoodName { get; set; }
        public double Kcal { get; set; }
        public double Protein { get; set; }
        public double Carbonhydrate { get; set; }
        public double Fat { get; set; }
        public byte[]? Picture { get; set; }

        public FoodDetail? FoodDetails{ get; set; }
        public int? FoodDetailID { get; set; }

        public virtual ICollection<UserFoodInfo> UserFoodInfos { get; set; }
        public Food()
        {
            UserFoodInfos = new HashSet<UserFoodInfo>();
        }

    }
}
