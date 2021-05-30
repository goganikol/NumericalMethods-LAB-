using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2_NUM_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0;
        double a = 0;
        double b = 0;
        double dX;

        public double trapezoidalRule(double dX, double a, double b, int n)
        {
            double result = 0;
            double x = 0;

            for (int i = 1; i < n; i++)
            {
                x = a + i * dX;
                result += 2 * (3 + (x * 2) - Math.Cos(Math.Pow(x, 3)));
            }

            x = a;
            result += 3 + (x * 2) - Math.Cos(Math.Pow(x, 3)); ;
            x = b;
            result += 3 + (x * 2) - Math.Cos(Math.Pow(x, 3)); ;

            result = result * dX / 2;
            return result;
        }

        public double simpsonsRule(double dX, double a, double b, int n)
        {
            double result = 0;
            double x = 0;
            double evenXSum = 0;
            double oddXSum = 0;

            for (int i = 1; i < n; i += 2)
            {
                x = a + i * dX;
                oddXSum += 4 * (3 + (x * 2) - Math.Cos(Math.Pow(x, 3)));
            }

            for (int i = 2; i < n - 1; i += 2)
            {
                x = a + i * dX;
                evenXSum += 2 * (3 + (x * 2) - Math.Cos(Math.Pow(x, 3)));
            }

            result = evenXSum + oddXSum;

            x = a;
            result += 3 + (x * 2) - Math.Cos(Math.Pow(x, 3));
            x = b;
            result += 3 + (x * 2) - Math.Cos(Math.Pow(x, 3));

            result = result * dX / 3;
            return result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tb_a.Text);
            b = Convert.ToDouble(tb_b.Text);
            n = Convert.ToInt32(tb_n.Text);
            dX = (b - a) / n;

            double trapezResult = trapezoidalRule(dX, a, b, n);
            trapezoidalTb.Text = Convert.ToString(Math.Round(trapezResult, 10));

            double simpsonResult = simpsonsRule(dX, a, b, n);
            simpsonsTb.Text = Convert.ToString(Math.Round(simpsonResult, 10));

            double difference = trapezResult - simpsonResult;
            differenceTb.Text = Convert.ToString(Math.Round((decimal)difference, 10));

            double error = Math.Abs(difference / simpsonResult);
            errorTb.Text = Convert.ToString(Math.Round((decimal)error, 10));
        }
    }
}

