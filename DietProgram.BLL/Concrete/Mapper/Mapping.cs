using AutoMapper;
using DietProgram.Entities;
using DietProgram.Models;
using DietProgram.Models.DTOs.FoodDTO;
using DietProgram.Models.DTOs.UserDTO;
using DietProgram.Models.DTOs.UserFoodInfoDTO;
using DietProgram.Models.DTOs.UserInfoDTO;
using DietProgram.Models.VMs.CategoryVM;
using DietProgram.Models.VMs.FoodVM;
using DietProgram.Models.VMs.UserFoodInfoVM;
using DietProgram.Models.VMs.UserInfoVm;
using DietProgram.Models.VMs.UserVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Concrete.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Admin, AdminLoginVM>().ReverseMap();

            CreateMap<Category, CategoryDetailVM>().ReverseMap();

            CreateMap<Food, FoodCreateDTO>().ReverseMap();
            CreateMap<Food, FoodDeleteDTO>().ReverseMap();
            CreateMap<Food, FoodUpdateDTO>().ReverseMap();
            CreateMap<Food, FoodDetailDTO>().ReverseMap();
            CreateMap<FoodCreateDTO, FoodCreateVM>().ReverseMap();
            CreateMap<FoodDeleteDTO, FoodDeleteVM>().ReverseMap();
            CreateMap<FoodUpdateDTO, FoodUpdateVM>().ReverseMap();
            CreateMap<FoodDetailDTO, FoodDetailVM>().ReverseMap();


            CreateMap<User, UserCreateDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();
            CreateMap<User,UserLoginVM>().ReverseMap();
            CreateMap<UserCreateDTO, UserCreateVM>().ReverseMap();
            CreateMap<UserUpdateDTO, UserUpdateVM>().ReverseMap();

            CreateMap<UserFoodInfo, UserFoodInfoCreateVm>().ReverseMap();
            CreateMap<UserFoodInfo, UserFoodInfoBaseVM>().ReverseMap();
            CreateMap<UserFoodInfo, UserFoodInfoCreateDto>().ReverseMap();
            

            CreateMap<UserFoodInfoCreateDto,UserFoodInfoCreateVm>().ReverseMap();

            CreateMap<UserInfo, UserInfoCreateDTO>().ReverseMap();
            CreateMap<UserInfo, UserInfoUpdateVm>().ReverseMap();
            CreateMap<UserInfo, UserInfoUpdateDTO>().ReverseMap();
            CreateMap<UserInfoCreateDTO, UserInfoCreateVm>().ReverseMap();
            CreateMap<UserInfoUpdateDTO, UserInfoUpdateVm>().ReverseMap();






        }

    }
}
