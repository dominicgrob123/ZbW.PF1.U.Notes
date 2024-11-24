using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB03.Aufgaben
{
    public partial class A6_2_4 : Form
    {
        public A6_2_4()
        {
            InitializeComponent();
        }
        int number1 = 0;
        int number2 = 0;
        int result = 0;

        private void CmdKgV_Click(object sender, EventArgs e)
        {
            if (Num1.Value == 0 || Num2.Value == 0)
            {
                MessageBox.Show("One or both of the entered numbers are 0");
            }
            else if (Num1.Value == Num2.Value)
            {
                MessageBox.Show("Both of these numbers are the same");
            }
            else
            {
                if (Num2.Value < Num1.Value)
                {
                    number1 = Convert.ToInt32(Num1.Value);
                    number2 = Convert.ToInt32(Num2.Value);
                }
                else
                {
                    number2 = Convert.ToInt32(Num1.Value);
                    number1 = Convert.ToInt32(Num2.Value);
                }
                int counter = 2;
                while(true)
                {
                    result = number2 * counter;
                    if (result % number1 == 0)
                    {
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                    }
                TxtResultat.Text = Convert.ToString(result);
            }
        }
    }
}
