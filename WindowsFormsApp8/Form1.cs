using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		double p = 0.5;

		double[] pred = {0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1};
		string[] answer = {
			"Вряд ли",
			"Маловероятно",
			"Перспективы не радужные",
			"Скорее нет, чем да",
			"Пока не ясно, попробуй еще раз",
			"Скорее да, чем нет",
			"Риск есть, но он невелик, дерзай!",
			"Весьма вероятно",
			"Вполне возможно",
			"Я уверен в этом!"
};

        double[] prob;
        double[] freq;
        int num;
        int[] stat;
        double r;
		Random rand = new Random();
		private void lb8_2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            lbAnswer.Text.Trim();
            if (tbQuestion.Text != String.Empty)
            {
                r = rand.NextDouble();
                if (r < p) lbAnswer.Text = "Yes!";
                else lbAnswer.Text = "No!";
            }
            else lbAnswer.Text = "Сначала задайте вопрос.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbAnswer2.Text.Trim();
            double tmp = 0;
            if (tbQuestion2.Text != String.Empty)
            {
                for (int i = 0; i < 12; i++)
                {
                    tmp = pred[i];
                    r = rand.NextDouble();
                    if (r < tmp)
                    {
                        lbAnswer2.Text = answer[i];
                        break;
                    }
                }
            }
            else lbAnswer2.Text = "Сначала задайте вопрос.";
        }

        private void btAnswer3_Click(object sender, EventArgs e)
        {
            prob = new double[5];
            stat = new int[5];
            freq = new double[5];
            num = (int)tbNum.Value;
            prob[0] = (double)tbProb1.Value;
            prob[1] = (double)tbProb2.Value;
            prob[2] = (double)tbProb3.Value;
            prob[3] = (double)tbProb4.Value;
            prob[4] = 1;

            for (int i = 0; i < 4; i++) prob[4] -= prob[i];
            tbProb5.Text = prob[4].ToString();

            for (int i = 0; i < num; i++)
            {
                r = rand.NextDouble();
                double sum = 0;
                for (int k = 0; k < 5; k++)
                {
                    sum += prob[k];
                    if (r <= sum)
                    {
                        stat[k]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < 5; i++) freq[i] = stat[i] / (double)num;
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < 5; i++) chart1.Series[0].Points.AddXY(i + 1, freq[i]);
        }
    }
}
