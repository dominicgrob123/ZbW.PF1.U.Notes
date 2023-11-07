using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MB01.A8_2
{
    public partial class A8_2_1 : Form
    {
        public A8_2_1()
        {
            InitializeComponent();
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {
            sbyte value1 = Convert.ToSByte(TxtValue1.Text);
            sbyte value2 = Convert.ToSByte(TxtValue2.Text);
            int result = 0;

            if (RadbAdd.Checked)
            {
                result = value1 + value2;
            }
            else if(RadbDiv.Checked)
            {
                result = (int)value1 / value2;
            }

            TxtResult.Text = result.ToString();
        }

        private void TxtValue2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}