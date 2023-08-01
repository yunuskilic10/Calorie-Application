using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Category
    {
        public Category()
        {
            Foods = new List<Food>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Food> Foods { get; set; }
    }
}
