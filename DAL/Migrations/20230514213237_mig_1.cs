using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Height = table.Column<double>(type: "float(3)", precision: 3, scale: 2, nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    Activity = table.Column<int>(type: "int", nullable: true),
                    BasalMetabolicRate = table.Column<double>(type: "float(4)", precision: 4, scale: 1, nullable: true),
                    GoalWeight = table.Column<double>(type: "float", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calorie = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods_Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<byte>(type: "tinyint", nullable: false),
                    Meal = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Foods_Users_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Users_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Meyveler" },
                    { 2, "Sebzeler" },
                    { 3, "Süt Ve Süt Ürünleri" },
                    { 4, "Et ve Et Ürünleri" },
                    { 5, "Tatlılar" },
                    { 6, "Tahıllar" },
                    { 7, "Çerezler" },
                    { 8, "İçecekler" },
                    { 9, "Unlu Mamuller" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Activity", "BasalMetabolicRate", "BirthDate", "DateOfRegistration", "FirstName", "Gender", "GoalWeight", "Height", "ImagePath", "Password", "UserName", "Weight" },
                values: new object[,]
                {
                    { 1, 3, null, new DateTime(1998, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3984), "İrem", 1, 48.0, 1.6000000000000001, null, "123", "iremilgin@gmail.com", 50.0 },
                    { 2, 1, null, new DateTime(1998, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(4040), "İlbey", 2, 80.0, 1.8, null, "1234", "ilbeyikiz@gmail.com", 86.0 },
                    { 3, 1, null, new DateTime(1992, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(4046), "Yunus", 2, 75.0, 1.77, null, "1206", "yunuskilic@gmail.com", 78.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calorie", "CategoryID", "FoodName", "ImagePath" },
                values: new object[,]
                {
                    { 1, 100m, 3, "Sut", "sut.jpg" },
                    { 2, 70m, 1, "Elma", "elma.jpg" },
                    { 3, 80m, 4, "Hamsi", "hamsi.jpg" },
                    { 4, 150m, 7, "Fındık", "findik.jpg" },
                    { 5, 95m, 3, "Yogurt", "yogurt.jpg" },
                    { 6, 275m, 3, "Beyaz Peynir", "beyazpeynir.jpg" },
                    { 7, 160m, 3, "Yumurta", "yumurta.jpg" },
                    { 8, 26m, 1, "Çilek", "cilek.jpg" },
                    { 9, 275m, 1, "Kayısı", "kayisi.jpg" },
                    { 10, 52m, 1, "Armut", "armut.jpg" },
                    { 11, 40m, 1, "Kiraz", "kiraz.jpg" },
                    { 12, 41m, 1, "İncir", "incir.jpg" },
                    { 13, 42.1m, 1, "Greyfurt", "greyfurt.jpg" },
                    { 14, 63m, 1, "Kivi", "kivi.jpg" },
                    { 15, 313m, 5, "Muhallebi", "muhallebi.jpg" },
                    { 16, 267m, 5, "Sütlaç", "sutlac.jpg" },
                    { 17, 501m, 5, "Revani", "revani.jpg" },
                    { 18, 291m, 5, "Profiterol", "profiterol.jpg" },
                    { 19, 371m, 5, "Muzlu Puding", "muzlupuding.jpg" },
                    { 20, 600m, 7, "Badem", "badem.jpg" },
                    { 21, 560m, 7, "Fıstık", "fistik.jpg" },
                    { 22, 578m, 7, "AyÇekirdeği", "aycekirdegi.jpg" },
                    { 23, 245m, 7, "Kestane", "kestane.jpg" },
                    { 24, 549m, 7, "Ceviz", "ceviz.jpg" },
                    { 25, 478m, 7, "Patlamış Mısır", "patlamismisir.jpg" },
                    { 26, 47m, 8, "Elma Suyu", "elmasuyu.jpg" },
                    { 27, 59m, 8, "Kola", "kola.jpg" },
                    { 28, 3m, 8, "Şekersiz Çay", "sekersizcay.jpg" },
                    { 29, 9m, 8, "Şekersiz Kahve", "sekersizkahve.jpg" },
                    { 30, 45m, 8, "Portakal Suyu", "portakalsuyu.jpg" },
                    { 31, 30m, 8, "Soğuk Çay", "sogukcay.jpg" },
                    { 32, 46m, 8, "Meyveli Soda", "meyvelisoda.jpg" },
                    { 33, 48m, 8, "Fanta", "fanta.jpg" },
                    { 34, 270m, 8, "Beyaz Ekmek", "beyazekmek.jpg" },
                    { 35, 180m, 6, "Kepek Ekmek", "kepekekmegi.jpg" },
                    { 36, 470m, 6, "Bisküvi", "bisküvi.jpg" },
                    { 37, 85m, 6, "Haşlanmış Makarna", "haslanmismakarna.jpg" },
                    { 38, 314m, 6, "Mercimek(Kuru)", "mercimekkoftesi.jpg" },
                    { 39, 257m, 9, "Bazlama", "bazlama.jpg" },
                    { 40, 200m, 9, "Mısır Ekmeği", null },
                    { 41, 280m, 9, "Börek", null },
                    { 42, 480m, 9, "Pide", null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calorie", "CategoryID", "FoodName", "ImagePath" },
                values: new object[,]
                {
                    { 43, 224m, 9, "Krep", null },
                    { 44, 462m, 9, "Kruvasan", null },
                    { 45, 230m, 9, "Su Böreği", null },
                    { 46, 132m, 4, "Tavuk Izgara", null },
                    { 47, 446m, 4, "Salam", null },
                    { 48, 250m, 4, "Pastırma", null },
                    { 49, 452m, 4, "Sucuk", null },
                    { 50, 180m, 4, "Jambon", null },
                    { 51, 90m, 2, "Taze Fasulye", null },
                    { 52, 40m, 2, "Brokoli", null },
                    { 53, 25m, 2, "Kabak", null },
                    { 54, 89m, 2, "Bezelye", null },
                    { 55, 26m, 2, "Ispanak", null },
                    { 56, 96m, 2, "Taze Mısır", null },
                    { 57, 36m, 2, "Bamya", null },
                    { 58, 14m, 2, "Mantar", null },
                    { 59, 15m, 2, "Marul", null },
                    { 60, 70m, 3, "Mozarella", null },
                    { 61, 257m, 3, "Tulum Peyniri", null },
                    { 62, 108m, 3, "Koyun Sütü", null },
                    { 63, 349m, 3, "Krem Peyniri", null },
                    { 64, 440m, 3, "Parmesan Peyniri", null },
                    { 65, 108m, 3, "Koyun Sütü", null },
                    { 66, 90m, 3, "Lor Peyniri", null },
                    { 67, 125m, 3, "Meyveli Yoğurt", null },
                    { 68, 55m, 3, "Kefir", null },
                    { 69, 117m, 3, "Cacık", null },
                    { 70, 50m, 1, "Ananas", null },
                    { 71, 57m, 1, "Ayva", null },
                    { 72, 43m, 1, "Böğürtlen", null },
                    { 73, 42m, 3, "Lİmonata", null },
                    { 74, 42m, 3, "Gazoz", null },
                    { 75, 148m, 3, "Boza", null },
                    { 76, 349m, 3, "Milkshake", null },
                    { 77, 1m, 3, "Diyet Kola", null },
                    { 78, 488m, 5, "Kurabiye", null },
                    { 79, 164m, 5, "Kabak Tatlısı", null },
                    { 80, 411m, 5, "Badem Ezmesi", null },
                    { 81, 30m, 1, "Karpuz", null },
                    { 82, 83m, 1, "Nar", null },
                    { 83, 34m, 1, "Kavun", null },
                    { 84, 43m, 2, "Kırmızı Pancar", null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calorie", "CategoryID", "FoodName", "ImagePath" },
                values: new object[,]
                {
                    { 85, 25m, 2, "Patlıcan", null },
                    { 86, 115m, 2, "Siyah Zeytin", null },
                    { 87, 25m, 2, "Roka", null },
                    { 88, 31m, 5, "Rezene", null },
                    { 89, 195m, 3, "Kahve Kreması", null },
                    { 90, 121m, 4, "Antrikot", null },
                    { 91, 189m, 4, "Hindi", null },
                    { 92, 266m, 4, "Tavuk Kanadı", null },
                    { 93, 246m, 6, "Yulaf Kepeği", null },
                    { 94, 281m, 6, "Çavdar Tohumu", null },
                    { 95, 366m, 6, "Mısır İrmiği", null },
                    { 96, 553m, 7, "Kaju", null },
                    { 97, 267m, 7, "Leblebi", null },
                    { 98, 57m, 8, " Latte ", null },
                    { 99, 37m, 8, "Smoothie", null },
                    { 100, 89m, 8, "Sıcak Çİkolata", null }
                });

            migrationBuilder.InsertData(
                table: "Foods_Users",
                columns: new[] { "ID", "Day", "FoodID", "Meal", "Number", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3141), 1, 1, (byte)2, 1 },
                    { 2, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3143), 2, 1, (byte)2, 1 },
                    { 3, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3144), 3, 1, (byte)3, 2 },
                    { 4, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3145), 4, 1, (byte)3, 2 },
                    { 5, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3146), 7, 1, (byte)1, 1 },
                    { 6, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3147), 35, 1, (byte)1, 1 },
                    { 7, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3148), 47, 1, (byte)1, 1 },
                    { 8, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3149), 86, 1, (byte)1, 1 },
                    { 9, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3150), 86, 2, (byte)1, 1 },
                    { 10, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3151), 33, 2, (byte)1, 1 },
                    { 11, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3152), 46, 2, (byte)1, 1 },
                    { 12, new DateTime(2023, 5, 15, 0, 32, 37, 519, DateTimeKind.Local).AddTicks(3153), 51, 2, (byte)1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Users_FoodID",
                table: "Foods_Users",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Users_UserID",
                table: "Foods_Users",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods_Users");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
