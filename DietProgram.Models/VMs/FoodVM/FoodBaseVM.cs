using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Models.VMs.FoodVM
{
    public class FoodBaseVM
    {
        public int CategoryId { get; set; }
        public string FoodName { get; set; }
        public double Kcal { get; set; }
        public double Protein { get; set; }
        public double Carbonhydrate { get; set; }
        public double Fat { get; set; }
        public byte[]? Picture { get; set; }
    }
}
