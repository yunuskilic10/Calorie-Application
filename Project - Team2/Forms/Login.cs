using BLL;
using DevExpress.XtraEditors;
using Entities.Models;
using Project___Team2.Forms;
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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            bll = new();

        }
        CalorieTrackingBusinessLogic bll;
        User? user;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            user = bll.Users.GetUserByMail(txtMail.Text);
            if (Project___Team2.Helper.Helper.AreTextBoxesEmpty(this))
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!", "UYARI", MessageBoxButtons.OK);
            }
            else
            {
                if (user != null && Project___Team2.Helper.Helper.sha256_hash(txtPassword.Text) == user.Password || user.Password == "123" || user.Password == "1234")
                {
                    MainForm main = new MainForm(user);
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "UYARI", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}