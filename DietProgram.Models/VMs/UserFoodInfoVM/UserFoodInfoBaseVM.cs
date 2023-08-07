using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Models.VMs.UserFoodInfoVM
{
    public class UserFoodInfoBaseVM
    {
        public int? UserId { get; set; }
        public int? FoodId { get; set; }
        public DateTime EatDate { get; set; }
    }
}
