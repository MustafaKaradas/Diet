using DietProgram.DAL.Concrete.EntityConfiguration;
using DietProgram.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.DAL.Concrete.Context.EntityConfiguration
{
    public class UserInfoConfiguration  : BaseConfiguration<UserInfo>
    {
        public override void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("İsim");

            builder.Property(x => x.Gender)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("Cinsiyet");

            builder.Property(x => x.Age)
                .IsRequired()
                .HasColumnName("Yaş");

            builder.Property(x => x.Height)
                .IsRequired()
                .HasColumnName("Boy");

            builder.Property(x => x.Weight)
                .IsRequired()
                .HasColumnName("Kilo");

            builder.Property(x => x.WCircum)
                .IsRequired(false)
                .HasColumnName("Bel Çevresi");

            builder.Property(x => x.NCircum)
                .IsRequired(false)
                .HasColumnName("Boyun Çevresi");

            builder.Property(x => x.HCircum)
              .IsRequired(false)
              .HasColumnName("Kalça Çevresi");

            builder.Property(x => x.Activite)
              .IsRequired(false)
              .HasMaxLength(5)
              .HasColumnName("Aktiflik Düzeyi");

            builder.Property(x => x.UserId)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithOne(x => x.UserInfos)
                .HasForeignKey<UserInfo>(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new UserInfo
            {
                Id=1,Name="Mustafa",Gender="Erkek", Age=27 , Height = 175, Weight=68 , WCircum= 75, NCircum=30, HCircum = 100, Activite="çok", UserId=1 , TotalCalorie = 1693, State= Core.Enums.State.Created
            },
            new UserInfo
            {
                Id = 2,
                Name = "Dilara",
                Gender = "Kadın",
                Age = 24,
                Height = 162,
                Weight = 50,
                WCircum = 62,
                NCircum = 25,
                HCircum = 91,
                Activite = "Az",
                UserId = 2,
                TotalCalorie = 1608,
                State = Core.Enums.State.Created
            },
              new UserInfo
              {
                  Id = 3,
                  Name = "Roni Aluf",
                  Gender = "Erkek",
                  Age = 55,
                  Height = 177,
                  Weight = 70,
                  WCircum = 82,
                  NCircum = 32,
                  HCircum = 105,
                  Activite = "Orta",
                  UserId = 3,
                  TotalCalorie = 2158,
                  State = Core.Enums.State.Created
              });
  
            base.Configure(builder);
        }
    }
}
