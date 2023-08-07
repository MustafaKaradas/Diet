using AutoMapper;
using DietProgram.BLL.Abstract.IServices;
using DietProgram.Core.Enums;
using DietProgram.DAL.Abstract;
using DietProgram.DAL.Concrete.Context;
using DietProgram.DAL.Concrete.Repositories;
using DietProgram.Entities;
using DietProgram.Models.DTOs.FoodDTO;
using DietProgram.Models.DTOs.UserInfoDTO;
using DietProgram.Models.VMs.CategoryVM;
using DietProgram.Models.VMs.UserInfoVm;
using DietProgram.Models.VMs.UserVM;
using DietProgram.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DietProgram.BLL.Concrete.Services
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoRepo _userInfoRepo;
        
        private readonly IMapper _mapper;
        DietProgramDbContext _db;
        public UserInfoService(IUserInfoRepo userInfoRepo, IMapper mapper)
        {
            _db = new DietProgramDbContext();
            _userInfoRepo = userInfoRepo;
            _mapper = mapper;
        }


        public ResultService<List<UserInfoCreateVm>> GetAll()
        {
            ResultService<List<UserInfoCreateVm>> result = new ResultService<List<UserInfoCreateVm>>();

            var userInfos = _userInfoRepo.GetFilteredList(
                select: x => new UserInfoCreateVm
                {
                    UserInfoId= x.Id,
                    UserId = x.UserId,
                    Gender = x.Gender,
                    Name = x.Name,
                    Age=x.Age,
                    Height=x.Height,
                    Weight=x.Weight,
                    WCircum=x.WCircum,
                    NCircum=x.NCircum,
                    HCircum=x.HCircum,
                    Activite=x.Activite

                },
                where: x => x.State != State.Deleted,
                inculudes: x => x.User);

            if (userInfos != null)
            {
                result.Data = userInfos.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı.");
            }
            return result;
        }


        public ResultService<UserInfoCreateDTO> Create(UserInfoCreateVm createVM)
        {
            ResultService<UserInfoCreateDTO> result = new ResultService<UserInfoCreateDTO>();

            UserInfoCreateDTO createDto = _mapper.Map<UserInfoCreateDTO>(createVM);
            UserInfo newUserInfo = _mapper.Map<UserInfo>(createDto);
            var addedUserInfo = _userInfoRepo.Create(newUserInfo);

            if (addedUserInfo != null)
            {
                result.Data = createDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
        }

        public double DailyTotalCalories(int age, int height, int weight, string gender, string activity)
        {
            UserInfo userInfo = new UserInfo();

            age= userInfo.Age;
            height= userInfo.Height;
            weight= userInfo.Weight;
            gender= userInfo.Gender;
 
            double manTotalCalories = 66.5 + (13.75 * weight) + (5 * height) - (6.7 * age);
            double womanTotalCalories = 655.1 + (9.56 * weight) + (1.85 * height) - (4.68 * age);

          
            double totalCalories = 0;

            if(gender == "Erkek")
            {
                totalCalories = manTotalCalories;
                if(userInfo.Activite =="Az")
                {
                    totalCalories = totalCalories * 1.2;                 
                }
                else if(userInfo.Activite=="Orta")
                {
                    totalCalories = totalCalories * 1.4;
                    
                }
                else if(userInfo.Activite =="Fazla")
                {
                    totalCalories = totalCalories * 1.5;
                    
                }
            }
            else
            {
                totalCalories = womanTotalCalories;
                if (userInfo.Activite == "Az")
                {
                    totalCalories = totalCalories * 1.2;
                   
                }
                else if (userInfo.Activite == "Orta")
                {
                    totalCalories = totalCalories * 1.4;
                    
                }
                else if (userInfo.Activite == "Fazla")
                {
                    totalCalories = totalCalories * 1.5;                   
                }
            }
            return totalCalories;
        }

        public double TakenMealCalories(Food food)
        {
            
            string nameFOod = food.FoodName;
            double quantityValue = food.Kcal;
            double total = 0;



            if (nameFOod != null && quantityValue != 0)
            {
                int newText = Int32.Parse(nameFOod);
                total = newText * quantityValue;
            }
            else
            {
                throw new Exception("Lütfen tüketilecek bir besin seçiniz.");
            }
            return total;



        }

        public double TakenTotalCalories(int calories)
        {
            string nameFOod = "Yemek adı";
            double quantityValue = 1;
            double total = 0;



            if (nameFOod != null && quantityValue != 0)
            {
                int newText = Int32.Parse(nameFOod);
                total = newText * quantityValue;
            }
            else
            {
                throw new Exception("Lütfen tüketilecek bir besin seçiniz.");
            }
            return total;
        }

        public ResultService<UserInfoUpdateVm> Update(UserInfoUpdateVm updateVM)
        {
            ResultService<UserInfoUpdateVm> result = new ResultService<UserInfoUpdateVm>();

            var updateDto = _mapper.Map<UserInfoUpdateVm>(updateVM);
            var data = _mapper.Map<UserInfo>(updateDto);

            var updateData = _userInfoRepo.Update(data);

            if (updateData != null)
            {
                result.Data = updateDto;
            }
            else
            {
                result.AddError(ErrorType.ServerError, "Güncelleme işlemi başarısız");
            }
            return result;
        }

        public bool Delete(int id)
        {
            UserInfo userInfo = _userInfoRepo.GetFirstOrDefault(filter: x => x.Id == id);

            if (userInfo != null)
            {

                return _userInfoRepo.Delete(userInfo);



            }
            return false;
        }
    }
}
