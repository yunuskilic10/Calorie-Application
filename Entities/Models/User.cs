using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User
    {
        public User()
        {
            DateOfRegistration = DateTime.Now;
            Foods_Users = new HashSet<Food_User>();
        }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public int Age
        {
            get
            {
                DateTime dateNow = DateTime.Now;
                TimeSpan age = dateNow - BirthDate;
                double yearDiff = age.TotalDays / 365.25;
                int userAge = (int)Math.Floor(yearDiff);
                return userAge;
            }
        }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public Activity? Activity { get; set; }
        public double? BasalMetabolicRate { get; set; }
        public double? GoalWeight { get; set; }
        public string? ImagePath { get; set; }
        public DateTime DateOfRegistration { get; set; }

        public ICollection<Food_User> Foods_Users { get; set; }

    }
}
