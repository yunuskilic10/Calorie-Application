using DAL.Context;
using Entities;
using Entities.Enums;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class FoodBLL
    {
        CalorieTrackingAppDB _db;
        public FoodBLL()
        {
            _db = new CalorieTrackingAppDB();
        }

        public bool Add(Food entity)
        {
            _db.Foods.Add(entity);
            return _db.SaveChanges() > 0;
        }

        public Food Find(int id)
        {
            return _db.Foods.Find(id);
        }

        public List<Food> List()
        {
            return _db.Foods.Include(s => s.Category).ToList();
        }

        public bool Remove(int id)
        {
            _db.Foods.Remove(Find(id));
            return _db.SaveChanges() > 0;
        }

        public bool Update(Food entity)
        {
            _db.Foods.Update(entity);
            return _db.SaveChanges() > 0;
        }
        public bool IsFoodExist(string name)
        {
            return _db.Foods.Any(u => u.FoodName == name);
        }
        public List<Food> GetFoodByWord(string text)
        {

            return _db.Foods.Where(x => x.FoodName.Contains(text)).ToList();

        }

        public decimal GetFoodCalorie(int foodID)
        {
            return _db.Foods.FirstOrDefault(f => f.FoodID == foodID).Calorie;
        }

    }
}