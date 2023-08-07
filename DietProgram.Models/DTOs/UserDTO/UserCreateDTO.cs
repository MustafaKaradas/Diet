using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Models.DTOs.UserDTO
{
    public class UserCreateDTO
    {
        public int UserInfoID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int SecurityCode { get; set; }

    }
}
