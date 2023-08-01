using BLL;
using DAL.Context;
using DevExpress.XtraEditors;
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
    public partial class UserProperty : DevExpress.XtraEditors.XtraForm
    {
        public UserProperty()
        {
            InitializeComponent();
        }
        public UserProperty(User user)
        {
            InitializeComponent();
            this.user = user;
            bll = new();
        }

        User user;
        CalorieTrackingBusinessLogic bll;


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                user.Gender = Entities.Enums.Gender.Male;
            }
            else
            {
                user.Gender = Entities.Enums.Gender.Female;
            }

            if (Project___Team2.Helper.Helper.AreTextBoxesEmpty(this))
            {
                MessageBox.Show("Lütfen gerekli bilgileri doldurunuz.");
            }
            else
            {

                
                user.Weight = Convert.ToDouble(txtWeight.Text);
                user.Height = Convert.ToDouble(txtHeight.Text);
                user.GoalWeight = Convert.ToDouble(txtTargetWeight.Text);


                if (cbxLessExercise.Checked)
                {
                    user.Activity = Entities.Enums.Activity.LessExercise;
                }
                else if (cbxModerateExercises.Checked)
                {
                    user.Activity = Entities.Enums.Activity.ModerateExercise;
                }
                else 
                {
                    user.Activity = Entities.Enums.Activity.LotsOfExercise;
                }

                user.BasalMetabolicRate = bll.Users.CalculateBasalMetabolism(user);


                bool isAdded = bll.Users.Add(user);
                if (isAdded)
                {
                    MessageBox.Show("Kullanici Kaydedildi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanici eklenirken hata olustu.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}