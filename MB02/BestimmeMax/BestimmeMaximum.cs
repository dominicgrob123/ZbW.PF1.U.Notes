using System;
using System.Windows.Forms;

namespace MB02.BestimmeMax
{
    public partial class BestimmeMaximum : Form
    {


        public BestimmeMaximum()
        {
            InitializeComponent();
        }

        public int GetMax(int num1, int num2)
        {
            var result = 0;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        private void CmdMax1_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(TxtValue1.Text);
            var num2 = Convert.ToInt32(TxtValue2.Text);
            var maxValue = GetMax(num1, num2);

            LblMax.Text = maxValue.ToString();
        }


        private void CmdMax2_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(TxtValue3.Text);
            var num2 = Convert.ToInt32(TxtValue2.Text);
            var result = 0;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            LblMax.Text = result.ToString();
        }

        private void CmdMax3_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(TxtValue3.Text);
            var num2 = Convert.ToInt32(TxtValue1.Text);
            var result = 0;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            LblMax.Text = result.ToString();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            var arr = new int[3];
            arr[0] = Convert.ToInt32(TxtValue1.Text);
            arr[1] = Convert.ToInt32(TxtValue2.Text);
            arr[2] = Convert.ToInt32(TxtValue3.Text);

            var result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dix = new Dictionary<string, double>();
            var zahl = Convert.ToInt32(TxtValue1.Text);

            dix.Add("Franz", zahl);
            dix.Add("Fritz", zahl);

            foreach (var element in dix) {

                var a = element.Key + element.Value;
            }

        }
    }
}