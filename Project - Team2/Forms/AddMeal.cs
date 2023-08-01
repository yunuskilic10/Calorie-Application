using BLL;
using DevExpress.XtraEditors;
using Entities.Enums;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project___Team2
{
    public partial class AddMeal : DevExpress.XtraEditors.XtraForm
    {
        public AddMeal(User user)
        {
            InitializeComponent();
            bll = new();
            this.user = user;
        }

        User user;
        CalorieTrackingBusinessLogic bll;
        private void AddMeal_Load(object sender, EventArgs e)
        {
            gunacbxaddmeal.Items.AddRange(Enum.GetNames(typeof(Meal)));
        }

        private void gunabtnSave_Click(object sender, EventArgs e)
        {
            if (Project___Team2.Helper.Helper.AreTextBoxesEmpty(this))
            {
                MessageBox.Show("Besin bilgileri boş bırakılamaz.");
            }

            bool control = bll.Foods.IsFoodExist(gunatxtaddfood.Text);

            if (control)
            {
                MessageBox.Show("Bu besin uygulamamızda mevcuttur.");
            }

            else
            {

                Food_User food_user = new Food_User();

                food_user.Food = new Food() { FoodName = gunatxtaddfood.Text, Calorie = Convert.ToDecimal(gunatxtaddcalorie.Text) };
                food_user.Food.Category = new Category() { CategoryName = gunatxtaddcategory.Text };
                food_user.Meal = (Meal)Enum.Parse(typeof(Meal), gunacbxaddmeal.SelectedItem.ToString());
                food_user.Day = (DateTime)gunadtpaddDay.Value;
                food_user.Number = (byte)gunanudaddnumber.Value;
                food_user.UserID = user.UserID;

                bool isAdded = bll.FoodsUsers.Add(food_user);
                if (isAdded)
                {
                    MessageBox.Show("Besin Kaydedildi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Besin eklenirken hata olustu.");
                }
            }
        }
    }
}

