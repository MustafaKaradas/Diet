using DietProgram.Models;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Abstract.IServices
{
    public interface IAdminService      
    {
        ResultService<AdminLoginVM> Login(string password);
    }
}
