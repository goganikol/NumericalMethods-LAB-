using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_7_NUM_
{
    public partial class Form1 : Form
    {
        double x, y, a, b, h;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            double a_init = Convert.ToDouble(tb_A.Text), y_i;
            int i = 0;

            b = Convert.ToDouble(tb_B.Text);
            x = Convert.ToDouble(tb_X0.Text);
            y = Convert.ToDouble(tb_Y0.Text);
            h = Convert.ToDouble(tb_h.Text);

            chart1.Series[0].Points.AddXY(x, y);
            OutputToTable(i);

            for (a = a_init; a < b; a += h)
            {
                i++;
                y_i = RungeKutta();
                x += h;
                y = y_i;
                chart1.Series[0].Points.AddXY(x, y);
                OutputToTable(i);
            }
        }

        public void OutputToTable(int i)
        {
            dataGridView1.Rows.Add();

            dataGridView1.Rows[i].Cells[0].Value = i;
            dataGridView1.Rows[i].Cells[1].Value = x;
            dataGridView1.Rows[i].Cells[2].Value = Math.Round(y, 4);
        }

        public double RungeKutta()
        {
            double q1, q2, q3, q4;

            q1 = h * (1 + y/x);
            q2 = h * (1 + (y + q1 / 2)/(x + h / 2));
            q3 = h * (1 + (y + q2 / 2)/(x + h / 2));
            q4 = h * (1 + (y + q3)/(x + h));

            return y + ((q1 + 2 * q2 + 2 * q3 + q4) / 6);
        }

    }
}
