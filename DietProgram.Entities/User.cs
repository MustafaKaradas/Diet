using DietProgram.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Entities
{
    public class User : BaseEntity
    {  
        public string UserName { get; set; }

        public string Password { get; set; }

        public int SecurityCode { get; set; }

        public int? UserInfoId { get; set; }
        public UserInfo UserInfos { get; set; }


        public virtual ICollection<UserFoodInfo> UserFoodInfos { get; set; }
        public User()
        {
            UserFoodInfos=new HashSet<UserFoodInfo>();
        }
    }
}
