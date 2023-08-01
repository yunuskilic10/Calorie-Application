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
    public partial class ReportsMainPage : Form
    {
        public ReportsMainPage(int ID)
        {
            InitializeComponent();
            userID = ID;
        }
        int userID;

        private void ReportsMainPage_Load(object sender, EventArgs e)
        {
            ViewChildForm(new DailyReportForm(userID));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ViewChildForm(new DailyReportForm(userID));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ViewChildForm(new chartCategoryForm());
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ViewChildForm(new chartMealForm());
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ViewChildForm(new ReportsPage(userID));
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
