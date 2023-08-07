using DietProgram.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Entities
{
    public class FoodDetail:BaseEntity
    {
        public string FoodName { get; set; }
        public double BreakfastCal { get; set; }
        public double DinnerCal { get; set; }
        public double LunchCal { get; set; }
        public double SnackCal { get; set; }
        public double TakenProtein { get; set; }
        public double TakenCarbonhydrate { get; set; }
        public double TakenFat { get; set; }
        public int? FoodID { get; set; } 

        public ICollection<Food> Foodss { get; set; }
        public FoodDetail()
        {
            Foodss = new HashSet<Food>();
        }


    }
}
