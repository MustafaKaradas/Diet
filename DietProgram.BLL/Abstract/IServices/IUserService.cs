using DietProgram.Models;
using DietProgram.Models.DTOs.UserDTO;
using DietProgram.Models.VMs.FoodVM;
using DietProgram.Models.VMs.UserVM;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Abstract.IServices
{
    public interface IUserService
    {
        ResultService<UserCreateDTO> Create(UserCreateVM createVM);
        ResultService<UserUpdateDTO> Update(UserUpdateVM updateVM);
        ResultService<UserLoginVM> Login(string username, string password);

        ResultService<List<UserDetailVM>> GetAll();

       
    }
}
