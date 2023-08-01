using BLL;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraEditors;
using Entities.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Project___Team2.Forms
{
    public partial class UserPage : DevExpress.XtraEditors.XtraForm
    {
        public UserPage(User user)
        {
            InitializeComponent();
            this.user = user;
            bll = new();
            userID = user.UserID;
        }

        CalorieTrackingBusinessLogic bll;
        User user;
        int userID;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChange password = new PasswordChange(user.UserID);
            password.ShowDialog();
            this.Close();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            DateTime day = DateTime.Now;
            cboxActivitylevel.Items.AddRange(Enum.GetNames(typeof(Entities.Enums.Activity)));
            double consumedCalorie = 0;
            lblAgee.Text = user.Age.ToString();
            lblHeightt.Text = Math.Round((double)user.Height, 2).ToString();
            nudtargetWeight.Value = (decimal)user.GoalWeight;
            nudWeight.Value = Convert.ToDecimal(user.Weight);
            lblName.Text = user.FirstName.ToString();
            lblUsername.Text = user.UserName.ToString();
            lblGender.Text = user.Gender.ToString();
            cboxActivitylevel.SelectedIndex = (int)user.Activity.Value - 1;

            var daily = bll.FoodsUsers.GetDailyTotalCalorie(day, userID);
            double basalMetabolism = bll.Users.CalculateBasalMetabolism(user);
            if (daily != null)
            {
                consumedCalorie = (double)daily.TotalCalorie;
            }

            double remainingCalorie = bll.Users.CompareCalorie(basalMetabolism, consumedCalorie);
            //double dailyCalorieGoal = basalMetabolism;

            // Günlük hedef kaloriyi temsil eden bar
            guna2CircleProgressBar2.Minimum = 0;
            guna2CircleProgressBar2.Maximum = (int)basalMetabolism;
            guna2CircleProgressBar2.Value = (int)consumedCalorie;

            // Kalan kaloriyi temsil eden bar
            lblremainingcalorie.Text = Math.Round((double)remainingCalorie, 1).ToString();
            lblcalorieyouneed.Text = Math.Round((double)basalMetabolism, 1).ToString();

            if (guna2CircleProgressBar2.Value == guna2CircleProgressBar2.Maximum)
            {
                guna2CircleProgressBar2.ProgressColor = Color.Red;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            user.Weight = Convert.ToDouble(nudWeight.Value);
            user.GoalWeight = Convert.ToDouble(nudtargetWeight.Value);
            user.Activity = (Entities.Enums.Activity)Enum.Parse(typeof(Entities.Enums.Activity), cboxActivitylevel.SelectedItem.ToString());
            bll.Users.Update(user);
        }

    }
}