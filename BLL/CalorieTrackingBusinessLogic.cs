using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CalorieTrackingBusinessLogic
    {
        public CalorieTrackingBusinessLogic()
        {
            Users = new UserBLL();
            Categories = new CategoryBLL();
            Foods = new FoodBLL();
            FoodsUsers = new Food_UserBLL();
        }

        public UserBLL Users { get; set; }
        public CategoryBLL Categories { get; set; }
        public FoodBLL Foods { get; set; }
        public Food_UserBLL FoodsUsers { get; set; }

    }
}
