using DietProgram.DAL.Concrete.Context.EntityConfiguration;
using DietProgram.DAL.Concrete.EntityConfiguration;
using DietProgram.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.DAL.Concrete.Context
{
    public class DietProgramDbContext : DbContext
    {

        public  DbSet<Admin> Admin { get; set; }
        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Food> Foods { get; set; }
        public  DbSet<User> Users { get; set; }
        public  DbSet<UserFoodInfo> UserFoodInfos { get; set; }
        public  DbSet<UserInfo> UserInfos { get; set; }
        public  DbSet<FoodDetail> Meals { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-BL7JRR4\SQL2022;Database = DietProgramDatabase;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration())
                .ApplyConfiguration(new CategoryConfiguration())
                .ApplyConfiguration(new FoodConfiguration())
                .ApplyConfiguration(new UserConfiguration())
                .ApplyConfiguration(new UserFoodInfoConfiguration())
               .ApplyConfiguration(new UserInfoConfiguration())
               .ApplyConfiguration(new FoodDetailConfiguration());                          
        }
    }
}
