using DietProgram.DAL.Abstract;
using DietProgram.DAL.Concrete.Context;
using DietProgram.DAL.Concrete.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.DAL.Repositories
{
    public static class EFContextDAL
    {
        public static IServiceCollection AddScopedDal(this IServiceCollection services)
        {
            services.AddDbContext<DietProgramDbContext>()
                .AddScoped<IUserRepo, UserRepo>()
                .AddScoped<IAdminRepo, AdminRepo>()
                .AddScoped<ICategoryRepo, CategoryRepo>()
                .AddScoped<IFoodRepo, FoodRepo>()
                .AddScoped<IFoodDetailRepo, FoodDetailRepo>()
                .AddScoped<IUserFoodInfoRepo, UserFoodInfoRepo>()
                .AddScoped<IUserInfoRepo, UserInfoRepo>();
                

            return services;
        }
    }
}
