using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_3_NUM_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            drawFunction();
        }

        public void drawFunction()
        {

            double x = 0;
            double y = 0;
            int index = 0;

            for (x = 0.5; x <= 3.5; x += 0.005d)
            {
                x = Math.Round(x, 3);
                y = x + Math.Sqrt((2 * Math.Pow(x,2)) + 3);
                this.chart1.Series[0].Points.AddXY(x, y);
                index++;
            }
        }

        public double MonteCarlo(int n)
        {
            PointF[] randPoints = new PointF[n];
            Random rand = new Random();
            double hits = 0;
            float yValue = 0;

            for (int i = 0; i < n; i++)
            {
                randPoints[i].X = (float)rand.NextDouble();

                yValue = (float)(rand.Next(0,480000));
                randPoints[i].Y = yValue/1000000 ;
            }

            yValue = 0;

            for (int i = 0; i < n; i++)
            {
                double funcResult = randPoints[i].X + Math.Sqrt((2 * Math.Pow(randPoints[i].X, 2)) + 3);
                //x + Math.Sqrt((2 * Math.Pow(x,2)) + 3)
                yValue = (float)funcResult;
                if (randPoints[i].Y <= yValue)
                {
                    hits++;
                    if (i % 15 == 0)
                    {
                        chart1.Series[1].Points.AddXY(randPoints[i].X, randPoints[i].Y);
                    }
                }
                else
                {
                    if (i % 15 == 0)
                    {
                        chart1.Series[2].Points.AddXY(randPoints[i].X, randPoints[i].Y);
                    }
                }
            }

            double area = hits / n;
            double boxArea = 1 * 0.48;
            return area * boxArea;
        }


        public double CalculateDeltaS()
        {
            double sum = 0;
            double averS = Convert.ToDouble(textBox2.Text);
            double S = 0;
            double standartDev = 0;
            for (int i = 0; i < 5; i++)
            {
                S = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);

                sum += Math.Pow(S, 2) - Math.Pow(averS, 2);

            }
            standartDev = Math.Sqrt(sum / 4);
            double deltaS = (2.5706 * standartDev) / Math.Sqrt(5);
            return deltaS;
        }

        int trialCounter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            double result = 0;
            result = MonteCarlo(n);
            dataGridView1.Rows.Add();
            dataGridView1.Rows[trialCounter].Cells[0].Value = trialCounter + 1;
            dataGridView1.Rows[trialCounter].Cells[1].Value = result;
            trialCounter++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double aver = 0;
            for (int i = 0; i < 5; i++)
            {
                aver += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            aver = aver / 5;
            textBox2.Text = aver.ToString();

            double deltaS = CalculateDeltaS();
            deltaS = Math.Round(deltaS, 8);

            textBox3.Text = deltaS.ToString();
            textBox4.Text = (aver - deltaS).ToString();
            textBox5.Text = (aver + deltaS).ToString();

        }
    }
}
