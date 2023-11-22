using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A_1
{
    public partial class A4_1_4 : Form
    {

        public A4_1_4()
        {
            InitializeComponent();
        }

        private void CmdCheck_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TxtValue1.Text);
            int num2 = Convert.ToInt32(TxtValue2.Text);

            for (int i = 0; i < 5; i++)
            {
                LblResult.Text += i.ToString() + ";";
            }
             
            var count = 0;
            while(count < 5)
            {
                LblResult.Text += count.ToString() + ";";
                count++;
            }
            var c = count;
            count = 10;

            do
            {
                LblResult.Text += count.ToString() + ";";
                count++;
            }
            while (count < 11);


            if (num1 > 0 && num2 > 0)
            {
                if (num1 == num2)
                {
                    LblResult.Text = "Ist gleich gross";
                }
                else if (num1 > num2)
                {
                    LblResult.Text = "A ist grösser";
                }
                else
                {
                    LblResult.Text = "B ist grösser";
                }
            }
            else
            {
                MessageBox.Show("Die Zahl muss grösser 0 sein");
            }


        }
    }
}
