using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class Food_UserCFG : IEntityTypeConfiguration<Food_User>
    {
        public void Configure(EntityTypeBuilder<Food_User> builder)
        {

            builder.HasData(
                new Food_User
                {
                    ID = 1,
                    FoodID = 1,
                    UserID = 1,
                    Day = DateTime.Now,
                    Number = 2,
                    Meal = Entities.Enums.Meal.Breakfast
                },
                
                new Food_User 
                { 
                    ID = 2, 
                    FoodID = 2, 
                    UserID = 1, 
                    Day = DateTime.Now, 
                    Number = 2, 
                    Meal = Entities.Enums.Meal.Breakfast
                     },

                new Food_User
                {
                    ID = 3,
                    FoodID = 3,
                    UserID = 2,
                    Day = DateTime.Now,
                    Number = 3,
                    Meal = Entities.Enums.Meal.Breakfast
                },
                new Food_User
                {
                    ID = 4,
                    FoodID = 4,
                    UserID = 2,
                    Day = DateTime.Now,
                    Number = 3,
                    Meal = Entities.Enums.Meal.Breakfast
                },
                 new Food_User
                 {
                     ID = 5,
                     FoodID = 7,
                     UserID = 1,
                     Day = DateTime.Now,
                     Number = 1,
                     Meal = Entities.Enums.Meal.Breakfast
                 },
                 new Food_User
                 {
                     ID = 6,
                     FoodID = 35,
                     UserID = 1,
                     Day = DateTime.Now,
                     Number = 1,
                     Meal = Entities.Enums.Meal.Breakfast
                 },
                  new Food_User
                  {
                      ID = 7,
                      FoodID = 47,
                      UserID = 1,
                      Day = DateTime.Now,
                      Number = 1,
                      Meal = Entities.Enums.Meal.Breakfast
                  },
                  new Food_User
                  {
                      ID = 8,
                      FoodID = 86,
                      UserID = 1,
                      Day = DateTime.Now,
                      Number = 1,
                      Meal = Entities.Enums.Meal.Breakfast
                  },
                   new Food_User
                   {
                       ID = 9,
                       FoodID = 86,
                       UserID = 1,
                       Day = DateTime.Now,
                       Number = 1,
                       Meal =Entities.Enums.Meal.Lunch
                   },
                   new Food_User
                   {


                       ID = 10,
                       FoodID = 33,
                       UserID = 1,
                       Day = DateTime.Now,
                       Number = 1,
                       Meal =Entities.Enums.Meal.Lunch


                   },
                   new Food_User
                   {


                       ID = 11,
                       FoodID = 46,
                       UserID = 1,
                       Day = DateTime.Now,
                       Number = 1,
                       Meal =Entities.Enums.Meal.Lunch


                   },
                    new Food_User
                    {


                        ID = 12,
                        FoodID = 51,
                        UserID = 1,
                        Day = DateTime.Now,
                        Number = 1,
                        Meal =Entities.Enums.Meal.Lunch


                    }




                    );
        }
    }
}
