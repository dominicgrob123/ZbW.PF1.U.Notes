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
    public partial class A6_2_2 : Form
    {
        public A6_2_2()
        {
            InitializeComponent();
        }

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {
            TxtBi.Text = "";
            int value = Convert.ToInt32(NumZahl.Value);
            while (value != 0)
            {
                TxtBi.Text = (value % 2) + TxtBi.Text;
                value /= 2;
            }
        }
    }
}
