
namespace BD_apstrade
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textTr1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextFileName = new System.Windows.Forms.TextBox();
            this.ReadData = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.TextNobide = new System.Windows.Forms.TextBox();
            this.Normet = new System.Windows.Forms.Button();
            this.DataFit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textC1 = new System.Windows.Forms.TextBox();
            this.textTf1 = new System.Windows.Forms.TextBox();
            this.DrawFitFunc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textC2 = new System.Windows.Forms.TextBox();
            this.textTf2 = new System.Windows.Forms.TextBox();
            this.textTr2 = new System.Windows.Forms.TextBox();
            this.textC3 = new System.Windows.Forms.TextBox();
            this.textTf3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textTr1
            // 
            this.textTr1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textTr1.Location = new System.Drawing.Point(41, 211);
            this.textTr1.Name = "textTr1";
            this.textTr1.Size = new System.Drawing.Size(46, 20);
            this.textTr1.TabIndex = 15;
            this.textTr1.Text = "0.03";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faila nosaukums:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datu ielasīšana";
            // 
            // TextFileName
            // 
            this.TextFileName.Location = new System.Drawing.Point(107, 31);
            this.TextFileName.Name = "TextFileName";
            this.TextFileName.Size = new System.Drawing.Size(100, 20);
            this.TextFileName.TabIndex = 2;
            // 
            // ReadData
            // 
            this.ReadData.Location = new System.Drawing.Point(12, 89);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(75, 23);
            this.ReadData.TabIndex = 3;
            this.ReadData.Text = "Ielasīt";
            this.ReadData.UseVisualStyleBackColor = true;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(265, 31);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Series2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Series3";
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(512, 249);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nobīde:";
            // 
            // TextNobide
            // 
            this.TextNobide.Location = new System.Drawing.Point(107, 58);
            this.TextNobide.Name = "TextNobide";
            this.TextNobide.Size = new System.Drawing.Size(100, 20);
            this.TextNobide.TabIndex = 6;
            this.TextNobide.Text = "0";
            // 
            // Normet
            // 
            this.Normet.Location = new System.Drawing.Point(132, 89);
            this.Normet.Name = "Normet";
            this.Normet.Size = new System.Drawing.Size(75, 24);
            this.Normet.TabIndex = 7;
            this.Normet.Text = "Normēt";
            this.Normet.UseVisualStyleBackColor = true;
            this.Normet.Click += new System.EventHandler(this.Normet_Click);
            // 
            // DataFit
            // 
            this.DataFit.Location = new System.Drawing.Point(107, 238);
            this.DataFit.Name = "DataFit";
            this.DataFit.Size = new System.Drawing.Size(73, 21);
            this.DataFit.TabIndex = 8;
            this.DataFit.Text = "Aprekins";
            this.DataFit.UseVisualStyleBackColor = true;
            this.DataFit.Click += new System.EventHandler(this.DataFit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datu Apstrāde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "t fall:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "t rise:";
            // 
            // textC1
            // 
            this.textC1.Location = new System.Drawing.Point(41, 159);
            this.textC1.Name = "textC1";
            this.textC1.Size = new System.Drawing.Size(46, 20);
            this.textC1.TabIndex = 13;
            this.textC1.Text = "0.5";
            // 
            // textTf1
            // 
            this.textTf1.Location = new System.Drawing.Point(41, 185);
            this.textTf1.Name = "textTf1";
            this.textTf1.Size = new System.Drawing.Size(46, 20);
            this.textTf1.TabIndex = 14;
            this.textTf1.Text = "0.5";
            // 
            // DrawFitFunc
            // 
            this.DrawFitFunc.Location = new System.Drawing.Point(12, 237);
            this.DrawFitFunc.Name = "DrawFitFunc";
            this.DrawFitFunc.Size = new System.Drawing.Size(75, 23);
            this.DrawFitFunc.TabIndex = 16;
            this.DrawFitFunc.Text = "Zimet";
            this.DrawFitFunc.UseVisualStyleBackColor = true;
            this.DrawFitFunc.Click += new System.EventHandler(this.DrawFitFunc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "I";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "II";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "III";
            // 
            // textC2
            // 
            this.textC2.Location = new System.Drawing.Point(116, 159);
            this.textC2.Name = "textC2";
            this.textC2.Size = new System.Drawing.Size(46, 20);
            this.textC2.TabIndex = 20;
            this.textC2.Text = "50";
            // 
            // textTf2
            // 
            this.textTf2.Location = new System.Drawing.Point(116, 185);
            this.textTf2.Name = "textTf2";
            this.textTf2.Size = new System.Drawing.Size(46, 20);
            this.textTf2.TabIndex = 21;
            this.textTf2.Text = "0.03";
            // 
            // textTr2
            // 
            this.textTr2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.textTr2.Location = new System.Drawing.Point(116, 211);
            this.textTr2.Name = "textTr2";
            this.textTr2.Size = new System.Drawing.Size(46, 20);
            this.textTr2.TabIndex = 22;
            this.textTr2.Text = "0.4";
            // 
            // textC3
            // 
            this.textC3.Location = new System.Drawing.Point(181, 159);
            this.textC3.Name = "textC3";
            this.textC3.Size = new System.Drawing.Size(46, 20);
            this.textC3.TabIndex = 23;
            this.textC3.Text = "0";
            // 
            // textTf3
            // 
            this.textTf3.Location = new System.Drawing.Point(181, 185);
            this.textTf3.Name = "textTf3";
            this.textTf3.Size = new System.Drawing.Size(46, 20);
            this.textTf3.TabIndex = 24;
            this.textTf3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTf3);
            this.Controls.Add(this.textC3);
            this.Controls.Add(this.textTr2);
            this.Controls.Add(this.textTf2);
            this.Controls.Add(this.textC2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DrawFitFunc);
            this.Controls.Add(this.textTr1);
            this.Controls.Add(this.textTf1);
            this.Controls.Add(this.textC1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataFit);
            this.Controls.Add(this.Normet);
            this.Controls.Add(this.TextNobide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ReadData);
            this.Controls.Add(this.TextFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextFileName;
        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextNobide;
        private System.Windows.Forms.Button Normet;
        private System.Windows.Forms.Button DataFit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textC1;
        private System.Windows.Forms.TextBox textTf1;
        private System.Windows.Forms.Button DrawFitFunc;
        private System.Windows.Forms.TextBox textTr1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textC2;
        private System.Windows.Forms.TextBox textTf2;
        private System.Windows.Forms.TextBox textTr2;
        private System.Windows.Forms.TextBox textC3;
        private System.Windows.Forms.TextBox textTf3;
    }
}

