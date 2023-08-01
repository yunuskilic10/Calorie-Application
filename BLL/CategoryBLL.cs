using DAL.Context;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBLL 
    {
        CalorieTrackingAppDB _db;
        public CategoryBLL()
        {
            _db = new CalorieTrackingAppDB();
        }

        public bool Add(Category entity)
        {
            _db.Categories.Add(entity);
            return _db.SaveChanges() > 0;
        }

        public Category Find(int id)
        {
            return _db.Categories.Find(id);
        }

        public List<Category> List()
        {
            return _db.Categories.ToList();
        }

        public bool Remove(int id)
        {
            _db.Categories.Remove(Find(id));
            return _db.SaveChanges() > 0;
        }

        public bool Update(Category entity)
        {
            _db.Categories.Update(entity);
            return _db.SaveChanges() > 0;
        }
    }
}
