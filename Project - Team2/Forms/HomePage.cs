using BLL;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Xpo.Metadata.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using DevExpress.XtraPrinting;
using DevExpress.XtraScheduler.Reporting.Native;
using Entities.Enums;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___Team2.Forms
{
    public partial class HomePage : DevExpress.XtraEditors.XtraForm
    {
        public HomePage(User user)
        {
            InitializeComponent();
            bll = new();
            this.user = user;

        }

        User user;
        CalorieTrackingBusinessLogic bll;
        DateTime selectedDate;
        List<Food_User> foodsUsers;
        int id;
        Food_User foodUser;


        private void HomePage_Load(object sender, EventArgs e)
        {
            lblName.Text = user.FirstName;
            lblCaloriesYouNeed.Text = Math.Round(bll.Users.CalculateBasalMetabolism(user)).ToString();
            FillListBox(Entities.Enums.Meal.Breakfast);
            cbxMeal.Items.AddRange(Enum.GetNames(typeof(Entities.Enums.Meal)));
            dtpDatePicker.Value = DateTime.Now;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            FillListBox(Entities.Enums.Meal.Breakfast);
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            FillListBox(Entities.Enums.Meal.Lunch);
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            FillListBox(Entities.Enums.Meal.Dinner);
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            FillListBox(Entities.Enums.Meal.Others);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bll.FoodsUsers.Remove(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foodUser = bll.FoodsUsers.Find(id);
            if (foodUser != null)
            {
                foodUser.Number = (byte)nudNumber.Value;
                foodUser.Day = Convert.ToDateTime(dtpDay.EditValue);
                foodUser.Meal = (Entities.Enums.Meal)Enum.Parse(typeof(Entities.Enums.Meal), cbxMeal.SelectedItem.ToString());
                bll.FoodsUsers.Update(foodUser);
            }
        }

        private void lsvMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMeal.SelectedItems.Count > 0)
            {
                id = (int)lsvMeal.SelectedItems[0].Tag;
                foodUser = bll.FoodsUsers.Find(id);
                if (foodUser != null)
                {
                    nudNumber.Value = foodUser.Number;
                    dtpDay.EditValue = dtpDatePicker.Value;
                    cbxMeal.SelectedItem = foodUser.Meal.ToString();
                }
            }
        }
        private void dtpDatePicker_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dtpDatePicker.Value;
        }

        public void FillListBox(Entities.Enums.Meal meal)
        {
            int bin = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).IndexOf("bin");
            string projeyolu = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).Substring(0, bin) + "ProjeResimler\\";
            lsvMeal.Items.Clear();
            foodsUsers = bll.FoodsUsers.GetFoodUsersSelectedDate(user.UserID, selectedDate);

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(128, 128);

            if (meal == Entities.Enums.Meal.Breakfast)
            {
                List<Food_User> fuBreakfast = bll.FoodsUsers.GetFoodUsersSelectedMeal(foodsUsers, Entities.Enums.Meal.Breakfast);


                foreach (var item in fuBreakfast)
                {
                    if (item.Food.ImagePath != null)
                    {
                        Image image = Image.FromFile(projeyolu + item.Food.ImagePath);
                        imageList.Images.Add(image);
                    }
                }
                int i = 0;
                lsvMeal.LargeImageList = imageList;
                foreach (var item in fuBreakfast)
                {
                    ListViewItem lsw = new();
                    lsw.Tag = item.ID;
                    lsw.Text = item.Food.FoodName;
                    lsw.ImageIndex = i++;
                    lsvMeal.Items.Add(lsw);
                }
            }
            else if (meal == Entities.Enums.Meal.Lunch)
            {
                List<Food_User> fuLunch = bll.FoodsUsers.GetFoodUsersSelectedMeal(foodsUsers, Entities.Enums.Meal.Lunch);

                foreach (var item in fuLunch)
                {
                    if (item.Food.ImagePath != null)
                    {
                        Image image = Image.FromFile(projeyolu + item.Food.ImagePath);
                        imageList.Images.Add(image);
                    }
                }
                int i = 0;
                lsvMeal.LargeImageList = imageList;
                foreach (var item in fuLunch)
                {
                    ListViewItem lsw = new();
                    lsw.Tag = item.ID;
                    lsw.Text = item.Food.FoodName;
                    lsw.ImageIndex = i++;
                    lsvMeal.Items.Add(lsw);
                }
            }
            else if (meal == Entities.Enums.Meal.Dinner)
            {
                List<Food_User> fuDinner = bll.FoodsUsers.GetFoodUsersSelectedMeal(foodsUsers, Entities.Enums.Meal.Dinner);
                foreach (var item in fuDinner)
                {
                    if (item.Food.ImagePath != null)
                    {
                        Image image = Image.FromFile(projeyolu + item.Food.ImagePath);
                        imageList.Images.Add(image);
                    }
                }
                int i = 0;
                lsvMeal.LargeImageList = imageList;
                foreach (var item in fuDinner)
                {
                    ListViewItem lsw = new();
                    lsw.Tag = item.ID;
                    lsw.Text = item.Food.FoodName;
                    lsw.ImageIndex = i++;
                    lsvMeal.Items.Add(lsw);
                }

            }
            else if (meal == Entities.Enums.Meal.Others)
            {
                List<Food_User> fuOthers = bll.FoodsUsers.GetFoodUsersSelectedMeal(foodsUsers, Entities.Enums.Meal.Others);

                foreach (var item in fuOthers)
                {
                    if (item.Food.ImagePath != null)
                    {
                        Image image = Image.FromFile(projeyolu + item.Food.ImagePath);
                        imageList.Images.Add(image);
                    }
                }
                int i = 0;
                lsvMeal.LargeImageList = imageList;
                foreach (var item in fuOthers)
                {
                    ListViewItem lsw = new();
                    lsw.Tag = item.ID;
                    lsw.Text = item.Food.FoodName;
                    lsw.ImageIndex = i++;
                    lsvMeal.Items.Add(lsw);
                }
            }
        }

    }
}