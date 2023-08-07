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
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName)
                .HasMaxLength(20)
                .IsRequired()
                .HasColumnName("Kategori Adı");

            builder.HasIndex(x => x.CategoryName)
                .IsUnique();

            builder.Property(x => x.CategoryDescription)
                .HasMaxLength(300)
                .HasColumnName("Kategori Açıklaması");

            base.Configure(builder);

            builder.HasData(
            new Category{ CategoryName = "Tümü", CategoryDescription = "Tüm kategorilerdeki ürünleri bulundurur.", Id = 1, State = State.Created },
            new Category { CategoryName = "Atıştırmalıklar", CategoryDescription = "Asıl yemekten sayılmayan, peynir, zeytin vb. yiyecekler. Yemek dışında yenilen yaş veya kuru yemiş vb. şeyler, atıştırmalık.", Id = 2, State = State.Created },
            new Category { CategoryName = "Kahvaltılık", CategoryDescription = "Sabah tüketilen, günün ilk öğünüdür.", Id = 3, State = State.Created },
            new Category { CategoryName = "Et,Tavuk,Balık", CategoryDescription = "Her çeşit etler.", Id = 4, State = State.Created },
            new Category { CategoryName = "Meyve ve Sebze", CategoryDescription = "Ağaçların yenilecek türden ürünü.bitkilerin insanlar veya diğer hayvanlar tarafından yenen kısımlarına verilen isimdir.", Id = 5, State = State.Created },
            new Category { CategoryName = "Besin Takviyeleri", CategoryDescription = "Gıda takviyeleri, hap, tablet, kapsül, sıvı, vb. formunda sağlanan vitaminler, mineraller, aminoasitler, yağ asitleri ve diğer maddeler olabilir.", Id = 6, State = State.Created },
            new Category { CategoryName="Yemek", CategoryDescription= "Yiyecek, canlıların hayatlarını devam ettirebilmeleri için yemek suretiyle tüketmeleri gereken maddelerdir. Belirli bir öğünde tüketilen yiyecekler.", Id=7, State = State.Created },
            new Category { CategoryName="Gıda", CategoryDescription= ": Doğrudan insan tüketimine sunulmayan canlı hayvanlar, yem, hasat edilmemiş bitkiler,tedavi amaçlı kullanılan tıbbi ürünler,kozmetikler, içilmesi beklenen işlenmiş, kısmen işlenmiş veya işlenmemiş her türlü madde", Id=8, State=State.Created },
            new Category { CategoryName = "Unlu Mamüller",CategoryDescription = "Unlu mamüller olarak en çok tükettiğimiz ürünler ekmek, makarna, bulgur ve bisküvidir. Bunların dışında, kek, pasta, turta, tart, yufka, çeşitli çörekler, börek, gofret, kurabiye, hazır pasta altlığı, " +
            "peksimet ve benzeri ürünler bu gruba girerler.", Id = 9,State = State.Created},
             new Category { CategoryName="İçecek", CategoryDescription= "İçecek, içerek tüketilen ve alkollü ve alkolsüz olmak üzere ikiye ayrılan sıvı gıdaların tümü.", Id=10, State=State.Created}       
             ) ;

        }
    }
}
