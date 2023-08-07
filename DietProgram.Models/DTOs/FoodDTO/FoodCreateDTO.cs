using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Models.DTOs.FoodDTO
{
    public class FoodCreateDTO : FoodBaseDTO
    {
        public int CategoryID { get; set; }
    }
}
