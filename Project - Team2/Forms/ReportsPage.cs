using BLL;
using DevExpress.XtraEditors;
using Entities.Enums;
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
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraCharts;
using DevExpress.XtraRichEdit.Export.OpenXml;
using System.Collections;
using DevExpress.PivotGrid.ServerMode.Queryable;
using static DevExpress.Xpo.Helpers.CannotLoadObjectsHelper;
using DevExpress.CodeParser;

namespace Project___Team2.Forms
{
    public partial class ReportsPage : DevExpress.XtraEditors.XtraForm
    {
        public ReportsPage(int UserID)
        {
            InitializeComponent();
            bll = new();
            userID = UserID;
        }

        CalorieTrackingBusinessLogic bll;
        Food food;
        Food_User foodUser;
        int id1;
        int userID;
        bool mealClickCheck;



        private void ReportsPage_Load(object sender, EventArgs e)
        {
            id1 = 1;
            var userList = bll.Users.List().Select(s => new { UserID = s.UserID, UserName = s.FirstName }).ToList();
            dgvUsers.DataSource = userList;

            mealClickCheck = true;
            FillChart(mealClickCheck, userID);
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id1 = (int)dgvUsers.SelectedRows[0].Cells[0].Value;
            FillChart(mealClickCheck, id1);
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            FillChart(mealClickCheck, id1);
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            mealClickCheck = true;
            FillChart(mealClickCheck, id1);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            mealClickCheck = false;
            FillChart(mealClickCheck, id1);
        }


        public void FillChart(bool mealClick, int id)
        {
            gunaBarDataset1.DataPoints.Clear();
            int ix = 0;
            if (mealClick)
            {
                if (guna2ToggleSwitch1.Checked)
                {
                    var calorieList1 = bll.FoodsUsers.TotalCalorieByMealMonthly(id).FirstOrDefault(f => f.UserID == id1);

                    List<string> meals = new();
                    foreach (var item in Enum.GetNames(typeof(Entities.Enums.Meal)))
                    {
                        meals.Add(item.ToString());
                    }

                    List<LPoint> list = new List<LPoint>();
                    if (calorieList1 != null)
                    {
                        foreach (var calorie in calorieList1)
                        {
                            LPoint lPoint = new LPoint();
                            lPoint.Label = meals[ix];
                            decimal c = (decimal)calorie;
                            lPoint.Y = (double)c;
                            list.Add(lPoint);
                            ix++;
                        }
                        gunaBarDataset1.Label = bll.Users.Find(id1).FirstName;
                        gunaBarDataset1.DataPoints.AddRange(list);
                    }
                }
                else
                {
                    var calorieList2 = bll.FoodsUsers.TotalCalorieByMealWeekly(id).FirstOrDefault(f => f.UserID == id1);
                    List<string> meals = new();
                    foreach (var item in Enum.GetNames(typeof(Entities.Enums.Meal)))
                    {
                        meals.Add(item.ToString());
                    }
                    if (calorieList2 != null)
                    {
                        List<LPoint> list = new List<LPoint>();
                        foreach (var calorie in calorieList2)
                        {
                            LPoint lPoint = new LPoint();
                            lPoint.Label = meals[ix];
                            decimal c = (decimal)calorie;
                            lPoint.Y = (double)c;
                            list.Add(lPoint);
                            ix++;
                        }
                        gunaBarDataset1.Label = bll.Users.Find(id1).FirstName;
                        gunaBarDataset1.DataPoints.AddRange(list);
                    }
                }
            }
            else
            {
                if (guna2ToggleSwitch1.Checked)
                {
                    var calorieList3 = bll.FoodsUsers.TotalCalorieByCategoryMonthly(id).FirstOrDefault(f => f.UserID == id1);
                    var kategoriler = bll.Categories.List();
                    if (calorieList3 != null)
                    {
                        List<LPoint> list = new List<LPoint>();
                        foreach (var calorie in calorieList3)
                        {
                            LPoint lPoint = new LPoint();
                            lPoint.Label = kategoriler[ix].CategoryName;
                            decimal c = (decimal)calorie;
                            lPoint.Y = (double)c;
                            list.Add(lPoint);
                            ix++;
                        }
                        gunaBarDataset1.Label = bll.Users.Find(id1).FirstName;
                        gunaBarDataset1.DataPoints.AddRange(list);
                    }
                }
                else
                {
                    var calorieList4 = bll.FoodsUsers.TotalCalorieByCategoryWeekly(id).FirstOrDefault(f => f.UserID == id1);
                    var kategoriler = bll.Categories.List();

                    List<LPoint> list = new List<LPoint>();
                    if (calorieList4 != null)
                    {
                        foreach (var calorie in calorieList4)
                        {
                            LPoint lPoint = new LPoint();
                            lPoint.Label = kategoriler[ix].CategoryName;
                            decimal c = (decimal)calorie;
                            lPoint.Y = (double)c;
                            list.Add(lPoint);
                            ix++;
                        }
                        gunaBarDataset1.Label = bll.Users.Find(id1).FirstName;
                        gunaBarDataset1.DataPoints.AddRange(list);

                    }
                }
            }

        }
    }
}