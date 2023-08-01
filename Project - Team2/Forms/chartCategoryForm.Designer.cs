namespace Project___Team2.Forms
{
    partial class chartCategoryForm
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
            chategoryChart=new Guna.Charts.WinForms.GunaChart();
            pieCategoryy=new Guna.Charts.WinForms.GunaPieDataset();
            guna2ToggleSwitch1=new Guna.UI2.WinForms.Guna2ToggleSwitch();
            guna2ShadowPanel1=new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblBaslik=new Label();
            label9=new Label();
            label8=new Label();
            label7=new Label();
            label6=new Label();
            label5=new Label();
            label4=new Label();
            label3=new Label();
            label2=new Label();
            label1=new Label();
            guna2HtmlLabel1=new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // chategoryChart
            // 
            chategoryChart.BackColor=Color.White;
            chategoryChart.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] { pieCategoryy });
            chartFont1.FontName="Arial";
            chategoryChart.Legend.LabelFont=chartFont1;
            chategoryChart.Location=new Point(23, 57);
            chategoryChart.Name="chategoryChart";
            chategoryChart.Size=new Size(478, 431);
            chategoryChart.TabIndex=0;
            chartFont2.FontName="Arial";
            chartFont2.Size=12;
            chartFont2.Style=Guna.Charts.WinForms.ChartFontStyle.Bold;
            chategoryChart.Title.Font=chartFont2;
            chategoryChart.Title.ForeColor=Color.DarkOliveGreen;
            chategoryChart.Title.Text="Most Consumed Foods by Category";
            chartFont3.FontName="Arial";
            chategoryChart.Tooltips.BodyFont=chartFont3;
            chartFont4.FontName="Arial";
            chartFont4.Size=9;
            chartFont4.Style=Guna.Charts.WinForms.ChartFontStyle.Bold;
            chategoryChart.Tooltips.TitleFont=chartFont4;
            chategoryChart.XAxes.Display=false;
            chategoryChart.XAxes.GridLines=grid1;
            chartFont5.FontName="Arial";
            tick1.Font=chartFont5;
            chategoryChart.XAxes.Ticks=tick1;
            chategoryChart.YAxes.Display=false;
            chategoryChart.YAxes.GridLines=grid2;
            chartFont6.FontName="Arial";
            tick2.Font=chartFont6;
            chategoryChart.YAxes.Ticks=tick2;
            chategoryChart.ZAxes.Display=false;
            chategoryChart.ZAxes.GridLines=grid3;
            chartFont7.FontName="Arial";
            pointLabel1.Font=chartFont7;
            chategoryChart.ZAxes.PointLabels=pointLabel1;
            chartFont8.FontName="Arial";
            tick3.Font=chartFont8;
            chategoryChart.ZAxes.Ticks=tick3;
            // 
            // pieCategoryy
            // 
            pieCategoryy.Label="Pie1";
            pieCategoryy.TargetChart=chategoryChart;
            // 
            // guna2ToggleSwitch1
            // 
            guna2ToggleSwitch1.CheckedState.BorderColor=Color.DarkOrange;
            guna2ToggleSwitch1.CheckedState.FillColor=Color.Orange;
            guna2ToggleSwitch1.CheckedState.InnerBorderColor=Color.White;
            guna2ToggleSwitch1.CheckedState.InnerColor=Color.White;
            guna2ToggleSwitch1.CustomizableEdges=customizableEdges1;
            guna2ToggleSwitch1.Location=new Point(424, 25);
            guna2ToggleSwitch1.Name="guna2ToggleSwitch1";
            guna2ToggleSwitch1.ShadowDecoration.CustomizableEdges=customizableEdges2;
            guna2ToggleSwitch1.Size=new Size(66, 25);
            guna2ToggleSwitch1.TabIndex=1;
            guna2ToggleSwitch1.UncheckedState.BorderColor=Color.DarkOliveGreen;
            guna2ToggleSwitch1.UncheckedState.FillColor=Color.OliveDrab;
            guna2ToggleSwitch1.UncheckedState.InnerBorderColor=Color.White;
            guna2ToggleSwitch1.UncheckedState.InnerColor=Color.White;
            guna2ToggleSwitch1.CheckedChanged+=guna2ToggleSwitch1_CheckedChanged;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor=Color.Transparent;
            guna2ShadowPanel1.Controls.Add(lblBaslik);
            guna2ShadowPanel1.Controls.Add(label9);
            guna2ShadowPanel1.Controls.Add(label8);
            guna2ShadowPanel1.Controls.Add(label7);
            guna2ShadowPanel1.Controls.Add(label6);
            guna2ShadowPanel1.Controls.Add(label5);
            guna2ShadowPanel1.Controls.Add(label4);
            guna2ShadowPanel1.Controls.Add(label3);
            guna2ShadowPanel1.Controls.Add(label2);
            guna2ShadowPanel1.Controls.Add(label1);
            guna2ShadowPanel1.FillColor=Color.PaleGoldenrod;
            guna2ShadowPanel1.Location=new Point(536, 57);
            guna2ShadowPanel1.Name="guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor=Color.Black;
            guna2ShadowPanel1.Size=new Size(365, 431);
            guna2ShadowPanel1.TabIndex=2;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize=true;
            lblBaslik.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaslik.ForeColor=Color.OliveDrab;
            lblBaslik.Location=new Point(54, 17);
            lblBaslik.Name="lblBaslik";
            lblBaslik.Size=new Size(57, 19);
            lblBaslik.TabIndex=1;
            lblBaslik.Text="label10";
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Font=new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location=new Point(54, 379);
            label9.Name="label9";
            label9.Size=new Size(48, 20);
            label9.TabIndex=0;
            label9.Text="label1";
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Font=new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location=new Point(54, 339);
            label8.Name="label8";
            label8.Size=new Size(48, 20);
            label8.TabIndex=0;
            label8.Text="label1";
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Font=new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location=new Point(54, 299);
            label7.Name="label7";
            label7.Size=new Size(48, 20);
            label7.TabIndex=0;
            label7.Text="label1";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location=new Point(54, 258);
            label6.Name="label6";
            label6.Size=new Size(48, 20);
            label6.TabIndex=0;
            label6.Text="label1";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location=new Point(54, 214);
            label5.Name="label5";
            label5.Size=new Size(48, 20);
            label5.TabIndex=0;
            label5.Text="label1";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(54, 176);
            label4.Name="label4";
            label4.Size=new Size(48, 20);
            label4.TabIndex=0;
            label4.Text="label1";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(54, 140);
            label3.Name="label3";
            label3.Size=new Size(48, 20);
            label3.TabIndex=0;
            label3.Text="label1";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(54, 100);
            label2.Name="label2";
            label2.Size=new Size(48, 20);
            label2.TabIndex=0;
            label2.Text="label1";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(54, 60);
            label1.Name="label1";
            label1.Size=new Size(48, 20);
            label1.TabIndex=0;
            label1.Text="label1";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor=Color.Transparent;
            guna2HtmlLabel1.Font=new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor=Color.DarkGreen;
            guna2HtmlLabel1.Location=new Point(324, 25);
            guna2HtmlLabel1.Name="guna2HtmlLabel1";
            guna2HtmlLabel1.Size=new Size(81, 24);
            guna2HtmlLabel1.TabIndex=3;
            guna2HtmlLabel1.Text="My/Users";
            // 
            // chartCategoryForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.PaleGoldenrod;
            ClientSize=new Size(924, 600);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(guna2ToggleSwitch1);
            Controls.Add(chategoryChart);
            FormBorderStyle=FormBorderStyle.None;
            Name="chartCategoryForm";
            Text="chartCategoryForm";
            Load+=chartCategoryForm_Load;
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.Charts.WinForms.GunaDoughnutDataset pieCategory;
        private Guna.Charts.WinForms.GunaChart chategoryChart;
        private Guna.Charts.WinForms.GunaPieDataset pieCategoryy;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label lblBaslik;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}