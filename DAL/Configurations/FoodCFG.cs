using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class FoodCFG : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(

                new Food { FoodID = 1, FoodName = "Sut", Calorie = 100, CategoryID = 3, ImagePath = "sut.jpg" },

                new Food { FoodID = 2, FoodName = "Elma", Calorie = 70, CategoryID = 1, ImagePath = "elma.jpg" },

                new Food { FoodID = 3, FoodName = "Hamsi", Calorie = 80, CategoryID = 4, ImagePath = "hamsi.jpg" },

                new Food { FoodID = 4, FoodName = "Fındık", Calorie = 150, CategoryID = 7, ImagePath = "findik.jpg" },
                 new Food { FoodID = 5, FoodName = "Yogurt", Calorie = 95, CategoryID = 3, ImagePath = "yogurt.jpg" },

                 new Food { FoodID = 6, FoodName = "Beyaz Peynir", Calorie = 275, CategoryID = 3, ImagePath = "beyazpeynir.jpg" },

                 new Food { FoodID = 7, FoodName = "Yumurta", Calorie = 160, CategoryID = 3, ImagePath = "yumurta.jpg" },

                 new Food { FoodID = 8, FoodName = "Çilek", Calorie = 26, CategoryID = 1, ImagePath = "cilek.jpg" },

                 new Food { FoodID = 9, FoodName = "Kayısı", Calorie = 275, CategoryID = 1, ImagePath = "kayisi.jpg" },

                 new Food { FoodID = 10, FoodName = "Armut", Calorie = 52, CategoryID = 1, ImagePath = "armut.jpg" },

                 new Food { FoodID = 11, FoodName = "Kiraz", Calorie = 40, CategoryID = 1, ImagePath = "kiraz.jpg" },

                 new Food { FoodID = 12, FoodName = "İncir", Calorie = 41, CategoryID = 1, ImagePath = "incir.jpg" },

                 new Food { FoodID = 13, FoodName = "Greyfurt", Calorie = Convert.ToDecimal(42.1), CategoryID = 1, ImagePath = "greyfurt.jpg" },

                 new Food { FoodID = 14, FoodName = "Kivi", Calorie = 63, CategoryID = 1, ImagePath = "kivi.jpg" },

                 new Food { FoodID = 15, FoodName = "Muhallebi", Calorie = 313, CategoryID = 5, ImagePath = "muhallebi.jpg" },

                 new Food { FoodID = 16, FoodName = "Sütlaç", Calorie = 267, CategoryID = 5, ImagePath = "sutlac.jpg" },

                 new Food { FoodID = 17, FoodName = "Revani", Calorie = 501, CategoryID = 5, ImagePath = "revani.jpg" },

                 new Food { FoodID = 18, FoodName = "Profiterol", Calorie = 291, CategoryID = 5, ImagePath = "profiterol.jpg" },

                 new Food { FoodID = 19, FoodName = "Muzlu Puding", Calorie = 371, CategoryID = 5, ImagePath = "muzlupuding.jpg" },

                 new Food { FoodID = 20, FoodName = "Badem", Calorie = 600, CategoryID = 7, ImagePath = "badem.jpg" },

                 new Food { FoodID = 21, FoodName = "Fıstık", Calorie = 560, CategoryID = 7, ImagePath = "fistik.jpg" },

                 new Food { FoodID = 22, FoodName = "AyÇekirdeği", Calorie = 578, CategoryID = 7, ImagePath = "aycekirdegi.jpg" },

                 new Food { FoodID = 23, FoodName = "Kestane", Calorie = 245, CategoryID = 7, ImagePath = "kestane.jpg" },

                  new Food { FoodID = 24, FoodName = "Ceviz", Calorie = 549, CategoryID = 7, ImagePath = "ceviz.jpg" },

                  new Food { FoodID = 25, FoodName = "Patlamış Mısır", Calorie = 478, CategoryID = 7, ImagePath = "patlamismisir.jpg" },

                  new Food { FoodID = 26, FoodName = "Elma Suyu", Calorie = 47, CategoryID = 8, ImagePath = "elmasuyu.jpg" },

                  new Food { FoodID = 27, FoodName = "Kola", Calorie = 59, CategoryID = 8, ImagePath = "kola.jpg" },

                  new Food { FoodID = 28, FoodName = "Şekersiz Çay", Calorie = 3, CategoryID = 8, ImagePath = "sekersizcay.jpg" },

                  new Food { FoodID = 29, FoodName = "Şekersiz Kahve", Calorie = 9, CategoryID = 8, ImagePath = "sekersizkahve.jpg" },

                   new Food { FoodID = 30, FoodName = "Portakal Suyu", Calorie = 45, CategoryID = 8, ImagePath = "portakalsuyu.jpg" },

                   new Food { FoodID = 31, FoodName = "Soğuk Çay", Calorie = 30, CategoryID = 8, ImagePath = "sogukcay.jpg" },

                   new Food { FoodID = 32, FoodName = "Meyveli Soda", Calorie = 46, CategoryID = 8, ImagePath = "meyvelisoda.jpg" },

                    new Food { FoodID = 33, FoodName = "Fanta", Calorie = 48, CategoryID = 8, ImagePath = "fanta.jpg" },

                  new Food { FoodID = 34, FoodName = "Beyaz Ekmek", Calorie = 270, CategoryID = 8, ImagePath = "beyazekmek.jpg" },

                  new Food { FoodID = 35, FoodName = "Kepek Ekmek", Calorie = 180, CategoryID = 6, ImagePath = "kepekekmegi.jpg" },

                  new Food { FoodID = 36, FoodName = "Bisküvi", Calorie = 470, CategoryID = 6, ImagePath = "bisküvi.jpg" },

                   new Food { FoodID = 37, FoodName = "Haşlanmış Makarna", Calorie = 85, CategoryID = 6, ImagePath = "haslanmismakarna.jpg" },

                   new Food { FoodID = 38, FoodName = "Mercimek(Kuru)", Calorie = 314, CategoryID = 6, ImagePath = "mercimekkoftesi.jpg" },

                   new Food { FoodID = 39, FoodName = "Bazlama", Calorie = 257, CategoryID = 9, ImagePath = "bazlama.jpg" },

                   new Food { FoodID = 40, FoodName = "Mısır Ekmeği", Calorie = 200, CategoryID = 9 },

                   new Food { FoodID = 41, FoodName = "Börek", Calorie = 280, CategoryID = 9 },

                    new Food { FoodID = 42, FoodName = "Pide", Calorie = 480, CategoryID = 9 },

                     new Food { FoodID = 43, FoodName = "Krep", Calorie = 224, CategoryID = 9 },

                    new Food { FoodID = 44, FoodName = "Kruvasan", Calorie = 462, CategoryID = 9 },

                     new Food { FoodID = 45, FoodName = "Su Böreği", Calorie = 230, CategoryID = 9 },

                     new Food { FoodID = 46, FoodName = "Tavuk Izgara", Calorie = 132, CategoryID = 4 },

                     new Food { FoodID = 47, FoodName = "Salam", Calorie = 446, CategoryID = 4 },

                     new Food { FoodID = 48, FoodName = "Pastırma", Calorie = 250, CategoryID = 4 },

                     new Food { FoodID = 49, FoodName = "Sucuk", Calorie = 452, CategoryID = 4 },
                     new Food { FoodID = 50, FoodName = "Jambon", Calorie = 180, CategoryID = 4 },

                      new Food { FoodID = 51, FoodName = "Taze Fasulye", Calorie = 90, CategoryID = 2 },

                      new Food { FoodID = 52, FoodName = "Brokoli", Calorie = 40, CategoryID = 2 },

                       new Food { FoodID = 53, FoodName = "Kabak", Calorie = 25, CategoryID = 2 },

                        new Food { FoodID = 54, FoodName = "Bezelye", Calorie = 89, CategoryID = 2 },

                         new Food { FoodID = 55, FoodName = "Ispanak", Calorie = 26, CategoryID = 2 },

                        new Food { FoodID = 56, FoodName = "Taze Mısır", Calorie = 96, CategoryID = 2 },

                         new Food { FoodID = 57, FoodName = "Bamya", Calorie = 36, CategoryID = 2 },

                        new Food { FoodID = 58, FoodName = "Mantar", Calorie = 14, CategoryID = 2 },

                      new Food { FoodID = 59, FoodName = "Marul", Calorie = 15, CategoryID = 2 },

                     new Food { FoodID = 60, FoodName = "Mozarella", Calorie = 70, CategoryID = 3 },

                     new Food { FoodID = 61, FoodName = "Tulum Peyniri", Calorie = 257, CategoryID = 3 },

                     new Food { FoodID = 62, FoodName = "Koyun Sütü", Calorie = 108, CategoryID = 3 },

                    new Food { FoodID = 63, FoodName = "Krem Peyniri", Calorie = 349, CategoryID = 3 },

                    new Food { FoodID = 64, FoodName = "Parmesan Peyniri", Calorie = 440, CategoryID = 3 },
                    new Food { FoodID = 65, FoodName = "Koyun Sütü", Calorie = 108, CategoryID = 3 },
                    new Food { FoodID = 66, FoodName = "Lor Peyniri", Calorie = 90, CategoryID = 3 },
                    new Food { FoodID = 67, FoodName = "Meyveli Yoğurt", Calorie = 125, CategoryID = 3 },
                    new Food { FoodID = 68, FoodName = "Kefir", Calorie = 55, CategoryID = 3 },
                    new Food { FoodID = 69, FoodName = "Cacık", Calorie = 117, CategoryID = 3 },
                    new Food { FoodID = 70, FoodName = "Ananas", Calorie = 50, CategoryID = 1 },
                     new Food { FoodID = 71, FoodName = "Ayva", Calorie = 57, CategoryID = 1 },
                      new Food { FoodID = 72, FoodName = "Böğürtlen", Calorie = 43, CategoryID = 1 },
                      new Food { FoodID = 73, FoodName = "Lİmonata", Calorie = 42, CategoryID = 3 },
                       new Food { FoodID = 74, FoodName = "Gazoz", Calorie = 42, CategoryID = 3 },
                      new Food { FoodID = 75, FoodName = "Boza", Calorie = 148, CategoryID = 3 },
                       new Food { FoodID = 76, FoodName = "Milkshake", Calorie = 349, CategoryID = 3 },
                      new Food { FoodID = 77, FoodName = "Diyet Kola", Calorie = 1, CategoryID = 3 },
                      new Food { FoodID = 78, FoodName = "Kurabiye", Calorie = 488, CategoryID = 5 },
                      new Food { FoodID = 79, FoodName = "Kabak Tatlısı", Calorie = 164, CategoryID = 5 },
                      new Food { FoodID = 80, FoodName = "Badem Ezmesi", Calorie = 411, CategoryID = 5 },
                        new Food { FoodID = 81, FoodName = "Karpuz", Calorie = 30, CategoryID = 1 },
                         new Food { FoodID = 82, FoodName = "Nar", Calorie = 83, CategoryID = 1 },
                         new Food { FoodID = 83, FoodName = "Kavun", Calorie = 34, CategoryID = 1 },
                         new Food { FoodID = 84, FoodName = "Kırmızı Pancar", Calorie = 43, CategoryID = 2 },
                          new Food { FoodID = 85, FoodName = "Patlıcan", Calorie = 25, CategoryID = 2 },
                         new Food { FoodID = 86, FoodName = "Siyah Zeytin", Calorie = 115, CategoryID = 2 },
                       new Food { FoodID = 87, FoodName = "Roka", Calorie = 25, CategoryID = 2 },
                        new Food { FoodID = 88, FoodName = "Rezene", Calorie = 31, CategoryID = 5 },
                        new Food { FoodID = 89, FoodName = "Kahve Kreması", Calorie = 195, CategoryID = 3 },
                        new Food { FoodID = 90, FoodName = "Antrikot", Calorie = 121, CategoryID = 4 },
                         new Food { FoodID = 91, FoodName = "Hindi", Calorie = 189, CategoryID = 4 },
                         new Food { FoodID = 92, FoodName = "Tavuk Kanadı", Calorie = 266, CategoryID = 4 },
                         new Food { FoodID = 93, FoodName = "Yulaf Kepeği", Calorie = 246, CategoryID = 6 },
                        new Food { FoodID = 94, FoodName = "Çavdar Tohumu", Calorie = 281, CategoryID = 6 },
                        new Food { FoodID = 95, FoodName = "Mısır İrmiği", Calorie = 366, CategoryID = 6 },
                         new Food { FoodID = 96, FoodName = "Kaju", Calorie = 553, CategoryID = 7 },
                           new Food { FoodID = 97, FoodName = "Leblebi", Calorie = 267, CategoryID = 7 },
                             new Food { FoodID = 98, FoodName = " Latte ", Calorie = 57, CategoryID = 8 },
                               new Food { FoodID = 99, FoodName = "Smoothie", Calorie = 37, CategoryID = 8 },
                                 new Food { FoodID = 100, FoodName = "Sıcak Çİkolata", Calorie = 89, CategoryID = 8 }



























































                );
        }
    }
}
