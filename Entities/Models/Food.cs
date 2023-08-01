using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Food
    {
        public Food()
        {
            Foods_Users = new HashSet<Food_User>();
        }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public decimal Calorie { get; set; }
        public int CategoryID { get; set; }
        public string? ImagePath { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public int TotalConsumption { get; set; }
        public ICollection<Food_User> Foods_Users { get; set; }

        

    }
}
