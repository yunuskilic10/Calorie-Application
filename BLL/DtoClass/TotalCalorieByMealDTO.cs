using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Team2.DtoClass
{
    public class TotalCalorieByMealDTO : IEnumerable
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public decimal Breakfast { get; set; }
        public decimal Lunch { get; set; }
        public decimal Dinner { get; set; }
        public decimal Other { get; set; }

        public IEnumerator GetEnumerator()
        {
            List<decimal> decimals = new List<decimal>() { Breakfast , Lunch , Dinner , Other };
            return decimals.GetEnumerator();
        }
    }
}
