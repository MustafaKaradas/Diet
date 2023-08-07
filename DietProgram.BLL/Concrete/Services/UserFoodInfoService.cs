using AutoMapper;
using DietProgram.BLL.Abstract.IServices;
using DietProgram.Core.Enums;
using DietProgram.DAL.Abstract;
using DietProgram.DAL.Concrete.Repositories;
using DietProgram.Entities;
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

namespace DietProgram.BLL.Concrete.Services
{
    public class UserFoodInfoService : IUserFoodInfoService
    {
        private readonly IUserFoodInfoRepo _userFoodInfoRepo;
        private readonly IMapper _mapper;

        public UserFoodInfoService(IUserFoodInfoRepo userFoodInfoRepo, IMapper mapper)
        {
            _mapper=mapper;
            _userFoodInfoRepo = userFoodInfoRepo;
        }

        public ResultService<UserFoodInfoCreateDto> Create(UserFoodInfoCreateVm createVM)
        {
            ResultService<UserFoodInfoCreateDto> result = new ResultService<UserFoodInfoCreateDto>();

            UserFoodInfoCreateDto createDto = _mapper.Map<UserFoodInfoCreateDto>(createVM);
            UserFoodInfo newFood = _mapper.Map<UserFoodInfo>(createDto);
            var addedFood = _userFoodInfoRepo.Create(newFood);

            if (addedFood != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
        }

        public bool Delete(int id)
        {
            UserFoodInfo userFoodInfo = _userFoodInfoRepo.GetFirstOrDefault(filter: x => x.Id == id);
            if (userFoodInfo != null)
            {

                return _userFoodInfoRepo.Delete(userFoodInfo);



            }
            return false;
        }

        public ResultService<List<UserFoodInfoCreateVm>> GetAll(string mealName,int id)
        {
            ResultService<List<UserFoodInfoCreateVm>> result = new ResultService<List<UserFoodInfoCreateVm>>();

            var foods = _userFoodInfoRepo.GetFilteredList(select: x => new UserFoodInfoCreateVm
            {
                UserID=(int)x.UserId,
               FoodName=x.FoodName,
               Portion=x.Portion,
               Kcal=x.Kcal,
               Protein=x.Protein,
               Carbonhydrate=x.Carbonhydrate,
               Fat=x.Fat,
               MealName=x.MealName,
               EatDate=x.EatDate,
               TakenCalorie=x.TakenCalorie


            }, where: x => x.Id==id &&
            x.MealName==mealName&&
            x.EatDate.Value.Day==DateTime.Now.Day&&
            x.EatDate.Value.Month == DateTime.Now.Month&&
            x.EatDate.Value.Year == DateTime.Now.Year, inculudes: x => x.Foods);

            if (foods != null)
            {
                result.Data = foods.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;
        }

        public ResultService<List<UserFoodInfoCreateVm>> GetMonthlyTopFood()
        {
            ResultService<List<UserFoodInfoCreateVm>> result = new ResultService<List<UserFoodInfoCreateVm>>();



            DateTime now = DateTime.Now;



            DateTime oneMonthAgo = now.AddDays(-30);



            var foods = _userFoodInfoRepo.GetFilteredList(select: x => new UserFoodInfoCreateVm
            {
                UserID = (int)x.UserId,
                FoodName = x.FoodName,
                Portion = x.Portion,
                Kcal = x.Kcal,
                Protein = x.Protein,
                Carbonhydrate = x.Carbonhydrate,
                Fat = x.Fat,
                MealName = x.MealName,
                EatDate = x.EatDate,
                TakenCalorie = x.TakenCalorie
            },
            where: x => x.State == 0 && x.EatDate >= oneMonthAgo && x.EatDate <= now,
            inculudes: x => x.Foods);



            if (foods != null)
            {
                result.Data = foods.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;
        }

        public ResultService<List<UserFoodInfoCreateVm>> GetWeeklyTopFood()
        {
            ResultService<List<UserFoodInfoCreateVm>> result = new ResultService<List<UserFoodInfoCreateVm>>();



            DateTime now = DateTime.Now;



            DateTime oneWeekAgo = now.AddDays(-7);



            var foods = _userFoodInfoRepo.GetFilteredList(select: x => new UserFoodInfoCreateVm
            {
                UserID = (int)x.UserId,
                FoodName = x.FoodName,
                Portion = x.Portion,
                Kcal = x.Kcal,
                Protein = x.Protein,
                Carbonhydrate = x.Carbonhydrate,
                Fat = x.Fat,
                MealName = x.MealName,
                EatDate = x.EatDate,
                TakenCalorie = x.TakenCalorie
            },
            where: x => x.State == 0 && x.EatDate >= oneWeekAgo && x.EatDate <= now,
            inculudes: x => x.Foods);



            if (foods != null)
            {
                result.Data = foods.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;
        }
    }
}
