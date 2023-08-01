using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Food_User
    {
        public Food_User()
        {
            Day = DateTime.Now;
        }
        [Key]
        public int ID { get; set; }

        [ForeignKey("Food")]
        public int FoodID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public byte Number { get; set; }

        [NotMapped]
        public decimal TotalCalorie { get; set; }
        [NotMapped]
        public int TotalConsumption { get; set; }
        [NotMapped]
        public string Name { get; set; }
        [NotMapped]
        public string CategoryName { get; set; }

        public Meal Meal { get; set; }
        public DateTime Day { get; set; }

        public Food Food { get; set; }
        public User User { get; set; }

    }
}
