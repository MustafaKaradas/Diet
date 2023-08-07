﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Models.VMs.UserVM
{
    public class UserDetailVM
    {
        public int UserId { get; set; }
        public int? UserInfoId { get; set; }
        public string UserName{ get; set; }
        public string Password { get; set; }
        public int SecurityCode { get; set; }
    }
}
