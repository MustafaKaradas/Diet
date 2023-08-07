using DietProgram.Core.Enums;
using DietProgram.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.DAL.Concrete.EntityConfiguration
{
    public class UserFoodInfoConfiguration : BaseConfiguration<UserFoodInfo>
    {
        public override void Configure(EntityTypeBuilder<UserFoodInfo> builder)
        {
            builder.Property(x => x.FoodName)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnName("Yemek Adı");

            builder.Property(x => x.Portion)
                .IsRequired()
                .HasColumnName("Porsiyon");


            builder.Property(x => x.MealName)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("Öğün Adı");

            builder.Property(x => x.EatDate)
                    .HasColumnName("Yenme Tarihi");

            builder.Property(x => x.TakenCalorie)
                    .IsRequired()
                    .HasColumnName("Alınan Kalori");

            builder.HasMany(x => x.Foods)
                 .WithMany(x => x.UserFoodInfos);

            builder.HasMany(x => x.Users)
                   .WithMany(x => x.UserFoodInfos);

            builder.Property(x => x.Kcal)
                   .IsRequired()
                   .HasColumnName("Kalori");

            builder.Property(x => x.Protein)
                .IsRequired()
                .HasColumnName("Protein");

            builder.Property(x => x.Carbonhydrate)
               .IsRequired()
               .HasColumnName("Karbonhidrat");

            builder.Property(x => x.Fat)
               .IsRequired()
               .HasColumnName("Yağ");

            builder.Property(x => x.UserId)
                .IsRequired();

            builder.HasData(new UserFoodInfo
            {
                Id = 1, UserId = 3, FoodName = "Siyah Zeytin", Kcal = 120, Portion = 2, MealName = "Kahvaltı",
                EatDate = new DateTime(2023, 08, 1, 08, 50, 33), TakenCalorie = 240, Protein = 2, Carbonhydrate = 12, Fat = 22, State = State.Created
            },
            new UserFoodInfo
            {
                Id = 2, UserId = 3, FoodName = "Izgara Tavuk", Kcal = 200, Portion = 1, MealName = "Öğle Yemeği",
                EatDate = new DateTime(2023, 07, 31, 13, 40, 33), TakenCalorie = 200, Protein = 25, Carbonhydrate = 0, Fat = 1, State = State.Created
            },
            new UserFoodInfo
            {
                Id = 3, UserId = 3, FoodName = "Somon balığı", Kcal = 220, Portion = 1, MealName = "Akşam Yemeği",
                EatDate = new DateTime(2023, 07, 1, 20, 32, 33), TakenCalorie = 220, Protein = 25, Carbonhydrate = 0, Fat = 15, State = State.Created
            },
            new UserFoodInfo
            {
                Id = 4, UserId = 3, FoodName = "Etli Çiğ Köfte", Kcal = 200, Portion = 2, MealName = "Ara Öğün",
                EatDate = new DateTime(2023, 07, 2, 17, 14, 33), TakenCalorie = 400, Protein = 15, Carbonhydrate = 20, Fat = 10, State = State.Created
            },
            new UserFoodInfo
            {
                Id = 5, UserId = 3, FoodName = "Beyaz peynir", Kcal = 120, Portion = 1, MealName = "Kahvaltı", EatDate = new DateTime(2023, 07, 22, 10, 50, 38), TakenCalorie = 120, Protein = 17, Carbonhydrate = 1, Fat = 20, State = State.Created

            },
            new UserFoodInfo
            {
                Id = 6,
                UserId = 3,
                FoodName = "Kola",
                Kcal = 42,
                Portion = 1,
                MealName = "Öğle Yemeği",
                EatDate = new DateTime(2023, 07, 22, 14, 45, 12),
                TakenCalorie = 42,
                Protein = 0,
                Carbonhydrate = 10,
                Fat = 0,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 7,
                UserId = 3,
                FoodName = "Kuşbaşılı pide",
                Kcal = 350,
                Portion = 1,
                MealName = "Akşam Yemeği",
                EatDate = new DateTime(2023, 07, 21, 21, 08, 33),
                TakenCalorie = 350,
                Protein = 18,
                Carbonhydrate = 35,
                Fat = 15,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 8,
                UserId = 3,
                FoodName = "Hünkar beğendi",
                Kcal = 250,
                Portion = 2,
                MealName = "Ara Öğün",
                EatDate = new DateTime(2023, 07, 18, 17, 17, 33),
                TakenCalorie = 500,
                Protein = 15,
                Carbonhydrate = 20,
                Fat = 12,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 9,
                UserId = 1,
                FoodName = "Siyah Zeytin",
                Kcal = 120,
                Portion = 2,
                MealName = "Kahvaltı",
                EatDate = new DateTime(2023, 08, 1, 08, 50, 33),
                TakenCalorie = 240,
                Protein = 2,
                Carbonhydrate = 12,
                Fat = 22,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 10,
                UserId = 1,
                FoodName = "Izgara Tavuk",
                Kcal = 200,
                Portion = 1,
                MealName = "Öğle Yemeği",
                EatDate = new DateTime(2023, 07, 31, 13, 40, 33),
                TakenCalorie = 200,
                Protein = 25,
                Carbonhydrate = 0,
                Fat = 1,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 11,
                UserId = 1,
                FoodName = "Somon balığı",
                Kcal = 220,
                Portion = 1,
                MealName = "Akşam Yemeği",
                EatDate = new DateTime(2023, 07, 1, 20, 32, 33),
                TakenCalorie = 220,
                Protein = 25,
                Carbonhydrate = 0,
                Fat = 15,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 12,
                UserId = 1,
                FoodName = "Etli Çiğ Köfte",
                Kcal = 200,
                Portion = 2,
                MealName = "Ara Öğün",
                EatDate = new DateTime(2023, 07, 2, 17, 14, 33),
                TakenCalorie = 400,
                Protein = 15,
                Carbonhydrate = 20,
                Fat = 10,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 13,
                UserId = 1,
                FoodName = "Beyaz peynir",
                Kcal = 120,
                Portion = 1,
                MealName = "Kahvaltı",
                EatDate = new DateTime(2023, 07, 22, 10, 50, 38),
                TakenCalorie = 120,
                Protein = 17,
                Carbonhydrate = 1,
                Fat = 20,
                State = State.Created

            },
            new UserFoodInfo
            {
                Id = 14,
                UserId = 1,
                FoodName = "Kola",
                Kcal = 42,
                Portion = 1,
                MealName = "Öğle Yemeği",
                EatDate = new DateTime(2023, 07, 22, 14, 45, 12),
                TakenCalorie = 42,
                Protein = 0,
                Carbonhydrate = 10,
                Fat = 0,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 15,
                UserId = 1,
                FoodName = "Kuşbaşılı pide",
                Kcal = 350,
                Portion = 1,
                MealName = "Akşam Yemeği",
                EatDate = new DateTime(2023, 07, 21, 21, 08, 33),
                TakenCalorie = 350,
                Protein = 18,
                Carbonhydrate = 35,
                Fat = 15,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 16,
                UserId = 1,
                FoodName = "Hünkar beğendi",
                Kcal = 250,
                Portion = 2,
                MealName = "Ara Öğün",
                EatDate = new DateTime(2023, 07, 18, 17, 17, 33),
                TakenCalorie = 500,
                Protein = 15,
                Carbonhydrate = 20,
                Fat = 12,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 17,
                UserId = 2,
                FoodName = "Siyah Zeytin",
                Kcal = 120,
                Portion = 2,
                MealName = "Kahvaltı",
                EatDate = new DateTime(2023, 08, 1, 08, 50, 33),
                TakenCalorie = 240,
                Protein = 2,
                Carbonhydrate = 12,
                Fat = 22,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 18,
                UserId = 2,
                FoodName = "Izgara Tavuk",
                Kcal = 200,
                Portion = 1,
                MealName = "Öğle Yemeği",
                EatDate = new DateTime(2023, 07, 31, 13, 40, 33),
                TakenCalorie = 200,
                Protein = 25,
                Carbonhydrate = 0,
                Fat = 1,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 19,
                UserId = 2,
                FoodName = "Somon balığı",
                Kcal = 220,
                Portion = 1,
                MealName = "Akşam Yemeği",
                EatDate = new DateTime(2023, 07, 1, 20, 32, 33),
                TakenCalorie = 220,
                Protein = 25,
                Carbonhydrate = 0,
                Fat = 15,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 20,
                UserId = 2,
                FoodName = "Etli Çiğ Köfte",
                Kcal = 200,
                Portion = 2,
                MealName = "Ara Öğün",
                EatDate = new DateTime(2023, 07, 2, 17, 14, 33),
                TakenCalorie = 400,
                Protein = 15,
                Carbonhydrate = 20,
                Fat = 10,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 21,
                UserId = 2,
                FoodName = "Beyaz peynir",
                Kcal = 120,
                Portion = 1,
                MealName = "Kahvaltı",
                EatDate = new DateTime(2023, 07, 22, 10, 50, 38),
                TakenCalorie = 120,
                Protein = 17,
                Carbonhydrate = 1,
                Fat = 20,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 22,
                UserId = 2,
                FoodName = "Kola",
                Kcal = 42,
                Portion = 1,
                MealName = "Öğle Yemeği",
                EatDate = new DateTime(2023, 07, 22, 14, 45, 12),
                TakenCalorie = 42,
                Protein = 0,
                Carbonhydrate = 10,
                Fat = 0,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 23,
                UserId = 2,
                FoodName = "Kuşbaşılı pide",
                Kcal = 350,
                Portion = 1,
                MealName = "Akşam Yemeği",
                EatDate = new DateTime(2023, 07, 21, 21, 08, 33),
                TakenCalorie = 350,
                Protein = 18,
                Carbonhydrate = 35,
                Fat = 15,
                State = State.Created
            },
            new UserFoodInfo
            {
                Id = 24, UserId = 2, FoodName = "Hünkar beğendi", Kcal = 250, Portion = 2, MealName = "Ara Öğün",
                EatDate = new DateTime(2023, 07, 18, 17, 17, 33), TakenCalorie = 500, Protein = 15, Carbonhydrate = 20, Fat = 12, State = State.Created
            }
            );

             
            
            


        }

    }
}
