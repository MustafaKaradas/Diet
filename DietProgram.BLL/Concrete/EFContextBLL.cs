using AutoMapper;
using DietProgram.BLL.Abstract.IServices;
using DietProgram.BLL.Concrete.Mapper;
using DietProgram.BLL.Concrete.Services;
using DietProgram.DAL.Abstract;
using DietProgram.DAL.Concrete.Context;
using DietProgram.DAL.Concrete.Repositories;
using DietProgram.DAL.Repositories;
using DietProgram.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.BLL.Concrete
{
    public static class EFContextBLL
    {
        public static IServiceCollection AddScopedBll(this IServiceCollection services)
        {
            services.AddScopedDal()
               .AddScoped<IUserService, UserService>()
               .AddScoped<IAdminService, AdminService>()
               .AddScoped<ICategoryService, CategoryService>()
               .AddScoped<IFoodService, FoodService>()
               .AddScoped<IUserFoodInfoService, UserFoodInfoService>()
               .AddScoped<IUserInfoService, UserInfoService>()
               .AddScoped<IUserFoodInfoService, UserFoodInfoService>();
               

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Mapping());
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
