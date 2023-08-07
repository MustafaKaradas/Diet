using DietProgram.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Models.DTOs.UserFoodInfoDTO
{
    public class UserFoodInfoCreateDto
    {
        public int UserID { get; set; }
        public string FoodName { get; set; }
        public int? Portion { get; set; }
        public double Kcal { get; set; }
        public string MealName { get; set; }
        public DateTime? EatDate { get; set; }
        public int TakenCalorie { get; set; }
        public double Carbonhydrate { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public State State { get; set; }


    }
}
