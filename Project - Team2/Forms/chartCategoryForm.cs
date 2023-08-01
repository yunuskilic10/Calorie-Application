using DevExpress.Pdf.Native.BouncyCastle.X509;
using Guna.Charts.WinForms;
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
    public partial class chartCategoryForm : Form
    {
        public chartCategoryForm()
        {
            InitializeComponent();
            bll = new();
        }
        BLL.CalorieTrackingBusinessLogic bll;
        private void chartCategoryForm_Load(object sender, EventArgs e)
        {
            lblBaslik.Text = "Most Consumed By Category(User)";
            List<Label> lblList = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, label8, label9 };
            int ix = 0;
            var mostConsumedCategoryUser = bll.FoodsUsers.GenerateCategoryMostConsumedFoodReportByUser(1);

            List<LPoint> consumtionReport = new List<LPoint>();

            foreach (var item in mostConsumedCategoryUser)
            {
                LPoint point = new LPoint();
                point.Label = item.Name;
                point.Y = item.TotalConsumption;
                consumtionReport.Add(point);
                lblList[ix].Text = item.Name + " - " + item.CategoryName;
                ix++;
            }
            pieCategoryy.DataPoints.AddRange(consumtionReport);


        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            pieCategoryy.DataPoints.Clear();
            int ix = 0;
            List<Label> lblList = new List<Label>() { label1, label2, label3, label4, label5, label6, label7, label8, label9 };

            if (guna2ToggleSwitch1.Checked)
            {
                lblBaslik.Text = "Most Consumed By Category(User)";
                var mostConsumedCategoryUser = bll.FoodsUsers.GenerateCategoryMostConsumedFoodReportByUser(1);

                List<LPoint> consumtionReport = new List<LPoint>();

                foreach (var item in mostConsumedCategoryUser)
                {
                    LPoint point = new LPoint();
                    point.Label = item.Name;
                    point.Y = item.TotalConsumption;
                    consumtionReport.Add(point);
                    lblList[ix].Text = item.Name + " - " + item.CategoryName;
                    ix++;
                }

                pieCategoryy.DataPoints.AddRange(consumtionReport);
            }
            else
            {

                var mostConsumedCategory = bll.FoodsUsers.GenerateCategoryMostConsumedFoodReport();
                List<LPoint> consumtionReport1 = new List<LPoint>();
                lblBaslik.Text = "Most Consumed By Category(Public)";
                foreach (var item in mostConsumedCategory)
                {
                    LPoint point = new LPoint();
                    point.Label = item.Name;
                    point.Y = item.TotalConsumption;
                    consumtionReport1.Add(point);
                    lblList[ix].Text = item.Name + " - " + item.CategoryName;
                    ix++;
                }

                pieCategoryy.DataPoints.AddRange(consumtionReport1);

            }


        }
    }
}
