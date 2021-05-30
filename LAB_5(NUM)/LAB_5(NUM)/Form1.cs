using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_5_NUM_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MaxIter = 70;
        double A = 0;
        double B = 0;
        double C = 0;
        double L = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Clean();
            double step = Convert.ToDouble(tb_Step.Text);
            double accuracy = Convert.ToDouble(tb_Accuracy.Text);

            int rootCounter = 0;

            double x0 = 0;
            double x1 = 0;

            double yStart = 0;
            double yMedium = 0;
            double yEnd = 0;

            for (double i = 0; i <= 25; i += step)
            {
                x0 = x1;
                x1 = i;

                yStart = Math.Sin(A * x0) + Math.Sin(B * x0) + Math.Sin(C * x0) - L;
                yEnd = Math.Sin(A * x1) + Math.Sin(B * x1) + Math.Sin(C * x1) - L;

                if (yStart * yEnd <= 0)
                {
                    double? result = Bisection(x0, x1, accuracy);
                    if (result != null)
                    {
                        chart1.Series[2].Points.AddXY(result, L);
                        tb_Roots.Text += (Math.Round((double)result, 4)).ToString() + "\n";
                        rootCounter++;
                    }
                }
            }

            tb_NumOfRoots.Text = rootCounter.ToString();
        }

        double? Bisection(double x0, double x1, double accuracy)
        {
            int counter = 0;
            double xMedium = 0;

            double func_At_A = 0;
            double func_At_B = 0;
            double func_At_C = 0;

            while (counter < MaxIter)
            {
                xMedium = (x0 + x1) / 2;

                func_At_A = Math.Sin(A * x0) + Math.Sin(B * x0) + Math.Sin(C * x0) - L;
                func_At_B = Math.Sin(A * x1) + Math.Sin(B * x1) + Math.Sin(C * x1) - L;
                func_At_C = Math.Sin(A * xMedium) + Math.Sin(B * xMedium) + Math.Sin(C * xMedium) - L;

                if (func_At_A * func_At_C <= 0)
                {
                    x1 = xMedium;
                }
                else
                {
                    x0 = xMedium;
                }

                if (Math.Abs(x0 - x1) <= accuracy)
                {
                    return (x0 + x1) / 2;
                }
            }

            return null;
        }

        void Clean()
        {
            chart1.Series[2].Points.Clear();
            tb_NumOfRoots.Text = String.Empty;
            tb_Roots.Text = String.Empty;
        }

        void ClearChart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearChart();

            A = Convert.ToDouble(tb_A.Text);
            B = Convert.ToDouble(tb_B.Text);
            C = Convert.ToDouble(tb_C.Text);
            L = Convert.ToDouble(tb_L.Text);

            double t = 0;
            double y = 0;
            for (t = 0; t <= 25; t += 0.05)
            {
                y = Math.Sin(A * t) + Math.Sin(B * t) + Math.Sin(C * t);
                chart1.Series[0].Points.AddXY(t, y);
            }
            for (t = 0; t <= 25; t += 5)
            {
                chart1.Series[1].Points.AddXY(t, L);
            }

        }
    }
}

