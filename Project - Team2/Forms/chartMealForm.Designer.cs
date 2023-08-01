namespace Project___Team2.Forms
{
    partial class chartMealForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mealChart = new Guna.Charts.WinForms.GunaChart();
            pieMeall = new Guna.Charts.WinForms.GunaPieDataset();
            guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            label9 = new Label();
            lblDinner = new Label();
            lblOthers = new Label();
            lblLunch = new Label();
            lblBreakfast = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mealChart
            // 
            mealChart.BackColor = Color.White;
            mealChart.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] { pieMeall });
            chartFont1.FontName = "Arial";
            mealChart.Legend.LabelFont = chartFont1;
            mealChart.Location = new Point(12, 72);
            mealChart.Name = "mealChart";
            mealChart.Size = new Size(482, 417);
            mealChart.TabIndex = 0;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            mealChart.Title.Font = chartFont2;
            mealChart.Title.ForeColor = Color.DarkOliveGreen;
            mealChart.Title.Text = "Most Consumed Foods by Meal";
            chartFont3.FontName = "Arial";
            mealChart.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            mealChart.Tooltips.TitleFont = chartFont4;
            mealChart.XAxes.Display = false;
            mealChart.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            mealChart.XAxes.Ticks = tick1;
            mealChart.YAxes.Display = false;
            mealChart.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            mealChart.YAxes.Ticks = tick2;
            mealChart.ZAxes.Display = false;
            mealChart.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            mealChart.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            mealChart.ZAxes.Ticks = tick3;
            // 
            // pieMeall
            // 
            pieMeall.Label = "Pie1";
            pieMeall.TargetChart = mealChart;
            // 
            // guna2ToggleSwitch1
            // 
            guna2ToggleSwitch1.CheckedState.BorderColor = Color.DarkOrange;
            guna2ToggleSwitch1.CheckedState.FillColor = Color.Orange;
            guna2ToggleSwitch1.CheckedState.InnerBorderColor = Color.White;
            guna2ToggleSwitch1.CheckedState.InnerColor = Color.White;
            guna2ToggleSwitch1.CustomizableEdges = customizableEdges1;
            guna2ToggleSwitch1.Location = new Point(432, 36);
            guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            guna2ToggleSwitch1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ToggleSwitch1.Size = new Size(62, 27);
            guna2ToggleSwitch1.TabIndex = 1;
            guna2ToggleSwitch1.UncheckedState.BorderColor = Color.DarkOliveGreen;
            guna2ToggleSwitch1.UncheckedState.FillColor = Color.OliveDrab;
            guna2ToggleSwitch1.UncheckedState.InnerBorderColor = Color.White;
            guna2ToggleSwitch1.UncheckedState.InnerColor = Color.White;
            guna2ToggleSwitch1.CheckedChanged += guna2ToggleSwitch1_CheckedChanged;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(label9);
            guna2ShadowPanel1.Controls.Add(lblDinner);
            guna2ShadowPanel1.Controls.Add(lblOthers);
            guna2ShadowPanel1.Controls.Add(lblLunch);
            guna2ShadowPanel1.Controls.Add(lblBreakfast);
            guna2ShadowPanel1.Controls.Add(label7);
            guna2ShadowPanel1.Controls.Add(label5);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.Controls.Add(label1);
            guna2ShadowPanel1.FillColor = Color.PaleGoldenrod;
            guna2ShadowPanel1.Location = new Point(518, 72);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(394, 417);
            guna2ShadowPanel1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkOliveGreen;
            label9.Location = new Point(76, 32);
            label9.Name = "label9";
            label9.Size = new Size(249, 40);
            label9.TabIndex = 2;
            label9.Text = "Most Consumed ";
            // 
            // lblDinner
            // 
            lblDinner.AutoSize = true;
            lblDinner.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDinner.Location = new Point(145, 235);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(79, 29);
            lblDinner.TabIndex = 1;
            lblDinner.Text = "label2";
            // 
            // lblOthers
            // 
            lblOthers.AutoSize = true;
            lblOthers.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblOthers.Location = new Point(145, 289);
            lblOthers.Name = "lblOthers";
            lblOthers.Size = new Size(79, 29);
            lblOthers.TabIndex = 1;
            lblOthers.Text = "label2";
            // 
            // lblLunch
            // 
            lblLunch.AutoSize = true;
            lblLunch.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLunch.Location = new Point(145, 182);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new Size(79, 29);
            lblLunch.TabIndex = 1;
            lblLunch.Text = "label2";
            // 
            // lblBreakfast
            // 
            lblBreakfast.AutoSize = true;
            lblBreakfast.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblBreakfast.Location = new Point(176, 131);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(79, 29);
            lblBreakfast.TabIndex = 1;
            lblBreakfast.Text = "label2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Olive;
            label7.Location = new Point(35, 235);
            label7.Name = "label7";
            label7.Size = new Size(104, 29);
            label7.TabIndex = 0;
            label7.Text = "Dinner :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Olive;
            label5.Location = new Point(34, 289);
            label5.Name = "label5";
            label5.Size = new Size(105, 29);
            label5.TabIndex = 0;
            label5.Text = "Others :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Olive;
            label3.Location = new Point(35, 182);
            label3.Name = "label3";
            label3.Size = new Size(96, 29);
            label3.TabIndex = 0;
            label3.Text = "Lunch :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(34, 131);
            label1.Name = "label1";
            label1.Size = new Size(136, 29);
            label1.TabIndex = 0;
            label1.Text = "Breakfast :";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.DarkGreen;
            guna2HtmlLabel1.Location = new Point(332, 39);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(81, 24);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "My/Users";
            // 
            // chartMealForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(924, 600);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(guna2ToggleSwitch1);
            Controls.Add(mealChart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "chartMealForm";
            Text = "chartMealForm";
            Load += chartMealForm_Load;
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.Charts.WinForms.GunaChart mealChart;
        private Guna.Charts.WinForms.GunaPieDataset pieMeall;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label label9;
        private Label lblDinner;
        private Label lblOthers;
        private Label lblLunch;
        private Label lblBreakfast;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}