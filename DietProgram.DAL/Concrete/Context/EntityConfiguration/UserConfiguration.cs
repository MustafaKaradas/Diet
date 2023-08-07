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
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            

            builder.Property(x => x.UserName)
                .IsRequired()
                .HasColumnName("Kullanıcı Adı")
                .HasMaxLength(30);

            builder.HasIndex(x => x.UserName)
                .IsUnique();

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("Şifre");

            builder.Property(x => x.SecurityCode)
                .IsRequired()
                .HasColumnName("Güvenlik Kodu")
                .HasMaxLength(8);

            builder.HasIndex(x=>x.SecurityCode)
                    .IsUnique();

            builder.HasData(
                new User { Id = 1, UserName = "mustafa@gmail.com", Password = "GUclusifre.19", SecurityCode = 664086, UserInfoId = 1, State = Core.Enums.State.Created },
                new User { Id = 2, UserName = "dilara@gmail.com", Password = "GucsuzSifre.06", SecurityCode = 897513, UserInfoId = 2, State = Core.Enums.State.Created },
                new User { Id = 3, UserName = "RoniHoca@gmail.com", Password = "RoniAluf.19", SecurityCode = 467823, UserInfoId = 3, State = Core.Enums.State.Created }

                );
            

            base.Configure(builder);
        }
    }
}
