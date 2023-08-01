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
    public partial class chartMealForm : Form
    {
        public chartMealForm()
        {
            InitializeComponent();
            bll = new();
        }
        BLL.CalorieTrackingBusinessLogic bll;
        private void chartMealForm_Load(object sender, EventArgs e)
        {
            pieMeall.DataPoints.Clear();
            int ix = 0;
            var mostConsumedMealUser = bll.FoodsUsers.GenerateMealConsumptionReportByUser(1);

            List<Label> lblList = new List<Label>() { lblBreakfast, lblLunch, lblDinner, lblOthers };

            List<LPoint> consumtionReport = new List<LPoint>();

            foreach (var item in mostConsumedMealUser)
            {
                LPoint point = new LPoint();
                point.Label = item.Meal.ToString();
                point.Y = item.TotalConsumption;
                consumtionReport.Add(point);
                lblList[ix].Text = item.Name + " - " + item.TotalConsumption;
                ix++;
            }
            pieMeall.DataPoints.AddRange(consumtionReport);
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            pieMeall.DataPoints.Clear();

            int ix = 0;
            var mostConsumedMeal = bll.FoodsUsers.GenerateMealConsumptionReport();
            var mostConsumedMealUser = bll.FoodsUsers.GenerateMealConsumptionReportByUser(1);

            List<Label> lblList = new List<Label>() { lblBreakfast, lblLunch, lblDinner, lblOthers };

            if (guna2ToggleSwitch1.Checked)
            {



                List<LPoint> consumtionReport = new List<LPoint>();

                foreach (var item in mostConsumedMealUser)
                {
                    LPoint point = new LPoint();
                    point.Label = item.Meal.ToString();
                    point.Y = item.TotalConsumption;
                    consumtionReport.Add(point);
                    lblList[ix].Text = item.Name + " - " + item.TotalConsumption;
                    ix++;
                }
                pieMeall.DataPoints.AddRange(consumtionReport);
            }
            else
            {
                List<LPoint> consumtionReport1 = new List<LPoint>();

                foreach (var item in mostConsumedMeal)
                {
                    LPoint point = new LPoint();
                    point.Label = item.Meal.ToString();
                    point.Y = item.TotalConsumption;
                    consumtionReport1.Add(point);
                    lblList[ix].Text = item.Name + " - " + item.TotalConsumption;
                    ix++;
                }
                pieMeall.DataPoints.AddRange(consumtionReport1);

            }
        }
    }
}
