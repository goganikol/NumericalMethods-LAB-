namespace LAB_2_NUM_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_n = new System.Windows.Forms.TextBox();
            this.trapezoidalTb = new System.Windows.Forms.TextBox();
            this.simpsonsTb = new System.Windows.Forms.TextBox();
            this.differenceTb = new System.Windows.Forms.TextBox();
            this.errorTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a = ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "n = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trapezoidal rule";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Difference";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Simpson\'s rule";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Error";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(106, 64);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(78, 20);
            this.tb_a.TabIndex = 7;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(255, 65);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(89, 20);
            this.tb_b.TabIndex = 8;
            // 
            // tb_n
            // 
            this.tb_n.Location = new System.Drawing.Point(406, 65);
            this.tb_n.Name = "tb_n";
            this.tb_n.Size = new System.Drawing.Size(100, 20);
            this.tb_n.TabIndex = 9;
            // 
            // trapezoidalTb
            // 
            this.trapezoidalTb.Location = new System.Drawing.Point(166, 152);
            this.trapezoidalTb.Name = "trapezoidalTb";
            this.trapezoidalTb.Size = new System.Drawing.Size(100, 20);
            this.trapezoidalTb.TabIndex = 10;
            // 
            // simpsonsTb
            // 
            this.simpsonsTb.Location = new System.Drawing.Point(406, 152);
            this.simpsonsTb.Name = "simpsonsTb";
            this.simpsonsTb.Size = new System.Drawing.Size(100, 20);
            this.simpsonsTb.TabIndex = 11;
            // 
            // differenceTb
            // 
            this.differenceTb.Location = new System.Drawing.Point(166, 228);
            this.differenceTb.Name = "differenceTb";
            this.differenceTb.Size = new System.Drawing.Size(100, 20);
            this.differenceTb.TabIndex = 12;
            // 
            // errorTb
            // 
            this.errorTb.Location = new System.Drawing.Point(406, 232);
            this.errorTb.Name = "errorTb";
            this.errorTb.Size = new System.Drawing.Size(100, 20);
            this.errorTb.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorTb);
            this.Controls.Add(this.differenceTb);
            this.Controls.Add(this.simpsonsTb);
            this.Controls.Add(this.trapezoidalTb);
            this.Controls.Add(this.tb_n);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_n;
        private System.Windows.Forms.TextBox trapezoidalTb;
        private System.Windows.Forms.TextBox simpsonsTb;
        private System.Windows.Forms.TextBox differenceTb;
        private System.Windows.Forms.TextBox errorTb;
        private System.Windows.Forms.Button button1;
    }
}

