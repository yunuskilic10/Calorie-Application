using DevExpress.Spreadsheet.Charts;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Entities.Models;
using Guna.Charts.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project___Team2.Forms
{
    public partial class DailyReportForm : Form
    {
        public DailyReportForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            bll = new();
        }

        int userID;
        BLL.CalorieTrackingBusinessLogic bll;

        private void DailyReportForm_Load(object sender, EventArgs e)
        {
            lblmostConsumedFood.Text = bll.FoodsUsers.GetMostConsumedFood().FoodName.ToString();
            lblDateTime.Text = DateTime.Now.ToString();
            DateTime day = DateTime.Now.Date;
            int ix = 0;
            List<Food_User> caloriesbymeal = bll.FoodsUsers.TotalCaloriesPerMeal(day, userID);
            List<LPoint> dailyCalories = new List<LPoint>();
            List<string> meals = new();

            foreach (var item in Enum.GetNames(typeof(Entities.Enums.Meal)))
            {
                meals.Add(item.ToString());
            }
            foreach (var item in caloriesbymeal)
            {
                LPoint caloriee = new LPoint();
                caloriee.Label = meals[ix];
                caloriee.Y = (double)item.TotalCalorie;
                dailyCalories.Add(caloriee);
                ix++;
            }

            horizantalDaily.Label = bll.Users.Find(userID).FirstName;
            horizantalDaily.DataPoints.AddRange(dailyCalories);

            decimal dailycalorie = 0;

            foreach (var item in caloriesbymeal)
            {
                dailycalorie += item.TotalCalorie;
            }

            List<Guna2HtmlLabel> labels = new List<Guna2HtmlLabel>()
            {
                lblBreakfast, lblLunch, lblDinner, lblOthers
            };

            for (int i = 0; i < caloriesbymeal.Count; i++)
            {
                labels[i].Text = Math.Round(caloriesbymeal[i].TotalCalorie,1).ToString();
            }

            lbltotalcalories.Text = Math.Round(dailycalorie,1).ToString();

        }


    }
}


