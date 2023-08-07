using DietProgram.Models.DTOs.FoodDTO;
using DietProgram.Models.DTOs.UserFoodInfoDTO;
using DietProgram.Models.VMs.FoodVM;
using DietProgram.Models.VMs.UserFoodInfoVM;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Abstract.IServices
{
    public interface IUserFoodInfoService
    {
        ResultService<List<UserFoodInfoCreateVm>> GetMonthlyTopFood();
        ResultService<List<UserFoodInfoCreateVm>> GetWeeklyTopFood();
        ResultService<UserFoodInfoCreateDto> Create(UserFoodInfoCreateVm createVM);
        bool Delete(int id);
        ResultService<List<UserFoodInfoCreateVm>> GetAll(string mealName,int id);
    }
}
