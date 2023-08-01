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

namespace Project___Team2.Forms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        User user;
        private void MainForm_Load(object sender, EventArgs e)
        {
            ViewChildForm(new HomePage(user));
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ViewChildForm(new UserPage(user));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ViewChildForm(new HomePage(user));
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            ViewChildForm(new Meal(user));
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsMainPage rmp = new ReportsMainPage(user.UserID);
            rmp.ShowDialog();
            this.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ViewChildForm(Form form)
        {
            CloseForms();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void CloseForms()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
    }
}