using DAL.Context;
using Entities;
using Entities.Enums;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        CalorieTrackingAppDB _db;
        public UserBLL()
        {
            _db = new CalorieTrackingAppDB();
        }

        public bool Add(User entity)
        {
            _db.Users.Add(entity);
            return _db.SaveChanges() > 0;
        }

        public User Find(int id)
        {
            return _db.Users.Find(id);
        }

        public List<User> List()
        {
            return _db.Users.ToList();
        }

        public bool Remove(int id)
        {
            _db.Users.Remove(Find(id));
            return _db.SaveChanges() > 0;
        }

        public bool Update(User entity)
        {
            _db.Users.Update(entity);
            return _db.SaveChanges() > 0;
        }

        public User? GetUserByMail(string mail)
        {
            return _db.Users.FirstOrDefault(u => u.UserName == mail);
        }

        public bool IsUserExist(string mail)
        {
            return _db.Users.Any(u => u.UserName == mail);
        }

        public double CalculateBasalMetabolism(User user)
        {
            double bmr = 0;

            // Harris-Benedict formülüne göre bazal metabolizmayı hesapla
            if (user.Gender == Gender.Male)
            {
                bmr = 88.362 + (double)((13.397 * user.Weight) + (4.799 * user.Height) - (5.677 * user.Age));
            }
            else
            {
                bmr = 447.593 + (double)((9.247 * user.Weight) + (3.098 * user.Height) - (4.330 * user.Age));
            }


            // Aktivite seviyesine göre bazal metabolizmayı ayarla
            double activityFactor = 0;

            if (user.Activity == Activity.LessExercise)
            {
                activityFactor = 1.2;
            }
            else if (user.Activity == Activity.ModerateExercise)
            {
                activityFactor = 1.5;
            }
            else
            {
                activityFactor = 1.7;
            }

            double basalMetabolism = bmr * activityFactor;
            return basalMetabolism;
        }
        public double CompareCalorie(double basalMetabolism, double calorie)
        {
            if (calorie < basalMetabolism)
            {
                double reminderCalorie = basalMetabolism - calorie;
                return reminderCalorie;
            }
            else
            {
                double excessCalorie = calorie - basalMetabolism;
                return -1*excessCalorie;
            }
        }
    }    
}

