using DietProgram.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Entities
{
    public class UserInfo:BaseEntity
    {
        
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int? WCircum { get; set; }
        public int? HCircum { get; set; }
        public int? NCircum { get; set; }
        public string Activite { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int TotalCalorie { get; set; }
    }
}
