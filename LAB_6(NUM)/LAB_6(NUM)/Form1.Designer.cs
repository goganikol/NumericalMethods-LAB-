namespace LAB_6_NUM_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_x0 = new System.Windows.Forms.TextBox();
            this.tb_y0 = new System.Windows.Forms.TextBox();
            this.tb_h = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtb_x = new System.Windows.Forms.RichTextBox();
            this.rtb_Euler = new System.Windows.Forms.RichTextBox();
            this.rtb_ModEuler = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Euler";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Modified Euler";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(819, 408);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(34, 422);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(63, 20);
            this.tb_a.TabIndex = 1;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(172, 422);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(69, 20);
            this.tb_b.TabIndex = 2;
            // 
            // tb_x0
            // 
            this.tb_x0.Location = new System.Drawing.Point(320, 422);
            this.tb_x0.Name = "tb_x0";
            this.tb_x0.Size = new System.Drawing.Size(74, 20);
            this.tb_x0.TabIndex = 3;
            // 
            // tb_y0
            // 
            this.tb_y0.Location = new System.Drawing.Point(476, 422);
            this.tb_y0.Name = "tb_y0";
            this.tb_y0.Size = new System.Drawing.Size(78, 20);
            this.tb_y0.TabIndex = 4;
            // 
            // tb_h
            // 
            this.tb_h.Location = new System.Drawing.Point(638, 422);
            this.tb_h.Name = "tb_h";
            this.tb_h.Size = new System.Drawing.Size(69, 20);
            this.tb_h.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "x0 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "y0 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "h =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(938, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Euler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(997, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Modified Euler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb_x
            // 
            this.rtb_x.Location = new System.Drawing.Point(826, 40);
            this.rtb_x.Name = "rtb_x";
            this.rtb_x.Size = new System.Drawing.Size(82, 368);
            this.rtb_x.TabIndex = 15;
            this.rtb_x.Text = "";
            // 
            // rtb_Euler
            // 
            this.rtb_Euler.Location = new System.Drawing.Point(915, 40);
            this.rtb_Euler.Name = "rtb_Euler";
            this.rtb_Euler.Size = new System.Drawing.Size(79, 368);
            this.rtb_Euler.TabIndex = 16;
            this.rtb_Euler.Text = "";
            // 
            // rtb_ModEuler
            // 
            this.rtb_ModEuler.Location = new System.Drawing.Point(1000, 40);
            this.rtb_ModEuler.Name = "rtb_ModEuler";
            this.rtb_ModEuler.Size = new System.Drawing.Size(76, 368);
            this.rtb_ModEuler.TabIndex = 17;
            this.rtb_ModEuler.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 454);
            this.Controls.Add(this.rtb_ModEuler);
            this.Controls.Add(this.rtb_Euler);
            this.Controls.Add(this.rtb_x);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_h);
            this.Controls.Add(this.tb_y0);
            this.Controls.Add(this.tb_x0);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_x0;
        private System.Windows.Forms.TextBox tb_y0;
        private System.Windows.Forms.TextBox tb_h;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb_x;
        private System.Windows.Forms.RichTextBox rtb_Euler;
        private System.Windows.Forms.RichTextBox rtb_ModEuler;
    }
}

