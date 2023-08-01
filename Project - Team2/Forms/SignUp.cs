using BLL;
using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Commands;
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

namespace Project___Team2
{
    public partial class SignUp : DevExpress.XtraEditors.XtraForm
    {
        public SignUp()
        {
            InitializeComponent();
            bll = new();
        }


        CalorieTrackingBusinessLogic bll;

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool control = bll.Users.IsUserExist(txtMail.Text);
            if (Project___Team2.Helper.Helper.AreTextBoxesEmpty(this))
            {
                MessageBox.Show("Kullanıcı bilgileri boş bırakılamaz.");
            }

            if (control)
            {
                MessageBox.Show("Bu mailde kullanici vardir");
            }
            else
            {
                User user = new User();
                string password = txtPassword.Text;
                if (txtPassword.Text == txtPasswordAgain.Text)
                {

                    if (Project___Team2.Helper.Helper.MailControl(txtMail.Text) && Project___Team2.Helper.Helper.PasswordControl(password))
                    {

                        string hashPassword = Project___Team2.Helper.Helper.sha256_hash(password);
                        user.Password = hashPassword;
                        user.FirstName = txtFirstName.Text + " " + txtLastName.Text;
                        user.UserName = txtMail.Text;
                        user.BirthDate = (DateTime)dtpBirthDate.EditValue;

                        UserProperty users = new UserProperty(user);
                        this.Hide();
                        users.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Mail veya Şifre Geçersiz. Şifre en az iki adet büyük harf, en az üç adet küçük harf, en az üç adet rakam ve ! - * - : karakterlerinden iki tanesini içerlemlidir.", "UYARI", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Uyuşmuyor.", "UYARI", MessageBoxButtons.OK);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}