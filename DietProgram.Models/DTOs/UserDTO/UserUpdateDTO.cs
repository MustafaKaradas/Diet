﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Models.DTOs.UserDTO
{
    public class UserUpdateDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int SecurityCode { get; set; }
        public int UserInfoId { get; set; }
        public string Password { get; set; }
    }
}
