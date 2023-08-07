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
    public class AdminConfiguration : BaseConfiguration<Admin>
    {
        public override void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(x => x.Password).IsRequired()
                .HasColumnName("Şifre");

            builder.HasData(new Admin
            {
                Password = "admin",
                Id = 1,
                State = State.Created
            });
            base.Configure(builder);
        }
    }
}
