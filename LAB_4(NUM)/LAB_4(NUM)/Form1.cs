using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_4_NUM_
{
    public partial class Form1 : Form
    {
        int MaxIter;
        int counter = 0;
        double a;
        double b;
        double c;

        double tolerance;

        double func_At_A;
        double func_At_B;
        double func_At_C;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            tolerance = Convert.ToDouble(textBoxTolerance.Text);
            MaxIter = Convert.ToInt32(textBoxMaxIter.Text);
      
            while (counter < MaxIter)
            {
                counter++;
                c = (a + b) / 2;
                func_At_A = Math.Pow(a,4) - (2*Math.Pow(a,3)) + a;
                func_At_B = Math.Pow(b, 4) - (2 * Math.Pow(b, 3)) + b;
                func_At_C = Math.Pow(c, 4) - (2 * Math.Pow(c, 3)) + c;
                if (func_At_A * func_At_C < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
                if (Math.Abs(a - b) <= tolerance)
                {
                    textBoxFrom.Text = Math.Round(a, 8).ToString();
                    textBoxTo.Text = Math.Round(b, 8).ToString();
                    textBoxIter.Text = counter.ToString();
                    counter = 0;
                    return;
                }
            }
            MessageBox.Show("Method failed!");
            counter = 0;
        }
    }
}
