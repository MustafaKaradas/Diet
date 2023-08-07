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
    public class FoodConfiguration : BaseConfiguration<Food>
    {
        public override void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(x => x.FoodName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Yemek İsmi");

            builder.HasIndex(x => x.FoodName)
                .IsUnique();

            builder.Property(x => x.Kcal)
                .IsRequired()
                .HasColumnName("Kalori");

            builder.Property(x => x.Protein)
                .IsRequired();

            builder.Property(x => x.Carbonhydrate)
                .IsRequired()
                .HasColumnName("Karbonhidrat");

            builder.Property(x => x.Fat)
                .IsRequired()
                .HasColumnName("Yağ");

            builder.Property(x => x.Picture)
                .HasColumnName("Resim");


            builder.HasOne(x => x.Category)
                .WithMany(x => x.Foods)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.FoodDetails)
                    .WithMany(x => x.Foodss)
                    .HasForeignKey(x => x.FoodDetailID)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Food
            { Id = 1, CategoryId = 2, FoodName = "Cips", Kcal = 540, Protein = 7, Carbonhydrate = 55, Fat = 34, State = State.Created },
            new Food { Id = 2, CategoryId = 2, FoodName = "Kurabiye", Kcal = 400, Protein = 8, Carbonhydrate = 50, Fat = 20, State = State.Created },
            new Food { Id = 3, CategoryId = 2, FoodName = "Çikolata", Kcal = 550, Protein = 5, Carbonhydrate = 55, Fat = 35, State = State.Created },
            new Food { Id = 4, CategoryId = 2, FoodName = "Fındık", Kcal = 650, Protein = 15, Carbonhydrate = 15, Fat = 61, State = State.Created },
            new Food { Id = 5, CategoryId = 2, FoodName = "Ceviz", Kcal = 650, Protein = 15, Carbonhydrate = 14, Fat = 65, State = State.Created },
            new Food { Id = 6, CategoryId = 2, FoodName = "Badem", Kcal = 400, Protein = 8, Carbonhydrate = 50, Fat = 20, State = State.Created },
            new Food { Id = 7, CategoryId = 2, FoodName = "Kaju", Kcal = 570, Protein = 18, Carbonhydrate = 32, Fat = 46, State = State.Created },
            new Food { Id = 8, CategoryId = 2, FoodName = "Leblebi", Kcal = 350, Protein = 19, Carbonhydrate = 38, Fat = 15, State = State.Created },
            new Food { Id = 9, CategoryId = 2, FoodName = "Patlamış mısır", Kcal = 370, Protein = 8, Carbonhydrate = 75, Fat = 5, State = State.Created },
            new Food { Id = 10, CategoryId = 2, FoodName = "Kraker", Kcal = 430, Protein = 8, Carbonhydrate = 62, Fat = 16, State = State.Created },
            new Food { Id = 11, CategoryId = 2, FoodName = "Bisküvi", Kcal = 480, Protein = 6, Carbonhydrate = 62, Fat = 22, State = State.Created },
            new Food { Id = 12, CategoryId = 2, FoodName = "Makarna salatası", Kcal = 200, Protein = 3, Carbonhydrate = 22, Fat = 13, State = State.Created },
            new Food { Id = 13, CategoryId = 2, FoodName = "Biber kızartması", Kcal = 220, Protein = 4, Carbonhydrate = 25, Fat = 15, State = State.Created },
            new Food { Id = 14, CategoryId = 2, FoodName = "Pizza dilimleri", Kcal = 230, Protein = 5, Carbonhydrate = 28, Fat = 14, State = State.Created },
            new Food { Id = 15, CategoryId = 2, FoodName = "Mısır cipsi", Kcal = 190, Protein = 6, Carbonhydrate = 30, Fat = 12, State = State.Created },
            new Food { Id = 16, CategoryId = 2, FoodName = "Tost", Kcal = 180, Protein = 2, Carbonhydrate = 28, Fat = 13, State = State.Created },
            new Food { Id = 17, CategoryId = 2, FoodName = "Muffin", Kcal = 210, Protein = 3, Carbonhydrate = 25, Fat = 12, State = State.Created },
            new Food { Id = 18, CategoryId = 2, FoodName = "browni", Kcal = 240, Protein = 4, Carbonhydrate = 20, Fat = 15, State = State.Created },
            new Food { Id = 19, CategoryId = 3, FoodName = "Haslanmis yumurta", Kcal = 80, Protein = 6, Carbonhydrate = 1, Fat = 5, State = State.Created },
            new Food { Id = 20, CategoryId = 3, FoodName = "Yulaf ezmesi", Kcal = 380, Protein = 13, Carbonhydrate = 60, Fat = 7, State = State.Created },
            new Food { Id = 21, CategoryId = 3, FoodName = "Peynirli omlet", Kcal = 220, Protein = 15, Carbonhydrate = 4, Fat = 17, State = State.Created },
            new Food { Id = 22, CategoryId = 3, FoodName = "Domatesli omlet", Kcal = 130, Protein = 8, Carbonhydrate = 5, Fat = 9, State = State.Created },
            new Food { Id = 23, CategoryId = 3, FoodName = "Sucuklu yumurta", Kcal = 280, Protein = 14, Carbonhydrate = 1, Fat = 24, State = State.Created },
            new Food { Id = 24, CategoryId = 3, FoodName = "Menemen", Kcal = 170, Protein = 7, Carbonhydrate = 6, Fat = 14, State = State.Created },
            new Food { Id = 25, CategoryId = 3, FoodName = "Mısır gevreği", Kcal = 360, Protein = 9, Carbonhydrate = 85, Fat = 2, State = State.Created },
            new Food { Id = 26, CategoryId = 3, FoodName = "Poğaça", Kcal = 340, Protein = 8, Carbonhydrate = 33, Fat = 20, State = State.Created },
            new Food { Id = 27, CategoryId = 3, FoodName = "Üçgen peynirli simit", Kcal = 330, Protein = 10, Carbonhydrate = 65, Fat = 2, State = State.Created },
            new Food { Id = 28, CategoryId = 3, FoodName = "Börek", Kcal = 320, Protein = 12, Carbonhydrate = 25, Fat = 20, State = State.Created },
            new Food { Id = 29, CategoryId = 3, FoodName = "Ekmek", Kcal = 250, Protein = 10, Carbonhydrate = 50, Fat = 2, State = State.Created },
            new Food { Id = 30, CategoryId = 3, FoodName = "Reçel", Kcal = 260, Protein = 0, Carbonhydrate = 65, Fat = 0, State = State.Created },
            new Food { Id = 31, CategoryId = 3, FoodName = "Üzüm reçeli", Kcal = 300, Protein = 1, Carbonhydrate = 76, Fat = 0, State = State.Created },
            new Food { Id = 32, CategoryId = 3, FoodName = "Kayısı reçeli", Kcal = 270, Protein = 1, Carbonhydrate = 67, Fat = 0, State = State.Created },
            new Food { Id = 33, CategoryId = 3, FoodName = "Çilek reçeli", Kcal = 260, Protein = 1, Carbonhydrate = 63, Fat = 0, State = State.Created },
            new Food { Id = 34, CategoryId = 3, FoodName = "Portakal reçeli", Kcal = 280, Protein = 1, Carbonhydrate = 70, Fat = 0, State = State.Created },
            new Food { Id = 35, CategoryId = 3, FoodName = "Vişne reçeli", Kcal = 270, Protein = 1, Carbonhydrate = 66, Fat = 0, State = State.Created },
            new Food { Id = 36, CategoryId = 3, FoodName = "Erik reçeli", Kcal = 260, Protein = 1, Carbonhydrate = 64, Fat = 0, State = State.Created },
            new Food { Id = 37, CategoryId = 3, FoodName = "Bal", Kcal = 330, Protein = 0, Carbonhydrate = 82, Fat = 0, State = State.Created },
            new Food { Id = 38, CategoryId = 3, FoodName = "Tahin", Kcal = 595, Protein = 20, Carbonhydrate = 20, Fat = 53, State = State.Created },
            new Food { Id = 39, CategoryId = 3, FoodName = "Pekmez", Kcal = 290, Protein = 1, Carbonhydrate = 70, Fat = 1, State = State.Created },
            new Food { Id = 40, CategoryId = 3, FoodName = "Sigara böreği", Kcal = 400, Protein = 10, Carbonhydrate = 30, Fat = 25, State = State.Created },
            new Food { Id = 41, CategoryId = 3, FoodName = "Kaşar peyniri", Kcal = 350, Protein = 22, Carbonhydrate = 1, Fat = 30, State = State.Created },
            new Food { Id = 42, CategoryId = 3, FoodName = "Patates kızartması", Kcal = 220, Protein = 3, Carbonhydrate = 28, Fat = 11, State = State.Created },
            new Food { Id = 43, CategoryId = 3, FoodName = "Kavurma", Kcal = 360, Protein = 20, Carbonhydrate = 0, Fat = 32, State = State.Created },
            new Food { Id = 44, CategoryId = 3, FoodName = "Kaymak", Kcal = 460, Protein = 4, Carbonhydrate = 3, Fat = 48, State = State.Created },
            new Food { Id = 45, CategoryId = 3, FoodName = "yeşil soğan", Kcal = 400, Protein = 20, Carbonhydrate = 1, Fat = 4, State = State.Created },
            new Food { Id = 46, CategoryId = 3, FoodName = "hıyar", Kcal = 15, Protein = 0, Carbonhydrate = 3, Fat = 0, State = State.Created },
            new Food { Id = 47, CategoryId = 3, FoodName = "Biber", Kcal = 15, Protein = 0, Carbonhydrate = 2, Fat = 21, State = State.Created },
            new Food { Id = 48, CategoryId = 3, FoodName = "Beyaz peynir", Kcal = 260, Protein = 17, Carbonhydrate = 1, Fat = 20, State = State.Created },
            new Food { Id = 49, CategoryId = 3, FoodName = "Tulum peyniri", Kcal = 280, Protein = 19, Carbonhydrate = 1, Fat = 21, State = State.Created },
            new Food { Id = 50, CategoryId = 3, FoodName = "Dil peyniri", Kcal = 350, Protein = 23, Carbonhydrate = 1, Fat = 27, State = State.Created },
            new Food { Id = 51, CategoryId = 3, FoodName = "Örgü peyniri", Kcal = 330, Protein = 22, Carbonhydrate = 2, Fat = 26, State = State.Created },
                 new Food { Id = 52, CategoryId = 3, FoodName = "Eski kaşar", Kcal = 380, Protein = 26, Carbonhydrate = 3, Fat = 29, State = State.Created },
                 new Food { Id = 53, CategoryId = 3, FoodName = "Ezine peyniri", Kcal = 310, Protein = 21, Carbonhydrate = 4, Fat = 24, State = State.Created },
                new Food { Id = 54, CategoryId = 3, FoodName = "Zeytin ezmesi", Kcal = 204, Protein = 1, Carbonhydrate = 5, Fat = 20, State = State.Created },
                new Food { Id = 55, CategoryId = 3, FoodName = "Yeşil zeytin", Kcal = 135, Protein = 1, Carbonhydrate = 5, Fat = 20, State = State.Created },
                new Food { Id = 56, CategoryId = 3, FoodName = "Siyah zeytin", Kcal = 120, Protein = 1, Carbonhydrate = 6, Fat = 11, State = State.Created },
                new Food { Id = 57, CategoryId = 4, FoodName = "Izgara tavuk", Kcal = 200, Protein = 25, Carbonhydrate = 0, Fat = 11, State = State.Created },
                new Food { Id = 58, CategoryId = 4, FoodName = "Tavuk şinitzel", Kcal = 220, Protein = 26, Carbonhydrate = 4, Fat = 10, State = State.Created },
                new Food { Id = 59, CategoryId = 4, FoodName = "Izgara dana eti", Kcal = 250, Protein = 30, Carbonhydrate = 0, Fat = 15, State = State.Created },
                new Food { Id = 60, CategoryId = 4, FoodName = "Et köfte", Kcal = 280, Protein = 22, Carbonhydrate = 1, Fat = 17, State = State.Created },
                new Food { Id = 61, CategoryId = 4, FoodName = "Etli sulu yemek", Kcal = 250, Protein = 30, Carbonhydrate = 0, Fat = 15, State = State.Created },
                new Food { Id = 62, CategoryId = 4, FoodName = "Et döner", Kcal = 239, Protein = 12, Carbonhydrate = 22, Fat = 11, State = State.Created },
                new Food { Id = 63, CategoryId = 4, FoodName = "Tavuk döner", Kcal = 300, Protein = 25, Carbonhydrate = 3, Fat = 20, State = State.Created },
                new Food { Id = 64, CategoryId = 4, FoodName = "Somon balığı", Kcal = 220, Protein = 25, Carbonhydrate = 0, Fat = 15, State = State.Created },
                new Food { Id = 65, CategoryId = 4, FoodName = "Ton balığı", Kcal = 150, Protein = 30, Carbonhydrate = 0, Fat = 3, State = State.Created },
                new Food { Id = 66, CategoryId = 4, FoodName = "Çipura balığı", Kcal = 170, Protein = 20, Carbonhydrate = 0, Fat = 10, State = State.Created },
                new Food { Id = 67, CategoryId = 4, FoodName = "Hamsi", Kcal = 160, Protein = 20, Carbonhydrate = 0, Fat = 8, State = State.Created },
                new Food { Id = 68, CategoryId = 4, FoodName = "Hindi şinitzel", Kcal = 240, Protein = 23, Carbonhydrate = 5, Fat = 14, State = State.Created },
                new Food { Id = 69, CategoryId = 4, FoodName = "Biftek", Kcal = 280, Protein = 35, Carbonhydrate = 0, Fat = 15, State = State.Created },
               new Food { Id = 70, CategoryId = 4, FoodName = "Dana kıyma", Kcal = 250, Protein = 25, Carbonhydrate = 1, Fat = 17, State = State.Created },
               new Food { Id = 71, CategoryId = 4, FoodName = "Etli Çiğ Köfte", Kcal = 200, Protein = 15, Carbonhydrate = 20, Fat = 10, State = State.Created },
                new Food { Id = 72, CategoryId = 4, FoodName = "Alabalık", Kcal = 120, Protein = 20, Carbonhydrate = 0, Fat = 5, State = State.Created },
                new Food { Id = 73, CategoryId = 4, FoodName = "Sardalya", Kcal = 160, Protein = 25, Carbonhydrate = 0, Fat = 7, State = State.Created },
                new Food { Id = 74, CategoryId = 4, FoodName = "Levrek", Kcal = 180, Protein = 23, Carbonhydrate = 0, Fat = 9, State = State.Created },
                new Food { Id = 75, CategoryId = 4, FoodName = "Palamut", Kcal = 140, Protein = 18, Carbonhydrate = 0, Fat = 6, State = State.Created },
                new Food { Id = 76, CategoryId = 4, FoodName = "Kılıç Balığı", Kcal = 200, Protein = 28, Carbonhydrate = 0, Fat = 10, State = State.Created },
                new Food { Id = 77, CategoryId = 4, FoodName = "Mezgit", Kcal = 170, Protein = 24, Carbonhydrate = 0, Fat = 8, State = State.Created },
                new Food { Id = 78, CategoryId = 4, FoodName = "Uskumru", Kcal = 160, Protein = 22, Carbonhydrate = 0, Fat = 7, State = State.Created },
                new Food { Id = 79, CategoryId = 4, FoodName = "Kalkan", Kcal = 190, Protein = 25, Carbonhydrate = 0, Fat = 9, State = State.Created },
                new Food { Id = 80, CategoryId = 4, FoodName = "Havyar", Kcal = 250, Protein = 30, Carbonhydrate = 0, Fat = 15, State = State.Created },
                new Food { Id = 81, CategoryId = 4, FoodName = "Kalamar", Kcal = 200, Protein = 15, Carbonhydrate = 10, Fat = 12, State = State.Created },
                new Food { Id = 82, CategoryId = 4, FoodName = "Karides", Kcal = 90, Protein = 20, Carbonhydrate = 0, Fat = 1, State = State.Created },
                new Food { Id = 83, CategoryId = 4, FoodName = "Yengeç", Kcal = 100, Protein = 15, Carbonhydrate = 0, Fat = 5, State = State.Created },
                new Food { Id = 84, CategoryId = 4, FoodName = "Ahtapot", Kcal = 120, Protein = 20, Carbonhydrate = 5, Fat = 8, State = State.Created },
                new Food { Id = 85, CategoryId = 4, FoodName = "Kefal", Kcal = 110, Protein = 15, Carbonhydrate = 0, Fat = 5, State = State.Created },
                new Food { Id = 86, CategoryId = 4, FoodName = "Tavuk Göğsü", Kcal = 150, Protein = 30, Carbonhydrate = 0, Fat = 3, State = State.Created },
                new Food { Id = 87, CategoryId = 4, FoodName = "Kuzu Et", Kcal = 280, Protein = 22, Carbonhydrate = 0, Fat = 20, State = State.Created },
                new Food { Id = 88, CategoryId = 4, FoodName = "Hindi Et", Kcal = 180, Protein = 25, Carbonhydrate = 0, Fat = 8, State = State.Created },
                new Food { Id = 89, CategoryId = 4, FoodName = "Tavuk But", Kcal = 180, Protein = 20, Carbonhydrate = 0, Fat = 11, State = State.Created },
                new Food { Id = 90, CategoryId = 4, FoodName = "Kuzu Kıyma", Kcal = 280, Protein = 25, Carbonhydrate = 0, Fat = 20, State = State.Created },
                new Food { Id = 91, CategoryId = 4, FoodName = "Tavuk Kanat", Kcal = 200, Protein = 25, Carbonhydrate = 0, Fat = 12, State = State.Created },
                new Food { Id = 92, CategoryId = 4, FoodName = "Sığır Antrikot", Kcal = 290, Protein = 30, Carbonhydrate = 0, Fat = 18, State = State.Created },
                new Food { Id = 93, CategoryId = 4, FoodName = "Tavuk Ciğer", Kcal = 150, Protein = 20, Carbonhydrate = 0, Fat = 7, State = State.Created },
                new Food { Id = 94, CategoryId = 4, FoodName = "Tavuk Pirzola", Kcal = 230, Protein = 22, Carbonhydrate = 0, Fat = 15, State = State.Created },
                new Food { Id = 95, CategoryId = 4, FoodName = "Tavuk Köfte", Kcal = 250, Protein = 22, Carbonhydrate = 0, Fat = 18, State = State.Created },
                new Food { Id = 96, CategoryId = 4, FoodName = "Kuzu Biftek", Kcal = 220, Protein = 25, Carbonhydrate = 0, Fat = 15, State = State.Created },
                new Food { Id = 97, CategoryId = 4, FoodName = "Kuzu Pirzola", Kcal = 280, Protein = 20, Carbonhydrate = 0, Fat = 25, State = State.Created },
                new Food { Id = 98, CategoryId = 4, FoodName = "Dana Antrikot", Kcal = 260, Protein = 28, Carbonhydrate = 0, Fat = 18, State = State.Created },
                new Food { Id = 99, CategoryId = 5, FoodName = "Elma", Kcal = 52, Protein = 3, Carbonhydrate = 14, Fat = 2, State = State.Created },
                new Food { Id = 100, CategoryId = 5, FoodName = "Portakal", Kcal = 43, Protein = 0, Carbonhydrate = 8, Fat = 2, State = State.Created },
                new Food { Id = 101, CategoryId = 5, FoodName = "Salatalık", Kcal = 15, Protein = 6, Carbonhydrate = 3, Fat = 1, State = State.Created },
                new Food { Id = 102, CategoryId = 5, FoodName = "Domates", Kcal = 18, Protein = 9, Carbonhydrate = 3, Fat = 2, State = State.Created },
                new Food { Id = 103, CategoryId = 5, FoodName = "Havuç", Kcal = 41, Protein = 9, Carbonhydrate = 10, Fat = 2, State = State.Created },
                new Food { Id = 104, CategoryId = 5, FoodName = "Patates", Kcal = 77, Protein = 2, Carbonhydrate = 17, Fat = 1, State = State.Created },
                new Food { Id = 105, CategoryId = 5, FoodName = "Çilek", Kcal = 32, Protein = 0, Carbonhydrate = 7, Fat = 3, State = State.Created },
                new Food { Id = 106, CategoryId = 5, FoodName = "Kiraz", Kcal = 50, Protein = 1, Carbonhydrate = 12, Fat = 3, State = State.Created },
                new Food { Id = 107, CategoryId = 5, FoodName = "Karpuz", Kcal = 30, Protein = 6, Carbonhydrate = 7, Fat = 2, State = State.Created },
                new Food { Id = 108, CategoryId = 5, FoodName = "Marul", Kcal = 15, Protein = 1, Carbonhydrate = 2, Fat = 2, State = State.Created },
                new Food { Id = 109, CategoryId = 5, FoodName = "Kavun", Kcal = 29, Protein = 8, Carbonhydrate = 6, Fat = 1, State = State.Created },
                new Food { Id = 110, CategoryId = 5, FoodName = "Enginar", Kcal = 47, Protein = 3, Carbonhydrate = 8, Fat = 2, State = State.Created },
                new Food { Id = 111, CategoryId = 5, FoodName = "Ispanak", Kcal = 23, Protein = 2, Carbonhydrate = 3, Fat = 4, State = State.Created },
                new Food { Id = 112, CategoryId = 5, FoodName = "Bamya", Kcal = 31, Protein = 2, Carbonhydrate = 7, Fat = 1, State = State.Created },
                new Food { Id = 113, CategoryId = 5, FoodName = "Kereviz", Kcal = 42, Protein = 1, Carbonhydrate = 9, Fat = 3, State = State.Created },
                new Food { Id = 114, CategoryId = 5, FoodName = "Dolmalık Biber", Kcal = 20, Protein = 1, Carbonhydrate = 4, Fat = 2, State = State.Created },
                new Food { Id = 115, CategoryId = 5, FoodName = "Şeftali", Kcal = 39, Protein = 1, Carbonhydrate = 9, Fat = 1, State = State.Created },
                new Food { Id = 116, CategoryId = 5, FoodName = "Erik", Kcal = 39, Protein = 1, Carbonhydrate = 9, Fat = 1, State = State.Created },
                new Food { Id = 117, CategoryId = 5, FoodName = "Yeşil Elma", Kcal = 52, Protein = 1, Carbonhydrate = 13, Fat = 4, State = State.Created },
                new Food { Id = 118, CategoryId = 5, FoodName = "Ananas", Kcal = 50, Protein = 1, Carbonhydrate = 13, Fat = 1, State = State.Created },
                new Food { Id = 119, CategoryId = 5, FoodName = "Armut", Kcal = 57, Protein = 1, Carbonhydrate = 15, Fat = 3, State = State.Created },
                new Food { Id = 120, CategoryId = 5, FoodName = "Mandalina", Kcal = 53, Protein = 0, Carbonhydrate = 13, Fat = 3, State = State.Created },
                new Food { Id = 121, CategoryId = 5, FoodName = "Hurma Meyvesi", Kcal = 277, Protein = 1, Carbonhydrate = 68, Fat = 5, State = State.Created },
                new Food { Id = 122, CategoryId = 5, FoodName = "Nar", Kcal = 83, Protein = 1, Carbonhydrate = 18, Fat = 1, State = State.Created },
                new Food { Id = 123, CategoryId = 5, FoodName = "Siyah Üzüm", Kcal = 69, Protein = 0, Carbonhydrate = 17, Fat = 2, State = State.Created },
                new Food { Id = 124, CategoryId = 5, FoodName = "Yeşil Üzüm", Kcal = 70, Protein = 0, Carbonhydrate = 17, Fat = 2, State = State.Created },
                new Food { Id = 125, CategoryId = 5, FoodName = "Muz", Kcal = 96, Protein = 1, Carbonhydrate = 23, Fat = 2, State = State.Created },
                new Food { Id = 126, CategoryId = 5, FoodName = "Kivi", Kcal = 61, Protein = 1, Carbonhydrate = 14, Fat = 5, State = State.Created },
                new Food { Id = 127, CategoryId = 5, FoodName = "Böğürtlen", Kcal = 43, Protein = 1, Carbonhydrate = 9, Fat = 4, State = State.Created },
                new Food { Id = 128, CategoryId = 5, FoodName = "İncir", Kcal = 74, Protein = 1, Carbonhydrate = 19, Fat = 3, State = State.Created },
                new Food { Id = 129, CategoryId = 5, FoodName = "Greyfurt", Kcal = 33, Protein = 1, Carbonhydrate = 8, Fat = 2, State = State.Created },
                new Food { Id = 130, CategoryId = 5, FoodName = "Limon", Kcal = 29, Protein = 1, Carbonhydrate = 9, Fat = 3, State = State.Created },
                new Food { Id = 131, CategoryId = 6, FoodName = "Whey Protein Tozu", Kcal = 120, Protein = 24, Carbonhydrate = 2, Fat = 1, State = State.Created },
                new Food { Id = 132, CategoryId = 6, FoodName = "Kreatin", Kcal = 20, Protein = 0, Carbonhydrate = 0.0, Fat = 0, State = State.Created },
                new Food { Id = 133, CategoryId = 6, FoodName = "BCAA", Kcal = 40, Protein = 9, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 134, CategoryId = 6, FoodName = "Glutamin", Kcal = 20, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 135, CategoryId = 6, FoodName = "Omega-3 Yağ Asitleri", Kcal = 10, Protein = 0, Carbonhydrate = 0, Fat = 1, State = State.Created },
                new Food { Id = 136, CategoryId = 6, FoodName = "Multivitamin Tablet", Kcal = 5, Protein = 0, Carbonhydrate = 5, Fat = 0, State = State.Created },
                new Food { Id = 137, CategoryId = 6, FoodName = "Kalsiyum + D3 Tablet", Kcal = 10, Protein = 0, Carbonhydrate = 2, Fat = 0, State = State.Created },
                new Food { Id = 138, CategoryId = 6, FoodName = "Demir Tablet", Kcal = 5, Protein = 0, Carbonhydrate = 1, Fat = 0, State = State.Created },
                new Food { Id = 139, CategoryId = 6, FoodName = "Magnezyum Tablet", Kcal = 5, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 140, CategoryId = 6, FoodName = "C Vitamini Tablet", Kcal = 10, Protein = 0, Carbonhydrate = 2, Fat = 0, State = State.Created },
                new Food { Id = 141, CategoryId = 7, FoodName = "Ali nazik", Kcal = 200, Protein = 25, Carbonhydrate = 10, Fat = 8, State = State.Created },
                new Food { Id = 142, CategoryId = 7, FoodName = "İmam bayıldı", Kcal = 300, Protein = 5, Carbonhydrate = 20, Fat = 25, State = State.Created },
                new Food { Id = 143, CategoryId = 7, FoodName = "Adana kebabı", Kcal = 280, Protein = 30, Carbonhydrate = 10, Fat = 15, State = State.Created },
                new Food { Id = 144, CategoryId = 7, FoodName = "İskender kebabı", Kcal = 400, Protein = 40, Carbonhydrate = 25, Fat = 18, State = State.Created },
                new Food { Id = 145, CategoryId = 7, FoodName = "Çerkez kavuğu", Kcal = 220, Protein = 20, Carbonhydrate = 8, Fat = 12, State = State.Created },
                new Food { Id = 146, CategoryId = 7, FoodName = "Lahmacun", Kcal = 280, Protein = 15, Carbonhydrate = 30, Fat = 12, State = State.Created },
                new Food { Id = 147, CategoryId = 7, FoodName = "Pilav üstü döner", Kcal = 350, Protein = 30, Carbonhydrate = 30, Fat = 15, State = State.Created },
                new Food { Id = 148, CategoryId = 7, FoodName = "Mantarlı tavuk", Kcal = 180, Protein = 22, Carbonhydrate = 5, Fat = 15, State = State.Created },
                new Food { Id = 149, CategoryId = 7, FoodName = "Hünkar beğendi", Kcal = 250, Protein = 15, Carbonhydrate = 20, Fat = 12, State = State.Created },
                new Food { Id = 150, CategoryId = 7, FoodName = "Mantı", Kcal = 350, Protein = 25, Carbonhydrate = 45, Fat = 6, State = State.Created },
                new Food { Id = 151, CategoryId = 7, FoodName = "Fırında levrek", Kcal = 120, Protein = 22, Carbonhydrate = 0, Fat = 3, State = State.Created },
                new Food { Id = 152, CategoryId = 7, FoodName = "Kuru fasulye pilav", Kcal = 250, Protein = 10, Carbonhydrate = 35, Fat = 8, State = State.Created },
                new Food { Id = 153, CategoryId = 7, FoodName = "Sebzeli tavuk sote", Kcal = 140, Protein = 18, Carbonhydrate = 4, Fat = 6, State = State.Created },
                new Food { Id = 154, CategoryId = 7, FoodName = "Mercimek çorbası", Kcal = 120, Protein = 8, Carbonhydrate = 15, Fat = 2, State = State.Created },
                new Food { Id = 155, CategoryId = 7, FoodName = "Zeytinyağlı fasulye", Kcal = 160, Protein = 7, Carbonhydrate = 18, Fat = 7, State = State.Created },
                new Food { Id = 156, CategoryId = 7, FoodName = "Tavuk şiş", Kcal = 280, Protein = 32, Carbonhydrate = 2, Fat = 16, State = State.Created },
                new Food { Id = 157, CategoryId = 7, FoodName = "Sebzeli bulgur pilavı", Kcal = 150, Protein = 4, Carbonhydrate = 30, Fat = 1, State = State.Created },
                new Food { Id = 158, CategoryId = 7, FoodName = "Ezogelin çorbası", Kcal = 90, Protein = 6, Carbonhydrate = 15, Fat = 3, State = State.Created },
                new Food { Id = 159, CategoryId = 7, FoodName = "Tavuklu şehriye çorbası", Kcal = 80, Protein = 7, Carbonhydrate = 12, Fat = 2, State = State.Created },
                new Food { Id = 160, CategoryId = 7, FoodName = "Domates çorbası", Kcal = 60, Protein = 4, Carbonhydrate = 8, Fat = 1, State = State.Created },
                new Food { Id = 161, CategoryId = 7, FoodName = "Yoğurt çorbası", Kcal = 100, Protein = 5, Carbonhydrate = 15, Fat = 3, State = State.Created },
                new Food { Id = 162, CategoryId = 7, FoodName = "Tarhana çorbası", Kcal = 120, Protein = 5, Carbonhydrate = 20, Fat = 4, State = State.Created },
                new Food { Id = 163, CategoryId = 7, FoodName = "Şehriye çorbası", Kcal = 90, Protein = 6, Carbonhydrate = 12, Fat = 2, State = State.Created },
                new Food { Id = 164, CategoryId = 7, FoodName = "Yayla çorbası çorbası", Kcal = 80, Protein = 5, Carbonhydrate = 10, Fat = 2, State = State.Created },
                new Food { Id = 165, CategoryId = 7, FoodName = "Sebze çorbası", Kcal = 70, Protein = 4, Carbonhydrate = 9, Fat = 2, State = State.Created },
                new Food { Id = 166, CategoryId = 7, FoodName = "Mantar çorbası", Kcal = 100, Protein = 6, Carbonhydrate = 12, Fat = 3, State = State.Created },
                new Food { Id = 167, CategoryId = 8, FoodName = "Süt", Kcal = 42, Protein = 3, Carbonhydrate = 4, Fat = 1, State = State.Created },
                new Food { Id = 168, CategoryId = 8, FoodName = "Yoğurt", Kcal = 59, Protein = 3, Carbonhydrate = 4, Fat = 2, State = State.Created },
                new Food { Id = 169, CategoryId = 8, FoodName = "Peynir", Kcal = 300, Protein = 25, Carbonhydrate = 1, Fat = 22, State = State.Created },
                new Food { Id = 170, CategoryId = 8, FoodName = "Fındık yağı", Kcal = 884, Protein = 0, Carbonhydrate = 0, Fat = 100, State = State.Created },
                new Food { Id = 171, CategoryId = 8, FoodName = "Ayçiçek yağı", Kcal = 884, Protein = 0, Carbonhydrate = 0, Fat = 100, State = State.Created },
                new Food { Id = 172, CategoryId = 8, FoodName = "Zeytin yağı", Kcal = 884, Protein = 0, Carbonhydrate = 0, Fat = 100, State = State.Created },
                new Food { Id = 173, CategoryId = 8, FoodName = "Tereyağ", Kcal = 717, Protein = 1, Carbonhydrate = 0, Fat = 81, State = State.Created },
                new Food { Id = 174, CategoryId = 8, FoodName = "Un", Kcal = 364, Protein = 10, Carbonhydrate = 76, Fat = 1, State = State.Created },
                new Food { Id = 175, CategoryId = 8, FoodName = "Pirinç", Kcal = 130, Protein = 2, Carbonhydrate = 28, Fat = 0, State = State.Created },
                new Food { Id = 176, CategoryId = 8, FoodName = "Bulgur", Kcal = 342, Protein = 12, Carbonhydrate = 70, Fat = 1, State = State.Created },
                new Food { Id = 177, CategoryId = 8, FoodName = "Makarna", Kcal = 158, Protein = 5, Carbonhydrate = 30, Fat = 1, State = State.Created },
                new Food { Id = 178, CategoryId = 9, FoodName = "Beyaz ekmek", Kcal = 266, Protein = 8, Carbonhydrate = 50, Fat = 3, State = State.Created },
                new Food { Id = 179, CategoryId = 9, FoodName = "Kepekli ekmek", Kcal = 216, Protein = 6, Carbonhydrate = 44, Fat = 1, State = State.Created },
                new Food { Id = 180, CategoryId = 9, FoodName = "Çavdar ekmeği", Kcal = 259, Protein = 7, Carbonhydrate = 43, Fat = 1, State = State.Created },
                new Food { Id = 181, CategoryId = 9, FoodName = "Tam buğday ekmeği", Kcal = 247, Protein = 12, Carbonhydrate = 42, Fat = 1, State = State.Created },
                new Food { Id = 182, CategoryId = 9, FoodName = "Çörek", Kcal = 259, Protein = 7, Carbonhydrate = 43, Fat = 1, State = State.Created },
                new Food { Id = 183, CategoryId = 9, FoodName = "Sade poğaça", Kcal = 300, Protein = 5, Carbonhydrate = 23, Fat = 17, State = State.Created },
                new Food { Id = 184, CategoryId = 9, FoodName = "Peynirli poğaça", Kcal = 351, Protein = 10, Carbonhydrate = 30, Fat = 18, State = State.Created },
                new Food { Id = 185, CategoryId = 9, FoodName = "Zeytinli poğaça", Kcal = 390, Protein = 5, Carbonhydrate = 23, Fat = 17, State = State.Created },
                new Food { Id = 186, CategoryId = 9, FoodName = "Patatesli poğaça", Kcal = 328, Protein = 5, Carbonhydrate = 28, Fat = 21, State = State.Created },
                new Food { Id = 187, CategoryId = 9, FoodName = "Kruvasan", Kcal = 406, Protein = 8, Carbonhydrate = 43, Fat = 22, State = State.Created },
                new Food { Id = 188, CategoryId = 9, FoodName = "Çikolatalı kruvasan", Kcal = 530, Protein = 8, Carbonhydrate = 45, Fat = 36, State = State.Created },
                new Food { Id = 189, CategoryId = 9, FoodName = "Simit", Kcal = 313, Protein = 10, Carbonhydrate = 60, Fat = 2, State = State.Created },
                new Food { Id = 190, CategoryId = 9, FoodName = "Tereyağlı Kurabiye", Kcal = 488, Protein = 6, Carbonhydrate = 70, Fat = 55, State = State.Created },
                new Food { Id = 191, CategoryId = 9, FoodName = "Sade kek", Kcal = 333, Protein = 6, Carbonhydrate = 56, Fat = 11, State = State.Created },
                new Food { Id = 192, CategoryId = 9, FoodName = "Çikolatalı kek", Kcal = 340, Protein = 8, Carbonhydrate = 40, Fat = 16, State = State.Created },
                new Food { Id = 193, CategoryId = 9, FoodName = "Çikolatalı pasta", Kcal = 350, Protein = 5, Carbonhydrate = 45, Fat = 18, State = State.Created },
                new Food { Id = 194, CategoryId = 9, FoodName = "Cheesecake", Kcal = 320, Protein = 6, Carbonhydrate = 30, Fat = 20, State = State.Created },
                new Food { Id = 195, CategoryId = 9, FoodName = "Mozaik pasta", Kcal = 400, Protein = 4, Carbonhydrate = 55, Fat = 18, State = State.Created },
                new Food { Id = 196, CategoryId = 9, FoodName = "Meyveli pasta", Kcal = 280, Protein = 3, Carbonhydrate = 40, Fat = 12, State = State.Created },
                new Food { Id = 197, CategoryId = 9, FoodName = "Havuçlu kek", Kcal = 320, Protein = 4, Carbonhydrate = 40, Fat = 15, State = State.Created },
                new Food { Id = 198, CategoryId = 9, FoodName = "Çilekli pasta", Kcal = 290, Protein = 3, Carbonhydrate = 35, Fat = 16, State = State.Created },
                new Food { Id = 199, CategoryId = 9, FoodName = "Sade börek", Kcal = 313, Protein = 13, Carbonhydrate = 29, Fat = 17, State = State.Created },
                new Food { Id = 200, CategoryId = 9, FoodName = "Peynirli börek", Kcal = 389, Protein = 15, Carbonhydrate = 50, Fat = 13, State = State.Created },
                new Food { Id = 201, CategoryId = 9, FoodName = "Patatesli börek", Kcal = 272, Protein = 6, Carbonhydrate = 40, Fat = 12, State = State.Created },
                new Food { Id = 202, CategoryId = 9, FoodName = "Ispanaklı börek", Kcal = 200, Protein = 5, Carbonhydrate = 28, Fat = 4, State = State.Created },
                new Food { Id = 203, CategoryId = 9, FoodName = "Kıymalı börek", Kcal = 389, Protein = 15, Carbonhydrate = 50, Fat = 13, State = State.Created },
                new Food { Id = 204, CategoryId = 9, FoodName = "Kaşarlı pide", Kcal = 320, Protein = 16, Carbonhydrate = 30, Fat = 14, State = State.Created },
                new Food { Id = 205, CategoryId = 9, FoodName = "Kıymalı pide", Kcal = 350, Protein = 18, Carbonhydrate = 35, Fat = 15, State = State.Created },
                new Food { Id = 206, CategoryId = 9, FoodName = "Kuşbaşılı pide", Kcal = 350, Protein = 18, Carbonhydrate = 35, Fat = 15, State = State.Created },
                new Food { Id = 207, CategoryId = 9, FoodName = "Peynirli pide", Kcal = 290, Protein = 12, Carbonhydrate = 25, Fat = 14, State = State.Created },
                new Food { Id = 208, CategoryId = 9, FoodName = "Ispanaklı pide", Kcal = 260, Protein = 10, Carbonhydrate = 30, Fat = 11, State = State.Created },
                new Food { Id = 209, CategoryId = 9, FoodName = "Karışık pide", Kcal = 380, Protein = 20, Carbonhydrate = 40, Fat = 16, State = State.Created },
                new Food { Id = 210, CategoryId = 9, FoodName = "Pastırmalı pide", Kcal = 340, Protein = 15, Carbonhydrate = 30, Fat = 18, State = State.Created },
                new Food { Id = 211, CategoryId = 10, FoodName = "Su", Kcal = 0, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 212, CategoryId = 10, FoodName = "Soda", Kcal = 0, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 213, CategoryId = 10, FoodName = "Kola", Kcal = 42, Protein = 0, Carbonhydrate = 10, Fat = 0, State = State.Created },
                new Food { Id = 214, CategoryId = 10, FoodName = "Portakal suyu", Kcal = 46, Protein = 1, Carbonhydrate = 11, Fat = 0, State = State.Created },
                new Food { Id = 215, CategoryId = 10, FoodName = "Ayran", Kcal = 40, Protein = 1, Carbonhydrate = 2, Fat = 2, State = State.Created },
                new Food { Id = 216, CategoryId = 10, FoodName = "Limonata", Kcal = 43, Protein = 0, Carbonhydrate = 11, Fat = 0, State = State.Created },
                new Food { Id = 217, CategoryId = 10, FoodName = "Çay", Kcal = 1, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 218, CategoryId = 10, FoodName = "Filtre kahve", Kcal = 1, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 219, CategoryId = 10, FoodName = "Türk kahvesi", Kcal = 1, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 220, CategoryId = 10, FoodName = "Gazoz", Kcal = 42, Protein = 0, Carbonhydrate = 10, Fat = 0, State = State.Created },
                new Food { Id = 221, CategoryId = 10, FoodName = "Elma suyu", Kcal = 47, Protein = 0, Carbonhydrate = 11, Fat = 0, State = State.Created },
                new Food { Id = 222, CategoryId = 10, FoodName = "Şeftali suyu", Kcal = 56, Protein = 1, Carbonhydrate = 13, Fat = 0, State = State.Created },
                new Food { Id = 223, CategoryId = 10, FoodName = "Greyfurt suyu", Kcal = 39, Protein = 0, Carbonhydrate = 9, Fat = 0, State = State.Created },
                new Food { Id = 224, CategoryId = 10, FoodName = "Ihlamur", Kcal = 0, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 225, CategoryId = 10, FoodName = "Naneli limonata", Kcal = 43, Protein = 0, Carbonhydrate = 11, Fat = 0, State = State.Created },
                new Food { Id = 226, CategoryId = 10, FoodName = "Adaçayı", Kcal = 0, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 227, CategoryId = 10, FoodName = "Papatya çayı", Kcal = 0, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created },
                new Food { Id = 228, CategoryId = 10, FoodName = "Yeşil çay", Kcal = 0, Protein = 0, Carbonhydrate = 0, Fat = 0, State = State.Created }

                
                );

        }
    }
}
