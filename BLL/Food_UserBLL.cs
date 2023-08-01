using BLL.DtoClass;
using DAL.Context;
using Entities.Enums;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Project___Team2.DtoClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
    public class Food_UserBLL : ICRUD<Food_User>
    {
        CalorieTrackingAppDB _db;
        public Food_UserBLL()
        {
            _db = new CalorieTrackingAppDB();
        }

        public bool Add(Food_User entity)
        {
            _db.Foods_Users.Add(entity);
            return _db.SaveChanges() > 0;
        }

        public Food_User Find(int id)
        {
            return _db.Foods_Users.Find(id);
        }

        public List<Food_User> List()
        {
            return _db.Foods_Users.ToList();
        }

        public bool Remove(int id)
        {
            _db.Foods_Users.Remove(Find(id));
            return _db.SaveChanges() > 0;
        }

        public bool Update(Food_User entity)
        {
            _db.Foods_Users.Update(entity);
            return _db.SaveChanges() > 0;
        }

        public List<Food_User> GetFoodUsersSelectedDate(int id, DateTime selectedDate)
        {
            return _db.Foods_Users.Where(f => f.Day.Date == selectedDate.Date && f.UserID == id).Include(d => d.Food).ToList();
        }

        public List<Food_User> GetFoodUsersSelectedMeal(List<Food_User> foodsUsers, Meal meal)
        {
            return foodsUsers.Where(m => m.Meal == meal).ToList();
        }

        public List<Food_User> TotalCaloriesPerMeal(DateTime selectedDate, int id)
        {

            return _db.Foods_Users
            .Where(f => f.Day.Date == selectedDate.Date && f.UserID == id)
            .Include(d => d.Food)
            .GroupBy(a => a.Meal)
            .Select(g => new Food_User { Meal = g.Key, TotalCalorie = g.Sum(s => s.Food.Calorie * s.Number) }).ToList();
        }

        public Food_User? GetDailyTotalCalorie(DateTime day, int userID)
        {
            return _db.Foods_Users
           .Where(f => f.Day.Date == day.Date && f.UserID == userID)
           .Include(d => d.Food)
           .GroupBy(s => s.UserID)
           .Select( g => new Food_User { TotalCalorie = g.Sum(s => s.Food.Calorie * s.Number) }).FirstOrDefault();
    }

        public List<TotalCalorieByMealDTO> TotalCalorieByMealWeekly(int id )
        {
            return _db.Foods_Users.AsNoTracking()
             .Where(x => x.Day.Date > DateTime.Now.AddDays(-7) && x.UserID == id)
             .Include(x => x.Food)
             .Include(x => x.User)
             .GroupBy(x => new
             {
                 x.Meal,
                 x.UserID,
                 x.User.FirstName
             })
             .Select(g => new
             {
                 UserID = g.Key.UserID,
                 Meal = g.Key.Meal,
                 UserName = g.Key.FirstName,
                 TotalCalorie = g.Sum(s => s.Food.Calorie * s.Number)
             }).GroupBy(f => f.UserID)
                .Select(g => new TotalCalorieByMealDTO
                {
                    UserID = g.Key,
                    FirstName = g.FirstOrDefault(d => d.UserID == g.Key).UserName,
                    Breakfast = g.Where(f => f.Meal == Entities.Enums.Meal.Breakfast).Sum(f => f.TotalCalorie),
                    Lunch = g.Where(f => f.Meal == Entities.Enums.Meal.Lunch).Sum(f => f.TotalCalorie),
                    Dinner = g.Where(f => f.Meal == Entities.Enums.Meal.Dinner).Sum(f => f.TotalCalorie),
                    Other = g.Where(f => f.Meal == Entities.Enums.Meal.Others).Sum(f => f.TotalCalorie)
                })
                .ToList();
        }

        public List<TotalCaloriesByCategoryDTO> TotalCalorieByCategoryWeekly(int id )
        {
            return _db.Foods_Users.AsNoTracking()
               .Where(x => x.Day.Date > DateTime.Now.AddDays(-7) && x.UserID == id)
               .Include(x => x.Food)
               .Include(x => x.User)
               .GroupBy(x => new
               {
                   x.Food.Category.CategoryID,
                   x.UserID,
                   x.User.FirstName,
                   x.Food.Category.CategoryName
               })
                .Select(g => new
                {
                    CategoryID = g.Key.CategoryID,
                    UserID = g.Key.UserID,
                    FirstName = g.Key.FirstName,
                    CategoryName = g.Key.CategoryName,
                    TotalCalorie = g.Sum(s => s.Food.Calorie * s.Number)
                })
                .GroupBy(f => f.UserID)
                .Select(g => new TotalCaloriesByCategoryDTO
                {
                    UserID = g.Key,
                    FirstName = g.FirstOrDefault(d => d.UserID == g.Key).FirstName,
                    Meyveler = g.Where(f => f.CategoryID == 1).Sum(f => f.TotalCalorie),
                    Sebzeler = g.Where(f => f.CategoryID == 2).Sum(f => f.TotalCalorie),
                    SutUrunleri = g.Where(f => f.CategoryID == 3).Sum(f => f.TotalCalorie),
                    EtveEtÜrünleri = g.Where(f => f.CategoryID == 4).Sum(f => f.TotalCalorie),
                    Tatlilar = g.Where(f => f.CategoryID == 5).Sum(f => f.TotalCalorie),
                    Tahillar = g.Where(f => f.CategoryID == 6).Sum(f => f.TotalCalorie),
                    Cerezler = g.Where(f => f.CategoryID == 7).Sum(f => f.TotalCalorie),
                    Icecekler = g.Where(f => f.CategoryID == 8).Sum(f => f.TotalCalorie),
                    UnluMamuller = g.Where(f => f.CategoryID == 9).Sum(f => f.TotalCalorie),
                })
               .ToList();
        }

        public List<TotalCalorieByMealDTO> TotalCalorieByMealMonthly(int id)
        {
            return _db.Foods_Users.AsNoTracking()
             .Where(x => x.Day.Date > DateTime.Now.AddDays(-30) && x.UserID == id)
             .Include(x => x.Food)
             .Include(x => x.User)
             .GroupBy(x => new
             {
                 x.Meal,
                 x.UserID,
                 x.User.FirstName
             })
             .Select(g => new
             {
                 UserID = g.Key.UserID,
                 Meal = g.Key.Meal,
                 UserName = g.Key.FirstName,
                 TotalCalorie = g.Sum(s => s.Food.Calorie * s.Number)
             }).GroupBy(f => f.UserID)
                .Select(g => new TotalCalorieByMealDTO
                {
                    UserID = g.Key,
                    FirstName = g.FirstOrDefault(d => d.UserID == g.Key).UserName,
                    Breakfast = g.Where(f => f.Meal == Entities.Enums.Meal.Breakfast).Sum(f => f.TotalCalorie),
                    Lunch = g.Where(f => f.Meal == Entities.Enums.Meal.Lunch).Sum(f => f.TotalCalorie),
                    Dinner = g.Where(f => f.Meal == Entities.Enums.Meal.Dinner).Sum(f => f.TotalCalorie),
                    Other = g.Where(f => f.Meal == Entities.Enums.Meal.Others).Sum(f => f.TotalCalorie)
                })
                .ToList();

        }

        public List<TotalCaloriesByCategoryDTO> TotalCalorieByCategoryMonthly(int id)
        {
            return _db.Foods_Users.AsNoTracking()
                .Where(x => x.Day.Date > DateTime.Now.AddDays(-30) && x.UserID == id)
                .Include(x => x.Food)
                .Include(x => x.User)
                .GroupBy(x => new
                {
                    x.Food.Category.CategoryID,
                    x.UserID,
                    x.User.FirstName,
                    x.Food.Category.CategoryName
                })
                 .Select(g => new
                 {
                     CategoryID = g.Key.CategoryID,
                     UserID = g.Key.UserID,
                     FirstName = g.Key.FirstName,
                     CategoryName = g.Key.CategoryName,
                     TotalCalorie = g.Sum(s => s.Food.Calorie * s.Number)
                 })
                 .GroupBy(f => f.UserID)
                 .Select(g => new TotalCaloriesByCategoryDTO
                 {
                     UserID = g.Key,
                     FirstName = g.FirstOrDefault(d => d.UserID == g.Key).FirstName,
                     Meyveler = g.Where(f => f.CategoryID == 1).Sum(f => f.TotalCalorie),
                     Sebzeler = g.Where(f => f.CategoryID == 2).Sum(f => f.TotalCalorie),
                     SutUrunleri = g.Where(f => f.CategoryID == 3).Sum(f => f.TotalCalorie),
                     EtveEtÜrünleri = g.Where(f => f.CategoryID == 4).Sum(f => f.TotalCalorie),
                     Tatlilar = g.Where(f => f.CategoryID == 5).Sum(f => f.TotalCalorie),
                     Tahillar = g.Where(f => f.CategoryID == 6).Sum(f => f.TotalCalorie),
                     Cerezler = g.Where(f => f.CategoryID == 7).Sum(f => f.TotalCalorie),
                     Icecekler = g.Where(f => f.CategoryID == 8).Sum(f => f.TotalCalorie),
                     UnluMamuller = g.Where(f => f.CategoryID == 9).Sum(f => f.TotalCalorie),
                 }).ToList();
        }

        public Food? GetMostConsumedFood()
        {
            return _db.Foods_Users
                    .Include(x => x.Food)
                    .GroupBy(fu => new { fu.FoodID, fu.Food.FoodName })
                    .Select(g => new Food
                    {
                        FoodID = g.Key.FoodID,
                        FoodName = g.Key.FoodName,
                        TotalConsumption = g.Sum(fu => fu.Number)
                    })
                    .OrderByDescending(fu => fu.TotalConsumption).FirstOrDefault();

        }

        public List<Food_User> GenerateMealConsumptionReport()
        {
                return _db.Foods_Users
                    .Include(x => x.Food)
                    .GroupBy(fu => new { fu.FoodID, fu.Meal, fu.Food.FoodName})
                    .Select(g => new Food_User
                    {
                        FoodID = g.Key.FoodID,
                        Name = g.Key.FoodName,
                        Meal = g.Key.Meal,
                        TotalConsumption = g.Sum(fu => fu.Number)
                    })
                    .GroupBy(g => g.Meal)
                    .Select(g => new Food_User
                    {
                        Meal = g.Key,
                        TotalConsumption = g.OrderByDescending(x => x.TotalConsumption).FirstOrDefault().TotalConsumption,
                        Name = g.OrderByDescending(x => x.TotalConsumption).FirstOrDefault().Name
                    })
                    .ToList();
        }
        public List<Food_User> GenerateMealConsumptionReportByUser(int userId)
        {
            return _db.Foods_Users
                .Where(d => d.UserID==userId)
                .Include(x => x.Food)
                .GroupBy(fu => new { fu.FoodID, fu.Meal, fu.Food.FoodName })
                .Select(g => new Food_User
                {
                    FoodID = g.Key.FoodID,
                    Name = g.Key.FoodName,
                    Meal = g.Key.Meal,
                    TotalConsumption = g.Sum(fu => fu.Number)
                })
                .GroupBy(g => g.Meal)
                .Select(g => new Food_User
                {
                    Meal = g.Key,
                    TotalConsumption = g.OrderByDescending(x => x.TotalConsumption).FirstOrDefault().TotalConsumption,
                    Name = g.OrderByDescending(x => x.TotalConsumption).FirstOrDefault().Name
                })
                .ToList();
        }

        public List<Food_User> GenerateCategoryMostConsumedFoodReport()
        {
            return _db.Foods_Users
                    .Include(x => x.Food)
                    .Include(x => x.Food.Category)
                    .GroupBy(fu => new { fu.FoodID, fu.Food.Category.CategoryName, fu.Food.FoodName })
                    .Select(g => new Food_User
                    {
                        FoodID = g.Key.FoodID,
                        Name = g.Key.FoodName,
                        CategoryName = g.Key.CategoryName,
                        TotalConsumption = g.Sum(fu => fu.Number)
                    })
                    .GroupBy(g => g.CategoryName)
                    .Select(g => new Food_User
                    {
                        CategoryName=g.Key,
                        TotalConsumption = g.OrderByDescending(x => x.TotalConsumption).FirstOrDefault().TotalConsumption,
                        Name = g.OrderByDescending(x => x.TotalConsumption).FirstOrDefault().Name
                    })
                    .ToList();
        }

        public List<Food_User> GenerateCategoryMostConsumedFoodReportByUser(int userID)
        {

            return _db.Foods_Users
                    .Where(f=> f.UserID == userID)
                    .Include(x => x.Food)
                    .Include(x => x.Food.Category)
                    .GroupBy(fu => new { fu.FoodID, fu.Food.Category.CategoryName, fu.Food.FoodName })
                    .Select(g => new Food_User
                    {
                        FoodID = g.Key.FoodID,
                        Name = g.Key.FoodName,
                        CategoryName = g.Key.CategoryName,
                        TotalConsumption = g.Sum(fu => fu.Number)
                    })
                    .GroupBy(g => g.CategoryName)
                    .Select(g => new Food_User
                    {
                        CategoryName = g.Key,
                        TotalConsumption = g.OrderByDescending(x => x.TotalConsumption).FirstOrDefault().TotalConsumption,
                        Name = g.OrderByDescending(x => x.TotalConsumption).FirstOrDefault().Name
                    })
                    .ToList();

        }
    }
}





