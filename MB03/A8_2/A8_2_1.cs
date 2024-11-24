using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MB03.A8_2
{
    public partial class A8_2_1 : Form
    {
        public A8_2_1()
        {
            InitializeComponent();
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadbAdd.Checked == true)
                {
                    TxtResult.Text = Convert.ToString(Convert.ToSByte(TxtValue1.Text) + Convert.ToSByte(TxtValue2.Text));
                }
                else if (RadbSub.Checked == true) 
                {
                    TxtResult.Text = Convert.ToString(Convert.ToSByte(TxtValue1.Text) - Convert.ToSByte(TxtValue2.Text));
                }
                else if(RadbMul.Checked == true)
                {
                    TxtResult.Text = Convert.ToString(Convert.ToSByte(TxtValue1.Text) * Convert.ToSByte(TxtValue2.Text));
                }
                else if (RadbDiv.Checked == true)
                {
                    TxtResult.Text = Convert.ToString(Convert.ToSByte(TxtValue1.Text) / Convert.ToSByte(TxtValue2.Text));
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Division durch 0 nicht erlaubt!", "Fehler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Please only use numbers between -128 and 127", "Fehler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Zahlen sind zu gross. Maximal:" + sbyte.MaxValue +
                    ", Minimal: " + sbyte.MinValue, "Fehler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}