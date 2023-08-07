using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietProgram.DAL.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Şifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdı = table.Column<string>(name: "Kategori Adı", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    KategoriAçıklaması = table.Column<string>(name: "Kategori Açıklaması", type: "nvarchar(300)", maxLength: 300, nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KahvaltıKalorisi = table.Column<double>(name: "Kahvaltı Kalorisi", type: "float", nullable: false),
                    AkşamYemeğiKalorisi = table.Column<double>(name: "Akşam Yemeği Kalorisi", type: "float", nullable: false),
                    ÖğleYemeğiKalorisi = table.Column<double>(name: "Öğle Yemeği Kalorisi", type: "float", nullable: false),
                    AraÖğünKalorisi = table.Column<double>(name: "Ara Öğün Kalorisi", type: "float", nullable: false),
                    AlınanKalori = table.Column<double>(name: "Alınan Kalori", type: "float", nullable: false),
                    AlınanKarbonhidrat = table.Column<double>(name: "Alınan Karbonhidrat", type: "float", nullable: false),
                    AlınanYağ = table.Column<double>(name: "Alınan Yağ", type: "float", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFoodInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: true),
                    YemekAdı = table.Column<string>(name: "Yemek Adı", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    ÖğünAdı = table.Column<string>(name: "Öğün Adı", type: "nvarchar(25)", maxLength: 25, nullable: false),
                    YenmeTarihi = table.Column<DateTime>(name: "Yenme Tarihi", type: "datetime2", nullable: true),
                    AlınanKalori = table.Column<int>(name: "Alınan Kalori", type: "int", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Karbonhidrat = table.Column<double>(type: "float", nullable: false),
                    Yağ = table.Column<double>(type: "float", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoodInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullanıcıAdı = table.Column<string>(name: "Kullanıcı Adı", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    GüvenlikKodu = table.Column<int>(name: "Güvenlik Kodu", type: "int", maxLength: 8, nullable: false),
                    UserInfoId = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Yemekİsmi = table.Column<string>(name: "Yemek İsmi", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Karbonhidrat = table.Column<double>(type: "float", nullable: false),
                    Yağ = table.Column<double>(type: "float", nullable: false),
                    Resim = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FoodDetailID = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Foods_Meals_FoodDetailID",
                        column: x => x.FoodDetailID,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Yaş = table.Column<int>(type: "int", nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<int>(type: "int", nullable: false),
                    BelÇevresi = table.Column<int>(name: "Bel Çevresi", type: "int", nullable: true),
                    KalçaÇevresi = table.Column<int>(name: "Kalça Çevresi", type: "int", nullable: true),
                    BoyunÇevresi = table.Column<int>(name: "Boyun Çevresi", type: "int", nullable: true),
                    AktiflikDüzeyi = table.Column<string>(name: "Aktiflik Düzeyi", type: "nvarchar(5)", maxLength: 5, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalCalorie = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserUserFoodInfo",
                columns: table => new
                {
                    UserFoodInfosId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUserFoodInfo", x => new { x.UserFoodInfosId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserUserFoodInfo_UserFoodInfos_UserFoodInfosId",
                        column: x => x.UserFoodInfosId,
                        principalTable: "UserFoodInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUserFoodInfo_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodUserFoodInfo",
                columns: table => new
                {
                    FoodsId = table.Column<int>(type: "int", nullable: false),
                    UserFoodInfosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodUserFoodInfo", x => new { x.FoodsId, x.UserFoodInfosId });
                    table.ForeignKey(
                        name: "FK_FoodUserFoodInfo_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodUserFoodInfo_UserFoodInfos_UserFoodInfosId",
                        column: x => x.UserFoodInfosId,
                        principalTable: "UserFoodInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "Şifre", "State" },
                values: new object[] { 1, "admin", "Created" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Kategori Açıklaması", "Kategori Adı", "FoodId", "State" },
                values: new object[,]
                {
                    { 1, "Tüm kategorilerdeki ürünleri bulundurur.", "Tümü", null, "Created" },
                    { 2, "Asıl yemekten sayılmayan, peynir, zeytin vb. yiyecekler. Yemek dışında yenilen yaş veya kuru yemiş vb. şeyler, atıştırmalık.", "Atıştırmalıklar", null, "Created" },
                    { 3, "Sabah tüketilen, günün ilk öğünüdür.", "Kahvaltılık", null, "Created" },
                    { 4, "Her çeşit etler.", "Et,Tavuk,Balık", null, "Created" },
                    { 5, "Ağaçların yenilecek türden ürünü.bitkilerin insanlar veya diğer hayvanlar tarafından yenen kısımlarına verilen isimdir.", "Meyve ve Sebze", null, "Created" },
                    { 6, "Gıda takviyeleri, hap, tablet, kapsül, sıvı, vb. formunda sağlanan vitaminler, mineraller, aminoasitler, yağ asitleri ve diğer maddeler olabilir.", "Besin Takviyeleri", null, "Created" },
                    { 7, "Yiyecek, canlıların hayatlarını devam ettirebilmeleri için yemek suretiyle tüketmeleri gereken maddelerdir. Belirli bir öğünde tüketilen yiyecekler.", "Yemek", null, "Created" },
                    { 8, ": Doğrudan insan tüketimine sunulmayan canlı hayvanlar, yem, hasat edilmemiş bitkiler,tedavi amaçlı kullanılan tıbbi ürünler,kozmetikler, içilmesi beklenen işlenmiş, kısmen işlenmiş veya işlenmemiş her türlü madde", "Gıda", null, "Created" },
                    { 9, "Unlu mamüller olarak en çok tükettiğimiz ürünler ekmek, makarna, bulgur ve bisküvidir. Bunların dışında, kek, pasta, turta, tart, yufka, çeşitli çörekler, börek, gofret, kurabiye, hazır pasta altlığı, peksimet ve benzeri ürünler bu gruba girerler.", "Unlu Mamüller", null, "Created" },
                    { 10, "İçecek, içerek tüketilen ve alkollü ve alkolsüz olmak üzere ikiye ayrılan sıvı gıdaların tümü.", "İçecek", null, "Created" }
                });

            migrationBuilder.InsertData(
                table: "UserFoodInfos",
                columns: new[] { "Id", "Karbonhidrat", "Yenme Tarihi", "Yağ", "FoodId", "Yemek Adı", "Kalori", "Öğün Adı", "Porsiyon", "Protein", "State", "Alınan Kalori", "UserId" },
                values: new object[,]
                {
                    { 1, 12.0, new DateTime(2023, 8, 1, 8, 50, 33, 0, DateTimeKind.Unspecified), 22.0, null, "Siyah Zeytin", 120.0, "Kahvaltı", 2, 2.0, 0, 240, 3 },
                    { 2, 0.0, new DateTime(2023, 7, 31, 13, 40, 33, 0, DateTimeKind.Unspecified), 1.0, null, "Izgara Tavuk", 200.0, "Öğle Yemeği", 1, 25.0, 0, 200, 3 },
                    { 3, 0.0, new DateTime(2023, 7, 1, 20, 32, 33, 0, DateTimeKind.Unspecified), 15.0, null, "Somon balığı", 220.0, "Akşam Yemeği", 1, 25.0, 0, 220, 3 },
                    { 4, 20.0, new DateTime(2023, 7, 2, 17, 14, 33, 0, DateTimeKind.Unspecified), 10.0, null, "Etli Çiğ Köfte", 200.0, "Ara Öğün", 2, 15.0, 0, 400, 3 },
                    { 5, 1.0, new DateTime(2023, 7, 22, 10, 50, 38, 0, DateTimeKind.Unspecified), 20.0, null, "Beyaz peynir", 120.0, "Kahvaltı", 1, 17.0, 0, 120, 3 },
                    { 6, 10.0, new DateTime(2023, 7, 22, 14, 45, 12, 0, DateTimeKind.Unspecified), 0.0, null, "Kola", 42.0, "Öğle Yemeği", 1, 0.0, 0, 42, 3 },
                    { 7, 35.0, new DateTime(2023, 7, 21, 21, 8, 33, 0, DateTimeKind.Unspecified), 15.0, null, "Kuşbaşılı pide", 350.0, "Akşam Yemeği", 1, 18.0, 0, 350, 3 },
                    { 8, 20.0, new DateTime(2023, 7, 18, 17, 17, 33, 0, DateTimeKind.Unspecified), 12.0, null, "Hünkar beğendi", 250.0, "Ara Öğün", 2, 15.0, 0, 500, 3 },
                    { 9, 12.0, new DateTime(2023, 8, 1, 8, 50, 33, 0, DateTimeKind.Unspecified), 22.0, null, "Siyah Zeytin", 120.0, "Kahvaltı", 2, 2.0, 0, 240, 1 },
                    { 10, 0.0, new DateTime(2023, 7, 31, 13, 40, 33, 0, DateTimeKind.Unspecified), 1.0, null, "Izgara Tavuk", 200.0, "Öğle Yemeği", 1, 25.0, 0, 200, 1 },
                    { 11, 0.0, new DateTime(2023, 7, 1, 20, 32, 33, 0, DateTimeKind.Unspecified), 15.0, null, "Somon balığı", 220.0, "Akşam Yemeği", 1, 25.0, 0, 220, 1 },
                    { 12, 20.0, new DateTime(2023, 7, 2, 17, 14, 33, 0, DateTimeKind.Unspecified), 10.0, null, "Etli Çiğ Köfte", 200.0, "Ara Öğün", 2, 15.0, 0, 400, 1 },
                    { 13, 1.0, new DateTime(2023, 7, 22, 10, 50, 38, 0, DateTimeKind.Unspecified), 20.0, null, "Beyaz peynir", 120.0, "Kahvaltı", 1, 17.0, 0, 120, 1 },
                    { 14, 10.0, new DateTime(2023, 7, 22, 14, 45, 12, 0, DateTimeKind.Unspecified), 0.0, null, "Kola", 42.0, "Öğle Yemeği", 1, 0.0, 0, 42, 1 },
                    { 15, 35.0, new DateTime(2023, 7, 21, 21, 8, 33, 0, DateTimeKind.Unspecified), 15.0, null, "Kuşbaşılı pide", 350.0, "Akşam Yemeği", 1, 18.0, 0, 350, 1 },
                    { 16, 20.0, new DateTime(2023, 7, 18, 17, 17, 33, 0, DateTimeKind.Unspecified), 12.0, null, "Hünkar beğendi", 250.0, "Ara Öğün", 2, 15.0, 0, 500, 1 },
                    { 17, 12.0, new DateTime(2023, 8, 1, 8, 50, 33, 0, DateTimeKind.Unspecified), 22.0, null, "Siyah Zeytin", 120.0, "Kahvaltı", 2, 2.0, 0, 240, 2 },
                    { 18, 0.0, new DateTime(2023, 7, 31, 13, 40, 33, 0, DateTimeKind.Unspecified), 1.0, null, "Izgara Tavuk", 200.0, "Öğle Yemeği", 1, 25.0, 0, 200, 2 },
                    { 19, 0.0, new DateTime(2023, 7, 1, 20, 32, 33, 0, DateTimeKind.Unspecified), 15.0, null, "Somon balığı", 220.0, "Akşam Yemeği", 1, 25.0, 0, 220, 2 },
                    { 20, 20.0, new DateTime(2023, 7, 2, 17, 14, 33, 0, DateTimeKind.Unspecified), 10.0, null, "Etli Çiğ Köfte", 200.0, "Ara Öğün", 2, 15.0, 0, 400, 2 },
                    { 21, 1.0, new DateTime(2023, 7, 22, 10, 50, 38, 0, DateTimeKind.Unspecified), 20.0, null, "Beyaz peynir", 120.0, "Kahvaltı", 1, 17.0, 0, 120, 2 },
                    { 22, 10.0, new DateTime(2023, 7, 22, 14, 45, 12, 0, DateTimeKind.Unspecified), 0.0, null, "Kola", 42.0, "Öğle Yemeği", 1, 0.0, 0, 42, 2 },
                    { 23, 35.0, new DateTime(2023, 7, 21, 21, 8, 33, 0, DateTimeKind.Unspecified), 15.0, null, "Kuşbaşılı pide", 350.0, "Akşam Yemeği", 1, 18.0, 0, 350, 2 },
                    { 24, 20.0, new DateTime(2023, 7, 18, 17, 17, 33, 0, DateTimeKind.Unspecified), 12.0, null, "Hünkar beğendi", 250.0, "Ara Öğün", 2, 15.0, 0, 500, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Şifre", "Güvenlik Kodu", "State", "UserInfoId", "Kullanıcı Adı" },
                values: new object[,]
                {
                    { 1, "GUclusifre.19", 664086, "Created", 1, "mustafa@gmail.com" },
                    { 2, "GucsuzSifre.06", 897513, "Created", 2, "dilara@gmail.com" },
                    { 3, "RoniAluf.19", 467823, "Created", 3, "RoniHoca@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Karbonhidrat", "CategoryId", "Yağ", "FoodDetailID", "Yemek İsmi", "Kalori", "Resim", "Protein", "State" },
                values: new object[,]
                {
                    { 1, 55.0, 2, 34.0, null, "Cips", 540.0, null, 7.0, 0 },
                    { 2, 50.0, 2, 20.0, null, "Kurabiye", 400.0, null, 8.0, 0 },
                    { 3, 55.0, 2, 35.0, null, "Çikolata", 550.0, null, 5.0, 0 },
                    { 4, 15.0, 2, 61.0, null, "Fındık", 650.0, null, 15.0, 0 },
                    { 5, 14.0, 2, 65.0, null, "Ceviz", 650.0, null, 15.0, 0 },
                    { 6, 50.0, 2, 20.0, null, "Badem", 400.0, null, 8.0, 0 },
                    { 7, 32.0, 2, 46.0, null, "Kaju", 570.0, null, 18.0, 0 },
                    { 8, 38.0, 2, 15.0, null, "Leblebi", 350.0, null, 19.0, 0 },
                    { 9, 75.0, 2, 5.0, null, "Patlamış mısır", 370.0, null, 8.0, 0 },
                    { 10, 62.0, 2, 16.0, null, "Kraker", 430.0, null, 8.0, 0 },
                    { 11, 62.0, 2, 22.0, null, "Bisküvi", 480.0, null, 6.0, 0 },
                    { 12, 22.0, 2, 13.0, null, "Makarna salatası", 200.0, null, 3.0, 0 },
                    { 13, 25.0, 2, 15.0, null, "Biber kızartması", 220.0, null, 4.0, 0 },
                    { 14, 28.0, 2, 14.0, null, "Pizza dilimleri", 230.0, null, 5.0, 0 },
                    { 15, 30.0, 2, 12.0, null, "Mısır cipsi", 190.0, null, 6.0, 0 },
                    { 16, 28.0, 2, 13.0, null, "Tost", 180.0, null, 2.0, 0 },
                    { 17, 25.0, 2, 12.0, null, "Muffin", 210.0, null, 3.0, 0 },
                    { 18, 20.0, 2, 15.0, null, "browni", 240.0, null, 4.0, 0 },
                    { 19, 1.0, 3, 5.0, null, "Haslanmis yumurta", 80.0, null, 6.0, 0 },
                    { 20, 60.0, 3, 7.0, null, "Yulaf ezmesi", 380.0, null, 13.0, 0 },
                    { 21, 4.0, 3, 17.0, null, "Peynirli omlet", 220.0, null, 15.0, 0 },
                    { 22, 5.0, 3, 9.0, null, "Domatesli omlet", 130.0, null, 8.0, 0 },
                    { 23, 1.0, 3, 24.0, null, "Sucuklu yumurta", 280.0, null, 14.0, 0 },
                    { 24, 6.0, 3, 14.0, null, "Menemen", 170.0, null, 7.0, 0 },
                    { 25, 85.0, 3, 2.0, null, "Mısır gevreği", 360.0, null, 9.0, 0 },
                    { 26, 33.0, 3, 20.0, null, "Poğaça", 340.0, null, 8.0, 0 },
                    { 27, 65.0, 3, 2.0, null, "Üçgen peynirli simit", 330.0, null, 10.0, 0 },
                    { 28, 25.0, 3, 20.0, null, "Börek", 320.0, null, 12.0, 0 },
                    { 29, 50.0, 3, 2.0, null, "Ekmek", 250.0, null, 10.0, 0 },
                    { 30, 65.0, 3, 0.0, null, "Reçel", 260.0, null, 0.0, 0 },
                    { 31, 76.0, 3, 0.0, null, "Üzüm reçeli", 300.0, null, 1.0, 0 },
                    { 32, 67.0, 3, 0.0, null, "Kayısı reçeli", 270.0, null, 1.0, 0 },
                    { 33, 63.0, 3, 0.0, null, "Çilek reçeli", 260.0, null, 1.0, 0 },
                    { 34, 70.0, 3, 0.0, null, "Portakal reçeli", 280.0, null, 1.0, 0 },
                    { 35, 66.0, 3, 0.0, null, "Vişne reçeli", 270.0, null, 1.0, 0 },
                    { 36, 64.0, 3, 0.0, null, "Erik reçeli", 260.0, null, 1.0, 0 },
                    { 37, 82.0, 3, 0.0, null, "Bal", 330.0, null, 0.0, 0 },
                    { 38, 20.0, 3, 53.0, null, "Tahin", 595.0, null, 20.0, 0 },
                    { 39, 70.0, 3, 1.0, null, "Pekmez", 290.0, null, 1.0, 0 },
                    { 40, 30.0, 3, 25.0, null, "Sigara böreği", 400.0, null, 10.0, 0 },
                    { 41, 1.0, 3, 30.0, null, "Kaşar peyniri", 350.0, null, 22.0, 0 },
                    { 42, 28.0, 3, 11.0, null, "Patates kızartması", 220.0, null, 3.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Karbonhidrat", "CategoryId", "Yağ", "FoodDetailID", "Yemek İsmi", "Kalori", "Resim", "Protein", "State" },
                values: new object[,]
                {
                    { 43, 0.0, 3, 32.0, null, "Kavurma", 360.0, null, 20.0, 0 },
                    { 44, 3.0, 3, 48.0, null, "Kaymak", 460.0, null, 4.0, 0 },
                    { 45, 1.0, 3, 4.0, null, "yeşil soğan", 400.0, null, 20.0, 0 },
                    { 46, 3.0, 3, 0.0, null, "hıyar", 15.0, null, 0.0, 0 },
                    { 47, 2.0, 3, 21.0, null, "Biber", 15.0, null, 0.0, 0 },
                    { 48, 1.0, 3, 20.0, null, "Beyaz peynir", 260.0, null, 17.0, 0 },
                    { 49, 1.0, 3, 21.0, null, "Tulum peyniri", 280.0, null, 19.0, 0 },
                    { 50, 1.0, 3, 27.0, null, "Dil peyniri", 350.0, null, 23.0, 0 },
                    { 51, 2.0, 3, 26.0, null, "Örgü peyniri", 330.0, null, 22.0, 0 },
                    { 52, 3.0, 3, 29.0, null, "Eski kaşar", 380.0, null, 26.0, 0 },
                    { 53, 4.0, 3, 24.0, null, "Ezine peyniri", 310.0, null, 21.0, 0 },
                    { 54, 5.0, 3, 20.0, null, "Zeytin ezmesi", 204.0, null, 1.0, 0 },
                    { 55, 5.0, 3, 20.0, null, "Yeşil zeytin", 135.0, null, 1.0, 0 },
                    { 56, 6.0, 3, 11.0, null, "Siyah zeytin", 120.0, null, 1.0, 0 },
                    { 57, 0.0, 4, 11.0, null, "Izgara tavuk", 200.0, null, 25.0, 0 },
                    { 58, 4.0, 4, 10.0, null, "Tavuk şinitzel", 220.0, null, 26.0, 0 },
                    { 59, 0.0, 4, 15.0, null, "Izgara dana eti", 250.0, null, 30.0, 0 },
                    { 60, 1.0, 4, 17.0, null, "Et köfte", 280.0, null, 22.0, 0 },
                    { 61, 0.0, 4, 15.0, null, "Etli sulu yemek", 250.0, null, 30.0, 0 },
                    { 62, 22.0, 4, 11.0, null, "Et döner", 239.0, null, 12.0, 0 },
                    { 63, 3.0, 4, 20.0, null, "Tavuk döner", 300.0, null, 25.0, 0 },
                    { 64, 0.0, 4, 15.0, null, "Somon balığı", 220.0, null, 25.0, 0 },
                    { 65, 0.0, 4, 3.0, null, "Ton balığı", 150.0, null, 30.0, 0 },
                    { 66, 0.0, 4, 10.0, null, "Çipura balığı", 170.0, null, 20.0, 0 },
                    { 67, 0.0, 4, 8.0, null, "Hamsi", 160.0, null, 20.0, 0 },
                    { 68, 5.0, 4, 14.0, null, "Hindi şinitzel", 240.0, null, 23.0, 0 },
                    { 69, 0.0, 4, 15.0, null, "Biftek", 280.0, null, 35.0, 0 },
                    { 70, 1.0, 4, 17.0, null, "Dana kıyma", 250.0, null, 25.0, 0 },
                    { 71, 20.0, 4, 10.0, null, "Etli Çiğ Köfte", 200.0, null, 15.0, 0 },
                    { 72, 0.0, 4, 5.0, null, "Alabalık", 120.0, null, 20.0, 0 },
                    { 73, 0.0, 4, 7.0, null, "Sardalya", 160.0, null, 25.0, 0 },
                    { 74, 0.0, 4, 9.0, null, "Levrek", 180.0, null, 23.0, 0 },
                    { 75, 0.0, 4, 6.0, null, "Palamut", 140.0, null, 18.0, 0 },
                    { 76, 0.0, 4, 10.0, null, "Kılıç Balığı", 200.0, null, 28.0, 0 },
                    { 77, 0.0, 4, 8.0, null, "Mezgit", 170.0, null, 24.0, 0 },
                    { 78, 0.0, 4, 7.0, null, "Uskumru", 160.0, null, 22.0, 0 },
                    { 79, 0.0, 4, 9.0, null, "Kalkan", 190.0, null, 25.0, 0 },
                    { 80, 0.0, 4, 15.0, null, "Havyar", 250.0, null, 30.0, 0 },
                    { 81, 10.0, 4, 12.0, null, "Kalamar", 200.0, null, 15.0, 0 },
                    { 82, 0.0, 4, 1.0, null, "Karides", 90.0, null, 20.0, 0 },
                    { 83, 0.0, 4, 5.0, null, "Yengeç", 100.0, null, 15.0, 0 },
                    { 84, 5.0, 4, 8.0, null, "Ahtapot", 120.0, null, 20.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Karbonhidrat", "CategoryId", "Yağ", "FoodDetailID", "Yemek İsmi", "Kalori", "Resim", "Protein", "State" },
                values: new object[,]
                {
                    { 85, 0.0, 4, 5.0, null, "Kefal", 110.0, null, 15.0, 0 },
                    { 86, 0.0, 4, 3.0, null, "Tavuk Göğsü", 150.0, null, 30.0, 0 },
                    { 87, 0.0, 4, 20.0, null, "Kuzu Et", 280.0, null, 22.0, 0 },
                    { 88, 0.0, 4, 8.0, null, "Hindi Et", 180.0, null, 25.0, 0 },
                    { 89, 0.0, 4, 11.0, null, "Tavuk But", 180.0, null, 20.0, 0 },
                    { 90, 0.0, 4, 20.0, null, "Kuzu Kıyma", 280.0, null, 25.0, 0 },
                    { 91, 0.0, 4, 12.0, null, "Tavuk Kanat", 200.0, null, 25.0, 0 },
                    { 92, 0.0, 4, 18.0, null, "Sığır Antrikot", 290.0, null, 30.0, 0 },
                    { 93, 0.0, 4, 7.0, null, "Tavuk Ciğer", 150.0, null, 20.0, 0 },
                    { 94, 0.0, 4, 15.0, null, "Tavuk Pirzola", 230.0, null, 22.0, 0 },
                    { 95, 0.0, 4, 18.0, null, "Tavuk Köfte", 250.0, null, 22.0, 0 },
                    { 96, 0.0, 4, 15.0, null, "Kuzu Biftek", 220.0, null, 25.0, 0 },
                    { 97, 0.0, 4, 25.0, null, "Kuzu Pirzola", 280.0, null, 20.0, 0 },
                    { 98, 0.0, 4, 18.0, null, "Dana Antrikot", 260.0, null, 28.0, 0 },
                    { 99, 14.0, 5, 2.0, null, "Elma", 52.0, null, 3.0, 0 },
                    { 100, 8.0, 5, 2.0, null, "Portakal", 43.0, null, 0.0, 0 },
                    { 101, 3.0, 5, 1.0, null, "Salatalık", 15.0, null, 6.0, 0 },
                    { 102, 3.0, 5, 2.0, null, "Domates", 18.0, null, 9.0, 0 },
                    { 103, 10.0, 5, 2.0, null, "Havuç", 41.0, null, 9.0, 0 },
                    { 104, 17.0, 5, 1.0, null, "Patates", 77.0, null, 2.0, 0 },
                    { 105, 7.0, 5, 3.0, null, "Çilek", 32.0, null, 0.0, 0 },
                    { 106, 12.0, 5, 3.0, null, "Kiraz", 50.0, null, 1.0, 0 },
                    { 107, 7.0, 5, 2.0, null, "Karpuz", 30.0, null, 6.0, 0 },
                    { 108, 2.0, 5, 2.0, null, "Marul", 15.0, null, 1.0, 0 },
                    { 109, 6.0, 5, 1.0, null, "Kavun", 29.0, null, 8.0, 0 },
                    { 110, 8.0, 5, 2.0, null, "Enginar", 47.0, null, 3.0, 0 },
                    { 111, 3.0, 5, 4.0, null, "Ispanak", 23.0, null, 2.0, 0 },
                    { 112, 7.0, 5, 1.0, null, "Bamya", 31.0, null, 2.0, 0 },
                    { 113, 9.0, 5, 3.0, null, "Kereviz", 42.0, null, 1.0, 0 },
                    { 114, 4.0, 5, 2.0, null, "Dolmalık Biber", 20.0, null, 1.0, 0 },
                    { 115, 9.0, 5, 1.0, null, "Şeftali", 39.0, null, 1.0, 0 },
                    { 116, 9.0, 5, 1.0, null, "Erik", 39.0, null, 1.0, 0 },
                    { 117, 13.0, 5, 4.0, null, "Yeşil Elma", 52.0, null, 1.0, 0 },
                    { 118, 13.0, 5, 1.0, null, "Ananas", 50.0, null, 1.0, 0 },
                    { 119, 15.0, 5, 3.0, null, "Armut", 57.0, null, 1.0, 0 },
                    { 120, 13.0, 5, 3.0, null, "Mandalina", 53.0, null, 0.0, 0 },
                    { 121, 68.0, 5, 5.0, null, "Hurma Meyvesi", 277.0, null, 1.0, 0 },
                    { 122, 18.0, 5, 1.0, null, "Nar", 83.0, null, 1.0, 0 },
                    { 123, 17.0, 5, 2.0, null, "Siyah Üzüm", 69.0, null, 0.0, 0 },
                    { 124, 17.0, 5, 2.0, null, "Yeşil Üzüm", 70.0, null, 0.0, 0 },
                    { 125, 23.0, 5, 2.0, null, "Muz", 96.0, null, 1.0, 0 },
                    { 126, 14.0, 5, 5.0, null, "Kivi", 61.0, null, 1.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Karbonhidrat", "CategoryId", "Yağ", "FoodDetailID", "Yemek İsmi", "Kalori", "Resim", "Protein", "State" },
                values: new object[,]
                {
                    { 127, 9.0, 5, 4.0, null, "Böğürtlen", 43.0, null, 1.0, 0 },
                    { 128, 19.0, 5, 3.0, null, "İncir", 74.0, null, 1.0, 0 },
                    { 129, 8.0, 5, 2.0, null, "Greyfurt", 33.0, null, 1.0, 0 },
                    { 130, 9.0, 5, 3.0, null, "Limon", 29.0, null, 1.0, 0 },
                    { 131, 2.0, 6, 1.0, null, "Whey Protein Tozu", 120.0, null, 24.0, 0 },
                    { 132, 0.0, 6, 0.0, null, "Kreatin", 20.0, null, 0.0, 0 },
                    { 133, 0.0, 6, 0.0, null, "BCAA", 40.0, null, 9.0, 0 },
                    { 134, 0.0, 6, 0.0, null, "Glutamin", 20.0, null, 0.0, 0 },
                    { 135, 0.0, 6, 1.0, null, "Omega-3 Yağ Asitleri", 10.0, null, 0.0, 0 },
                    { 136, 5.0, 6, 0.0, null, "Multivitamin Tablet", 5.0, null, 0.0, 0 },
                    { 137, 2.0, 6, 0.0, null, "Kalsiyum + D3 Tablet", 10.0, null, 0.0, 0 },
                    { 138, 1.0, 6, 0.0, null, "Demir Tablet", 5.0, null, 0.0, 0 },
                    { 139, 0.0, 6, 0.0, null, "Magnezyum Tablet", 5.0, null, 0.0, 0 },
                    { 140, 2.0, 6, 0.0, null, "C Vitamini Tablet", 10.0, null, 0.0, 0 },
                    { 141, 10.0, 7, 8.0, null, "Ali nazik", 200.0, null, 25.0, 0 },
                    { 142, 20.0, 7, 25.0, null, "İmam bayıldı", 300.0, null, 5.0, 0 },
                    { 143, 10.0, 7, 15.0, null, "Adana kebabı", 280.0, null, 30.0, 0 },
                    { 144, 25.0, 7, 18.0, null, "İskender kebabı", 400.0, null, 40.0, 0 },
                    { 145, 8.0, 7, 12.0, null, "Çerkez kavuğu", 220.0, null, 20.0, 0 },
                    { 146, 30.0, 7, 12.0, null, "Lahmacun", 280.0, null, 15.0, 0 },
                    { 147, 30.0, 7, 15.0, null, "Pilav üstü döner", 350.0, null, 30.0, 0 },
                    { 148, 5.0, 7, 15.0, null, "Mantarlı tavuk", 180.0, null, 22.0, 0 },
                    { 149, 20.0, 7, 12.0, null, "Hünkar beğendi", 250.0, null, 15.0, 0 },
                    { 150, 45.0, 7, 6.0, null, "Mantı", 350.0, null, 25.0, 0 },
                    { 151, 0.0, 7, 3.0, null, "Fırında levrek", 120.0, null, 22.0, 0 },
                    { 152, 35.0, 7, 8.0, null, "Kuru fasulye pilav", 250.0, null, 10.0, 0 },
                    { 153, 4.0, 7, 6.0, null, "Sebzeli tavuk sote", 140.0, null, 18.0, 0 },
                    { 154, 15.0, 7, 2.0, null, "Mercimek çorbası", 120.0, null, 8.0, 0 },
                    { 155, 18.0, 7, 7.0, null, "Zeytinyağlı fasulye", 160.0, null, 7.0, 0 },
                    { 156, 2.0, 7, 16.0, null, "Tavuk şiş", 280.0, null, 32.0, 0 },
                    { 157, 30.0, 7, 1.0, null, "Sebzeli bulgur pilavı", 150.0, null, 4.0, 0 },
                    { 158, 15.0, 7, 3.0, null, "Ezogelin çorbası", 90.0, null, 6.0, 0 },
                    { 159, 12.0, 7, 2.0, null, "Tavuklu şehriye çorbası", 80.0, null, 7.0, 0 },
                    { 160, 8.0, 7, 1.0, null, "Domates çorbası", 60.0, null, 4.0, 0 },
                    { 161, 15.0, 7, 3.0, null, "Yoğurt çorbası", 100.0, null, 5.0, 0 },
                    { 162, 20.0, 7, 4.0, null, "Tarhana çorbası", 120.0, null, 5.0, 0 },
                    { 163, 12.0, 7, 2.0, null, "Şehriye çorbası", 90.0, null, 6.0, 0 },
                    { 164, 10.0, 7, 2.0, null, "Yayla çorbası çorbası", 80.0, null, 5.0, 0 },
                    { 165, 9.0, 7, 2.0, null, "Sebze çorbası", 70.0, null, 4.0, 0 },
                    { 166, 12.0, 7, 3.0, null, "Mantar çorbası", 100.0, null, 6.0, 0 },
                    { 167, 4.0, 8, 1.0, null, "Süt", 42.0, null, 3.0, 0 },
                    { 168, 4.0, 8, 2.0, null, "Yoğurt", 59.0, null, 3.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Karbonhidrat", "CategoryId", "Yağ", "FoodDetailID", "Yemek İsmi", "Kalori", "Resim", "Protein", "State" },
                values: new object[,]
                {
                    { 169, 1.0, 8, 22.0, null, "Peynir", 300.0, null, 25.0, 0 },
                    { 170, 0.0, 8, 100.0, null, "Fındık yağı", 884.0, null, 0.0, 0 },
                    { 171, 0.0, 8, 100.0, null, "Ayçiçek yağı", 884.0, null, 0.0, 0 },
                    { 172, 0.0, 8, 100.0, null, "Zeytin yağı", 884.0, null, 0.0, 0 },
                    { 173, 0.0, 8, 81.0, null, "Tereyağ", 717.0, null, 1.0, 0 },
                    { 174, 76.0, 8, 1.0, null, "Un", 364.0, null, 10.0, 0 },
                    { 175, 28.0, 8, 0.0, null, "Pirinç", 130.0, null, 2.0, 0 },
                    { 176, 70.0, 8, 1.0, null, "Bulgur", 342.0, null, 12.0, 0 },
                    { 177, 30.0, 8, 1.0, null, "Makarna", 158.0, null, 5.0, 0 },
                    { 178, 50.0, 9, 3.0, null, "Beyaz ekmek", 266.0, null, 8.0, 0 },
                    { 179, 44.0, 9, 1.0, null, "Kepekli ekmek", 216.0, null, 6.0, 0 },
                    { 180, 43.0, 9, 1.0, null, "Çavdar ekmeği", 259.0, null, 7.0, 0 },
                    { 181, 42.0, 9, 1.0, null, "Tam buğday ekmeği", 247.0, null, 12.0, 0 },
                    { 182, 43.0, 9, 1.0, null, "Çörek", 259.0, null, 7.0, 0 },
                    { 183, 23.0, 9, 17.0, null, "Sade poğaça", 300.0, null, 5.0, 0 },
                    { 184, 30.0, 9, 18.0, null, "Peynirli poğaça", 351.0, null, 10.0, 0 },
                    { 185, 23.0, 9, 17.0, null, "Zeytinli poğaça", 390.0, null, 5.0, 0 },
                    { 186, 28.0, 9, 21.0, null, "Patatesli poğaça", 328.0, null, 5.0, 0 },
                    { 187, 43.0, 9, 22.0, null, "Kruvasan", 406.0, null, 8.0, 0 },
                    { 188, 45.0, 9, 36.0, null, "Çikolatalı kruvasan", 530.0, null, 8.0, 0 },
                    { 189, 60.0, 9, 2.0, null, "Simit", 313.0, null, 10.0, 0 },
                    { 190, 70.0, 9, 55.0, null, "Tereyağlı Kurabiye", 488.0, null, 6.0, 0 },
                    { 191, 56.0, 9, 11.0, null, "Sade kek", 333.0, null, 6.0, 0 },
                    { 192, 40.0, 9, 16.0, null, "Çikolatalı kek", 340.0, null, 8.0, 0 },
                    { 193, 45.0, 9, 18.0, null, "Çikolatalı pasta", 350.0, null, 5.0, 0 },
                    { 194, 30.0, 9, 20.0, null, "Cheesecake", 320.0, null, 6.0, 0 },
                    { 195, 55.0, 9, 18.0, null, "Mozaik pasta", 400.0, null, 4.0, 0 },
                    { 196, 40.0, 9, 12.0, null, "Meyveli pasta", 280.0, null, 3.0, 0 },
                    { 197, 40.0, 9, 15.0, null, "Havuçlu kek", 320.0, null, 4.0, 0 },
                    { 198, 35.0, 9, 16.0, null, "Çilekli pasta", 290.0, null, 3.0, 0 },
                    { 199, 29.0, 9, 17.0, null, "Sade börek", 313.0, null, 13.0, 0 },
                    { 200, 50.0, 9, 13.0, null, "Peynirli börek", 389.0, null, 15.0, 0 },
                    { 201, 40.0, 9, 12.0, null, "Patatesli börek", 272.0, null, 6.0, 0 },
                    { 202, 28.0, 9, 4.0, null, "Ispanaklı börek", 200.0, null, 5.0, 0 },
                    { 203, 50.0, 9, 13.0, null, "Kıymalı börek", 389.0, null, 15.0, 0 },
                    { 204, 30.0, 9, 14.0, null, "Kaşarlı pide", 320.0, null, 16.0, 0 },
                    { 205, 35.0, 9, 15.0, null, "Kıymalı pide", 350.0, null, 18.0, 0 },
                    { 206, 35.0, 9, 15.0, null, "Kuşbaşılı pide", 350.0, null, 18.0, 0 },
                    { 207, 25.0, 9, 14.0, null, "Peynirli pide", 290.0, null, 12.0, 0 },
                    { 208, 30.0, 9, 11.0, null, "Ispanaklı pide", 260.0, null, 10.0, 0 },
                    { 209, 40.0, 9, 16.0, null, "Karışık pide", 380.0, null, 20.0, 0 },
                    { 210, 30.0, 9, 18.0, null, "Pastırmalı pide", 340.0, null, 15.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Karbonhidrat", "CategoryId", "Yağ", "FoodDetailID", "Yemek İsmi", "Kalori", "Resim", "Protein", "State" },
                values: new object[,]
                {
                    { 211, 0.0, 10, 0.0, null, "Su", 0.0, null, 0.0, 0 },
                    { 212, 0.0, 10, 0.0, null, "Soda", 0.0, null, 0.0, 0 },
                    { 213, 10.0, 10, 0.0, null, "Kola", 42.0, null, 0.0, 0 },
                    { 214, 11.0, 10, 0.0, null, "Portakal suyu", 46.0, null, 1.0, 0 },
                    { 215, 2.0, 10, 2.0, null, "Ayran", 40.0, null, 1.0, 0 },
                    { 216, 11.0, 10, 0.0, null, "Limonata", 43.0, null, 0.0, 0 },
                    { 217, 0.0, 10, 0.0, null, "Çay", 1.0, null, 0.0, 0 },
                    { 218, 0.0, 10, 0.0, null, "Filtre kahve", 1.0, null, 0.0, 0 },
                    { 219, 0.0, 10, 0.0, null, "Türk kahvesi", 1.0, null, 0.0, 0 },
                    { 220, 10.0, 10, 0.0, null, "Gazoz", 42.0, null, 0.0, 0 },
                    { 221, 11.0, 10, 0.0, null, "Elma suyu", 47.0, null, 0.0, 0 },
                    { 222, 13.0, 10, 0.0, null, "Şeftali suyu", 56.0, null, 1.0, 0 },
                    { 223, 9.0, 10, 0.0, null, "Greyfurt suyu", 39.0, null, 0.0, 0 },
                    { 224, 0.0, 10, 0.0, null, "Ihlamur", 0.0, null, 0.0, 0 },
                    { 225, 11.0, 10, 0.0, null, "Naneli limonata", 43.0, null, 0.0, 0 },
                    { 226, 0.0, 10, 0.0, null, "Adaçayı", 0.0, null, 0.0, 0 },
                    { 227, 0.0, 10, 0.0, null, "Papatya çayı", 0.0, null, 0.0, 0 },
                    { 228, 0.0, 10, 0.0, null, "Yeşil çay", 0.0, null, 0.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Aktiflik Düzeyi", "Yaş", "Cinsiyet", "Kalça Çevresi", "Boy", "Boyun Çevresi", "İsim", "State", "TotalCalorie", "UserId", "Bel Çevresi", "Kilo" },
                values: new object[,]
                {
                    { 1, "çok", 27, "Erkek", 100, 175, 30, "Mustafa", "Created", 1693, 1, 75, 68 },
                    { 2, "Az", 24, "Kadın", 91, 162, 25, "Dilara", "Created", 1608, 2, 62, 50 },
                    { 3, "Orta", 55, "Erkek", 105, 177, 32, "Roni Aluf", "Created", 2158, 3, 82, 70 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Kategori Adı",
                table: "Categories",
                column: "Kategori Adı",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodDetailID",
                table: "Foods",
                column: "FoodDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Yemek İsmi",
                table: "Foods",
                column: "Yemek İsmi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodUserFoodInfo_UserFoodInfosId",
                table: "FoodUserFoodInfo",
                column: "UserFoodInfosId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_UserId",
                table: "UserInfos",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Güvenlik Kodu",
                table: "Users",
                column: "Güvenlik Kodu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Kullanıcı Adı",
                table: "Users",
                column: "Kullanıcı Adı",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserUserFoodInfo_UsersId",
                table: "UserUserFoodInfo",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "FoodUserFoodInfo");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "UserUserFoodInfo");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "UserFoodInfos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Meals");
        }
    }
}
