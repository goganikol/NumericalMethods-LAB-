using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_1_NUM_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(6);
            dataGridView1.Rows[0].Cells[0].Value = "3-Point Procedure";
            dataGridView1.Rows[1].Cells[0].Value = "4-Point Procedure A";
            dataGridView1.Rows[2].Cells[0].Value = "4-Point Procedure B";
            dataGridView1.Rows[3].Cells[0].Value = "5-Point Procedure A";
            dataGridView1.Rows[4].Cells[0].Value = "5-Point Procedure B";
            dataGridView1.Rows[5].Cells[0].Value = "5-Point Procedure C";
            dataGridView1.Rows[6].Cells[0].Value = "2nd Derivative Procedure";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox_x.Text);
            double h = Convert.ToDouble(textBox_h.Text);

            double xMinus1 = x - h;
            double xMinus2 = x - 2 * h;
            double xPlus1 = x + h;
            double xPlus2 = x + 2 * h;
            double xPlus3 = x + 3 * h;
            double xPlus4 = x + 4 * h;

            double result = threePoint(xPlus1, xMinus1, h);
            dataGridView1.Rows[0].Cells[1].Value = Convert.ToString(Math.Round(result, 8));

            result = fourPointA(xMinus1, x, xPlus1, xPlus2, h);
            dataGridView1.Rows[1].Cells[1].Value = Convert.ToString(Math.Round(result, 8));

            result = fourPointB(x, xPlus1, xPlus2, xPlus3, h);
            dataGridView1.Rows[2].Cells[1].Value = Convert.ToString(Math.Round(result, 8));

            result = fivePointA(xMinus2, xMinus1, xPlus1, xPlus2, h);
            dataGridView1.Rows[3].Cells[1].Value = Convert.ToString(Math.Round(result, 8));

            result = fivePointB(xMinus1, x, xPlus1, xPlus2, xPlus3, h);
            dataGridView1.Rows[4].Cells[1].Value = Convert.ToString(Math.Round(result, 8));

            result = fivePointC(x, xPlus1, xPlus2, xPlus3, xPlus4, h);
            dataGridView1.Rows[5].Cells[1].Value = Convert.ToString(Math.Round(result, 8));

            result = secondDerivative(xMinus1, x, xPlus1, h);
            dataGridView1.Rows[6].Cells[1].Value = Convert.ToString(Math.Round(result, 8));


            for (int i = 0; i < 6; i++)
            {
                double val = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                if (val < 0)
                    dataGridView1.Rows[i].Cells[2].Value = "Descending";
                else
                    dataGridView1.Rows[i].Cells[2].Value = "Ascending";
            }

            if (Convert.ToDouble(dataGridView1.Rows[6].Cells[1].Value) > 0)
                dataGridView1.Rows[6].Cells[2].Value = "Concave Up";
            else
                dataGridView1.Rows[6].Cells[2].Value = "Concave Down";
        }

        public double threePoint(double xPlus1, double xMinus1, double h)
        {
            double y1 = 3 + (xPlus1 * 2) - Math.Cos(Math.Pow(xPlus1, 3));
            double y2 = 3 + (xMinus1 * 2) - Math.Cos(Math.Pow(xMinus1, 3));

            double res = y1 - y2;
            return (y1 - y2) / (2 * h);
        }

        public double fourPointA(double xMinus1, double x, double xPlus1, double xPlus2, double h)
        {
            double y1 = 3 + (xMinus1 * 2) - Math.Cos(Math.Pow(xMinus1, 3));
            double y2 = 3 + (x * 2) - Math.Cos(Math.Pow(x, 3));
            double y3 = 3 + (xPlus1 * 2) - Math.Cos(Math.Pow(xPlus1, 3));
            double y4 = 3 + (xPlus2 * 2) - Math.Cos(Math.Pow(xPlus2, 3));

            double result = -2 * y1 - 3 * y2 + 6 * y3 - y4;

            return result / (6 * h);
        }

        public double fourPointB(double x, double xPlus1, double xPlus2, double xPlus3, double h)
        {
            double y1 = 3 + (x * 2) - Math.Cos(Math.Pow(x, 3));
            double y2 = 3 + (xPlus1 * 2) - Math.Cos(Math.Pow(xPlus1, 3));
            double y3 = 3 + (xPlus2 * 2) - Math.Cos(Math.Pow(xPlus2, 3));
            double y4 = 3 + (xPlus3 * 2) - Math.Cos(Math.Pow(xPlus3, 3));

            return (-11 * y1 + 18 * y2 - 9 * y3 + 2 * y4) / (6 * h);
        }

        public double fivePointA(double xMinus2, double xMinus1, double xPlus1, double xPlus2, double h)
        {
            double y1 = 3 + (xMinus2 * 2) - Math.Cos(Math.Pow(xMinus2, 3));
            double y2 = 3 + (xMinus1 * 2) - Math.Cos(Math.Pow(xMinus1, 3));
            double y3 = 3 + (xPlus1 * 2) - Math.Cos(Math.Pow(xPlus1, 3));
            double y4 = 3 + (xPlus2 * 2) - Math.Cos(Math.Pow(xPlus2, 3));

            return (y1 - 8 * y2 + 8 * y3 - y4) / (12 * h);

        }

        public double fivePointB(double xMinus1, double x, double xPlus1, double xPlus2, double xPlus3, double h)
        {
            double y1 = 3 + (xMinus1 * 2) - Math.Cos(Math.Pow(xMinus1, 3));
            double y2 = 3 + (x * 2) - Math.Cos(Math.Pow(x, 3));
            double y3 = 3 + (xPlus1 * 2) - Math.Cos(Math.Pow(xPlus1, 3));
            double y4 = 3 + (xPlus2 * 2) - Math.Cos(Math.Pow(xPlus2, 3));
            double y5 = 3 + (xPlus3 * 2) - Math.Cos(Math.Pow(xPlus3, 3));

            return (-3 * y1 - 10 * y2 + 18 * y3 - 6 * y4 + y5) / (12 * h);
        }

        public double fivePointC(double x, double xPlus1, double xPlus2, double xPlus3, double xPlus4, double h)
        {
            double y1 = 3 + (x * 2) - Math.Cos(Math.Pow(x, 3));
            double y2 = 3 + (xPlus1 * 2) - Math.Cos(Math.Pow(xPlus1, 3));
            double y3 = 3 + (xPlus2 * 2) - Math.Cos(Math.Pow(xPlus2, 3));
            double y4 = 3 + (xPlus3 * 2) - Math.Cos(Math.Pow(xPlus3, 3));
            double y5 = 3 + (xPlus4 * 2) - Math.Cos(Math.Pow(xPlus4, 3));

            return (-25 * y1 + 48 * y2 - 36 * y3 + 16 * y4 - 3 * y5) / (12 * h);
        }

        public double secondDerivative(double xMinus1, double x, double xPlus1, double h)
        {
            double y1 = 3 + (xPlus1 * 2) - Math.Cos(Math.Pow(xPlus1, 3));
            double y3 = 3 + (xMinus1 * 2) - Math.Cos(Math.Pow(xMinus1, 3));
            double y2 = 3 + (x * 2) - Math.Cos(Math.Pow(x, 3));


            return (y1 - 2 * y2 + y3) / Math.Pow(h, 2);
        }


    }
}

