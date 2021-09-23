using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using MathNet.Numerics;

namespace BD_apstrade
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class DataStorage
        {
            public double[] X_Data_G { get; set; }
            public double[] X_Diff_G { get; set; }
            public double[] Y_Diff_G { get; set; }
            public double[] Y_Diff_Fit { get; set; }
            public string[] Data_Raw { get; set; }
        }

        DataStorage DS = new DataStorage();
        private Thread _testThread = null;

        static double Exp(double x, double C_1, double t_f1, double t_r1, double C_2, double t_f2, double t_r2, double C_3, double t_f3)
        {
         
            if(x<0)
            {
                return 0;
            }
             return  C_1 * (1 - Math.Exp(-x / t_r1)) * Math.Exp(-x / t_f1)+ C_2 * (1 - Math.Exp(-x / t_r2)) * Math.Exp(-x / t_f2)+C_3 * Math.Exp(-x / t_f3);
           
        }

       public static (double P0, double P1, double P2, double P3, double P4, double P5, double P6, double P7) ExpFit(double[] X_Data, double[] Y_Data, double Guess1, double Guess2, double Guess3, double Guess4, double Guess5, double Guess6, double Guess7, double Guess8)
       {
            Func<double, double, double, double, double, double, double, double, double, double> FitFunc = Exp;
                   
            return BD_apstrade.FitFunc.Curve(X_Data, Y_Data, FitFunc, Guess1, Guess2, Guess3, Guess4, Guess5, Guess6, Guess7, Guess8, 1E-3, 10000);
        }

        public static ValueTuple<double[], double[], double[]> ConvertData(string[] line, double Offset)
        {
            int Col = line[0].Length;
            int Row = line.Length;
            double[] X_Data = new double[Row-1];
            double[] X_Diff = new double[Row-1];
            double[] Y_Diff = new double[Row-1];
            for (int c = 0; c < Col; c++)
            {
                for (int i = 0; i < Row-1; i++)
                {
                    string[] subs = line[i+1].Split(',');                                       
                    X_Data[i] = Convert.ToDouble(subs[0])-Offset;
                    X_Diff[i] = Convert.ToDouble(subs[1]);
                    Y_Diff[i] = Convert.ToDouble(subs[2]);
                }
            }
            return (X_Data, X_Diff, Y_Diff);
        }

        private void Plot_Data(double[] X, double[] X_Diff, double[] Y_Diff)
        {
            chart1.BeginInvoke(new Action(() =>
            {
                chart1.Series[0].Points.DataBindXY(X, X_Diff);
                chart1.Series[1].Points.DataBindXY(X, Y_Diff);
            }));
        }
             
        private void ReadData_Click(object sender, EventArgs e)
        {
            string FileName = TextFileName.Text;
                 
                string FilePath = string.Format(@"C:\Users\Arturs\Desktop\Darbs\Kodi\c#\BD_apstrade\{0}.txt", FileName);
                DS.Data_Raw = File.ReadAllLines(FilePath);
                (DS.X_Data_G, DS.X_Diff_G, DS.Y_Diff_G) = ConvertData(DS.Data_Raw, 0);
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                _testThread = new Thread(() => Plot_Data(DS.X_Data_G, DS.X_Diff_G, DS.Y_Diff_G));
                _testThread.Start();                
           
        }

        private void Normet_Click(object sender, EventArgs e)
        {
            double Offset;
            if (double.TryParse(TextNobide.Text, out Offset))
            {
                (DS.X_Data_G, DS.X_Diff_G, DS.Y_Diff_G) = ConvertData(DS.Data_Raw, Offset);
            }
            else
            {
                MessageBox.Show("could not convert Offset to number");
            }

            double XD_Avg=0;
            double YD_Avg=0;
            for (int i = 0; i < 10; i++)
            {
                XD_Avg = XD_Avg + DS.X_Diff_G[i];
                YD_Avg = YD_Avg + DS.Y_Diff_G[i];
            }
            XD_Avg = XD_Avg/10;
            YD_Avg = YD_Avg/10;
            int Leng = DS.X_Data_G.Length;
            for (int i = 0; i < Leng; i++)
            {
                DS.X_Diff_G[i] = -XD_Avg + DS.X_Diff_G[i];
                DS.Y_Diff_G[i] = -YD_Avg + DS.Y_Diff_G[i];
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            _testThread = new Thread(() => Plot_Data(DS.X_Data_G, DS.X_Diff_G, DS.Y_Diff_G));
            _testThread.Start();
        }

        private void DataFit_Click(object sender, EventArgs e)
        {
            int Leng = DS.X_Data_G.Length;
            double P1 = Convert.ToDouble(textC1.Text);
            double P2 = Convert.ToDouble(textTf1.Text);
            double P3 = Convert.ToDouble(textTr1.Text);
            double P4 = Convert.ToDouble(textC2.Text);
            double P5 = Convert.ToDouble(textTf2.Text);
            double P6 = Convert.ToDouble(textTr2.Text);
            double P7 = Convert.ToDouble(textC3.Text);
            double P8 = Convert.ToDouble(textTf3.Text);
            
            double[] FitData = new double[DS.X_Data_G.Length];
            (P1,P2,P3,P4,P5,P6,P7,P8) = ExpFit(DS.X_Data_G, DS.Y_Diff_G,P1,P2,P3,P4,P5,P6,P7,P8);
            for(int i = 0; i < DS.X_Data_G.Length; i++)
            {
                FitData[i] = Exp(DS.X_Data_G[i], P1, P2, P3, P4, P5, P6, P7, P8);
            }
            (textC1.Text, textTf1.Text, textTr1.Text, textC2.Text, textTf2.Text, textTr2.Text, textC3.Text, textTf3.Text) = (Convert.ToString(P1), Convert.ToString(P2), Convert.ToString(P3), Convert.ToString(P4), Convert.ToString(P5), Convert.ToString(P6), Convert.ToString(P7), Convert.ToString(P8));
            string te = Convert.ToString(FitData);
           

            chart1.Series[2].Points.Clear();        
           
            chart1.BeginInvoke(new Action(() =>
            {
                chart1.Series[2].Points.DataBindXY(DS.X_Data_G, FitData);
            }));
        }

        private void DrawFitFunc_Click(object sender, EventArgs e)
        {
            int Leng = DS.X_Data_G.Length;
            double P1 = Convert.ToDouble(textC1.Text);
            double P2 = Convert.ToDouble(textTf1.Text);
            double P3 = Convert.ToDouble(textTr1.Text);
            double P4 = Convert.ToDouble(textC2.Text);
            double P5 = Convert.ToDouble(textTf2.Text);
            double P6 = Convert.ToDouble(textTr2.Text);
            double P7 = Convert.ToDouble(textC3.Text);
            double P8 = Convert.ToDouble(textTf3.Text);
            double[] FitData = new double[DS.X_Data_G.Length];
            for (int i = 0; i < DS.X_Data_G.Length; i++)
            {
                FitData[i] = Exp(DS.X_Data_G[i], P1, P2, P3, P4, P5, P6, P7, P8);
            }
            
            chart1.Series[2].Points.Clear();
            chart1.BeginInvoke(new Action(() =>
            {
                chart1.Series[2].Points.DataBindXY(DS.X_Data_G, FitData);
            }));
        }


    }
}
