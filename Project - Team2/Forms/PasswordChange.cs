using BLL;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Export;
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
using System.Windows.Media.Animation;

namespace Project___Team2.Forms
{
    public partial class PasswordChange : DevExpress.XtraEditors.XtraForm
    {
        public PasswordChange(int userID)
        {
            InitializeComponent();
            this.userId = userID;
            bll = new();
        }
        int userId;
        CalorieTrackingBusinessLogic bll;
        User user;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Project___Team2.Helper.Helper.AreTextBoxesEmpty(this))
            {
                MessageBox.Show("Alanlar boş geçilemez");
            }
            else
            {
                if (Project___Team2.Helper.Helper.sha256_hash(gunaTextBoxNewPassword.Text) != Project___Team2.Helper.Helper.sha256_hash(gunaTextBoxnewPasswordAgain.Text))
                {
                    MessageBox.Show("Şİfreler Uyuşmuyor");
                }
                else
                {
                    user = bll.Users.Find(userId);
                    if (user.Password == Project___Team2.Helper.Helper.sha256_hash(gunaTextBoxPassword.Text))
                    {
                        user.Password = Project___Team2.Helper.Helper.sha256_hash(gunaTextBoxNewPassword.Text);
                        bool isUpdated = bll.Users.Update(user);
                        if (isUpdated)
                        {
                            MessageBox.Show("Güncellendi");
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Güncellenemedi!!!");
                        }



                    }
                    else
                    {
                        MessageBox.Show("Eski şifreyi yanlış girdiniz");
                    }
                }
            }
        }

       
    }
}




