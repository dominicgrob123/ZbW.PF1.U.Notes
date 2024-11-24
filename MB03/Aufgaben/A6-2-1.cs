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
    public partial class A6_2_1 : Form
    {
        public A6_2_1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdRandomZahl_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int zufallszahl = r.Next(10, 10000);
            TxtRandomZahl.Text = Convert.ToString(zufallszahl);
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(TxtRandomZahl.Text) != 0)
            {            double zahl = Convert.ToDouble(TxtRandomZahl.Text);
                for (int i = 0; zahl > 1; i++)
                {
                    double zahlres = zahl / 2;
                    TxtCalc.Text += zahl + " / 2 = " + zahlres + Environment.NewLine;
                    zahl = zahlres;
                    TxtLoops.Text = Convert.ToString(i);
                }
                }
            else
            {
                MessageBox.Show("Bitte generieren Sie eine Zufallszahl!");
            }
        }
    }
}
