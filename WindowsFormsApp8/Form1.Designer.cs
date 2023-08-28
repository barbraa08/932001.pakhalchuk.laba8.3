namespace WindowsFormsApp8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btAnswer = new System.Windows.Forms.Button();
            this.btAnswer2 = new System.Windows.Forms.Button();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.lbAnswer2 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbQuestion2 = new System.Windows.Forms.TextBox();
            this.lb8_1 = new System.Windows.Forms.Label();
            this.lb8_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbProb1 = new System.Windows.Forms.Label();
            this.lbProb2 = new System.Windows.Forms.Label();
            this.lbProb3 = new System.Windows.Forms.Label();
            this.lbProb4 = new System.Windows.Forms.Label();
            this.lbProb5 = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.btAnswer3 = new System.Windows.Forms.Button();
            this.tbProb1 = new System.Windows.Forms.NumericUpDown();
            this.tbProb2 = new System.Windows.Forms.NumericUpDown();
            this.tbProb3 = new System.Windows.Forms.NumericUpDown();
            this.tbProb4 = new System.Windows.Forms.NumericUpDown();
            this.tbNum = new System.Windows.Forms.NumericUpDown();
            this.tbProb5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btAnswer
            // 
            this.btAnswer.Location = new System.Drawing.Point(142, 168);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(97, 45);
            this.btAnswer.TabIndex = 0;
            this.btAnswer.Text = "Answer";
            this.btAnswer.UseVisualStyleBackColor = true;
            this.btAnswer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAnswer2
            // 
            this.btAnswer2.Location = new System.Drawing.Point(705, 168);
            this.btAnswer2.Name = "btAnswer2";
            this.btAnswer2.Size = new System.Drawing.Size(96, 44);
            this.btAnswer2.TabIndex = 1;
            this.btAnswer2.Text = "Answer";
            this.btAnswer2.UseVisualStyleBackColor = true;
            this.btAnswer2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(138, 239);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(0, 20);
            this.lbAnswer.TabIndex = 2;
            // 
            // lbAnswer2
            // 
            this.lbAnswer2.AutoSize = true;
            this.lbAnswer2.Location = new System.Drawing.Point(701, 239);
            this.lbAnswer2.Name = "lbAnswer2";
            this.lbAnswer2.Size = new System.Drawing.Size(0, 20);
            this.lbAnswer2.TabIndex = 3;
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(99, 73);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(199, 71);
            this.tbQuestion.TabIndex = 4;
            // 
            // tbQuestion2
            // 
            this.tbQuestion2.Location = new System.Drawing.Point(654, 73);
            this.tbQuestion2.Multiline = true;
            this.tbQuestion2.Name = "tbQuestion2";
            this.tbQuestion2.Size = new System.Drawing.Size(203, 71);
            this.tbQuestion2.TabIndex = 5;
            // 
            // lb8_1
            // 
            this.lb8_1.AutoSize = true;
            this.lb8_1.Location = new System.Drawing.Point(123, 32);
            this.lb8_1.Name = "lb8_1";
            this.lb8_1.Size = new System.Drawing.Size(152, 20);
            this.lb8_1.TabIndex = 6;
            this.lb8_1.Text = "Yes or No prediction";
            // 
            // lb8_2
            // 
            this.lb8_2.AutoSize = true;
            this.lb8_2.Location = new System.Drawing.Point(674, 32);
            this.lb8_2.Name = "lb8_2";
            this.lb8_2.Size = new System.Drawing.Size(152, 20);
            this.lb8_2.TabIndex = 7;
            this.lb8_2.Text = "Magic ball prediction";
            this.lb8_2.Click += new System.EventHandler(this.lb8_2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Events simulation based on the given probabilities";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(494, 336);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(547, 381);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // lbProb1
            // 
            this.lbProb1.AutoSize = true;
            this.lbProb1.Location = new System.Drawing.Point(57, 360);
            this.lbProb1.Name = "lbProb1";
            this.lbProb1.Size = new System.Drawing.Size(155, 20);
            this.lbProb1.TabIndex = 10;
            this.lbProb1.Text = "Probability of event 1";
            // 
            // lbProb2
            // 
            this.lbProb2.AutoSize = true;
            this.lbProb2.Location = new System.Drawing.Point(57, 402);
            this.lbProb2.Name = "lbProb2";
            this.lbProb2.Size = new System.Drawing.Size(155, 20);
            this.lbProb2.TabIndex = 11;
            this.lbProb2.Text = "Probability of event 2";
            // 
            // lbProb3
            // 
            this.lbProb3.AutoSize = true;
            this.lbProb3.Location = new System.Drawing.Point(57, 442);
            this.lbProb3.Name = "lbProb3";
            this.lbProb3.Size = new System.Drawing.Size(155, 20);
            this.lbProb3.TabIndex = 12;
            this.lbProb3.Text = "Probability of event 3";
            // 
            // lbProb4
            // 
            this.lbProb4.AutoSize = true;
            this.lbProb4.Location = new System.Drawing.Point(57, 482);
            this.lbProb4.Name = "lbProb4";
            this.lbProb4.Size = new System.Drawing.Size(155, 20);
            this.lbProb4.TabIndex = 13;
            this.lbProb4.Text = "Probability of event 4";
            // 
            // lbProb5
            // 
            this.lbProb5.AutoSize = true;
            this.lbProb5.Location = new System.Drawing.Point(57, 518);
            this.lbProb5.Name = "lbProb5";
            this.lbProb5.Size = new System.Drawing.Size(155, 20);
            this.lbProb5.TabIndex = 14;
            this.lbProb5.Text = "Probability of event 5";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(61, 595);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(134, 20);
            this.lbNum.TabIndex = 15;
            this.lbNum.Text = "Number of events";
            // 
            // btAnswer3
            // 
            this.btAnswer3.Location = new System.Drawing.Point(181, 652);
            this.btAnswer3.Name = "btAnswer3";
            this.btAnswer3.Size = new System.Drawing.Size(97, 47);
            this.btAnswer3.TabIndex = 16;
            this.btAnswer3.Text = "Show chart";
            this.btAnswer3.UseVisualStyleBackColor = true;
            this.btAnswer3.Click += new System.EventHandler(this.btAnswer3_Click);
            // 
            // tbProb1
            // 
            this.tbProb1.DecimalPlaces = 2;
            this.tbProb1.Location = new System.Drawing.Point(247, 358);
            this.tbProb1.Name = "tbProb1";
            this.tbProb1.Size = new System.Drawing.Size(120, 26);
            this.tbProb1.TabIndex = 17;
            this.tbProb1.Value = new decimal(new int[] {
            14,
            0,
            0,
            131072});
            // 
            // tbProb2
            // 
            this.tbProb2.DecimalPlaces = 2;
            this.tbProb2.Location = new System.Drawing.Point(247, 400);
            this.tbProb2.Name = "tbProb2";
            this.tbProb2.Size = new System.Drawing.Size(120, 26);
            this.tbProb2.TabIndex = 18;
            this.tbProb2.Value = new decimal(new int[] {
            21,
            0,
            0,
            131072});
            // 
            // tbProb3
            // 
            this.tbProb3.DecimalPlaces = 2;
            this.tbProb3.Location = new System.Drawing.Point(247, 440);
            this.tbProb3.Name = "tbProb3";
            this.tbProb3.Size = new System.Drawing.Size(120, 26);
            this.tbProb3.TabIndex = 19;
            this.tbProb3.Value = new decimal(new int[] {
            12,
            0,
            0,
            131072});
            // 
            // tbProb4
            // 
            this.tbProb4.DecimalPlaces = 2;
            this.tbProb4.Location = new System.Drawing.Point(247, 480);
            this.tbProb4.Name = "tbProb4";
            this.tbProb4.Size = new System.Drawing.Size(120, 26);
            this.tbProb4.TabIndex = 20;
            this.tbProb4.Value = new decimal(new int[] {
            34,
            0,
            0,
            131072});
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(247, 593);
            this.tbNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(120, 26);
            this.tbNum.TabIndex = 21;
            this.tbNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tbProb5
            // 
            this.tbProb5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProb5.Location = new System.Drawing.Point(247, 518);
            this.tbProb5.Multiline = true;
            this.tbProb5.Name = "tbProb5";
            this.tbProb5.Size = new System.Drawing.Size(120, 19);
            this.tbProb5.TabIndex = 22;
            this.tbProb5.Text = "auto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 723);
            this.Controls.Add(this.tbProb5);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.tbProb4);
            this.Controls.Add(this.tbProb3);
            this.Controls.Add(this.tbProb2);
            this.Controls.Add(this.tbProb1);
            this.Controls.Add(this.btAnswer3);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.lbProb5);
            this.Controls.Add(this.lbProb4);
            this.Controls.Add(this.lbProb3);
            this.Controls.Add(this.lbProb2);
            this.Controls.Add(this.lbProb1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb8_2);
            this.Controls.Add(this.lb8_1);
            this.Controls.Add(this.tbQuestion2);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.lbAnswer2);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.btAnswer2);
            this.Controls.Add(this.btAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnswer;
        private System.Windows.Forms.Button btAnswer2;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Label lbAnswer2;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbQuestion2;
        private System.Windows.Forms.Label lb8_1;
        private System.Windows.Forms.Label lb8_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbProb1;
        private System.Windows.Forms.Label lbProb2;
        private System.Windows.Forms.Label lbProb3;
        private System.Windows.Forms.Label lbProb4;
        private System.Windows.Forms.Label lbProb5;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Button btAnswer3;
        private System.Windows.Forms.NumericUpDown tbProb1;
        private System.Windows.Forms.NumericUpDown tbProb2;
        private System.Windows.Forms.NumericUpDown tbProb3;
        private System.Windows.Forms.NumericUpDown tbProb4;
        private System.Windows.Forms.NumericUpDown tbNum;
        private System.Windows.Forms.TextBox tbProb5;
    }
}

