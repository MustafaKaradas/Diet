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
    public class FoodDetailConfiguration : BaseConfiguration<FoodDetail>
    {
        public override void Configure(EntityTypeBuilder<FoodDetail> builder)
        {

            


            builder.Property(x => x.BreakfastCal)
                .IsRequired()
                .HasColumnName("Kahvaltı Kalorisi");

            builder.Property(x => x.DinnerCal)
               .IsRequired()
               .HasColumnName("Akşam Yemeği Kalorisi");

            builder.Property(x => x.LunchCal)
               .IsRequired()
               .HasColumnName("Öğle Yemeği Kalorisi");

            builder.Property(x => x.SnackCal)
               .IsRequired()
               .HasColumnName("Ara Öğün Kalorisi");

            builder.Property(x => x.TakenProtein)
                .IsRequired()
                .HasColumnName("Alınan Kalori");

            builder.Property(x => x.TakenCarbonhydrate)
                .IsRequired()
                .HasColumnName("Alınan Karbonhidrat");

            builder.Property(x => x.TakenFat)
                .IsRequired()
                .HasColumnName("Alınan Yağ");

            
                


            base.Configure(builder);

        }
    }
}
