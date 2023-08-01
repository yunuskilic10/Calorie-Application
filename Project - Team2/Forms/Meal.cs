using BLL;
using DevExpress.XtraEditors;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Project___Team2.Forms
{
    public partial class Meal : DevExpress.XtraEditors.XtraForm
    {
        public Meal(User user)
        {
            InitializeComponent();
            this.user = user;
            bll = new();
        }

        User user;
        CalorieTrackingBusinessLogic bll;
        int id;
        Food food;

        private void Meal_Load(object sender, EventArgs e)
        {

            var foods = bll.Foods.List().Select(s => new { FoodID = s.FoodID, FoodName = s.FoodName, Calorie = s.Calorie, CategoryName = s.Category.CategoryName }).ToList();
            cbxMeal.Items.AddRange(Enum.GetNames(typeof(Entities.Enums.Meal)));
            dgvFood.DataSource = foods;
            dtpDay.Value = DateTime.Now;

        }
        private void btnAddNewMeal_Click(object sender, EventArgs e)
        {
            AddMeal addMeal = new AddMeal(user);
            addMeal.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Food_User foodsUsers = new Food_User();

            foodsUsers.Number = (byte)nudNumberOfFood.Value;
            foodsUsers.Day = (DateTime)dtpDay.Value;
            foodsUsers.Meal = (Entities.Enums.Meal)Enum.Parse(typeof(Entities.Enums.Meal), cbxMeal.SelectedItem.ToString());
            foodsUsers.UserID = user.UserID;
            foodsUsers.FoodID = id;


            bool isAdded = bll.FoodsUsers.Add(foodsUsers);
            if (isAdded)
            {
                MessageBox.Show("Kayıt Başarılı ");
            }
            else
            {
                MessageBox.Show("Eklenirken bir hata oluştu.");
            }
        }

        private void txtFood_TextChanged(object sender, EventArgs e)
        {
            var foods = bll.Foods.GetFoodByWord(txtFood.Text).Select(s => new { FoodID = s.FoodID, FoodName = s.FoodName, Calorie = s.Calorie, CategoryName = s.Category.CategoryName }).ToList();
            dgvFood.DataSource = foods;
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dgvFood.SelectedRows[0].Cells[0].Value;

        }

    }
}