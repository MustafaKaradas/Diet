using DietProgram.Entities;
using DietProgram.Models.DTOs.FoodDTO;
using DietProgram.Models.DTOs.UserInfoDTO;
using DietProgram.Models.VMs.FoodVM;
using DietProgram.Models.VMs.UserInfoVm;
using DietProgram.Models.VMs.UserVM;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Abstract.IServices
{
    public interface IUserInfoService
    {
        double DailyTotalCalories(int age, int height, int weight, string gender, string activity);
        double TakenTotalCalories(int calories);
        double TakenMealCalories(Food food);
        ResultService<UserInfoCreateDTO> Create(UserInfoCreateVm createVM);
        ResultService<List<UserInfoCreateVm>> GetAll();
        ResultService<UserInfoUpdateVm> Update(UserInfoUpdateVm updateVM);
        bool Delete(int id);

    }
}
