using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_6_NUM_
{
    public partial class Form1 : Form
    {
        double x = 0;
        double y = 0;
        double y_class = 0;
        double y_impr = 0;

        double a = 0;
        double b = 0;
        double h = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            y_class = Convert.ToDouble(tb_y0.Text);
            y_impr = y_class;
            a = Convert.ToDouble(tb_a.Text);
            b = Convert.ToDouble(tb_b.Text);
            h = Convert.ToDouble(tb_h.Text);           
            double initX = Convert.ToDouble(tb_x0.Text);

            for (x = initX; x <= b; x += h)
            {
                chart1.Series[0].Points.AddXY(x, y_class);
                chart1.Series[1].Points.AddXY(x, y_impr);
                y_class = EulerMethod(x, y_class);
                y_impr = ImprovedEyler(x, y_impr);
            }

            OutputValues();
        }

        double EulerMethod(double x, double y)
        {
            double diff_coeff = 0.5 - 0.2 * (x) - (0.5 * Math.Pow(x,2));
            double y_1 = y + h * diff_coeff;
            return y_1;
        }

        double ImprovedEyler(double x, double y)
        {
            double diff_coeff = 0.5 - 0.2 * x - (0.5 * Math.Pow(x, 2));
            double diff_coeff2 = 0.5 - 0.2 * (x + h) - (0.5 * Math.Pow(x + h, 2));
            double y_1 = y + h * ((diff_coeff + diff_coeff2) / 2);
            return y_1;
        }

        void OutputValues()
        {
            for (int i = 0; i < chart1.Series[1].Points.Count; i++)
            {
                rtb_x.Text += $"x{i} = " + Math.Round(chart1.Series[0].Points[i].XValue, 2).ToString() + "\n";
                rtb_Euler.Text += $"y{i} = " + Math.Round(chart1.Series[0].Points[i].YValues[0], 4).ToString() + "\n";
                rtb_ModEuler.Text += $"y{i} = " + Math.Round(chart1.Series[1].Points[i].YValues[0], 4).ToString() + "\n";
            }
        }




    }
}
