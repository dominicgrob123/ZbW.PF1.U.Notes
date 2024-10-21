using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01
{
    public partial class Uebung2 : Form
    {
        public Uebung2()
        {
            InitializeComponent();
        }

        public string _globalX = "";



        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            NumLetterCounter.Value = TxtInput.Text.Length;
            _globalX = TxtInput.Text.ToLower();

        }

        private void CmdOutput_Click(object sender, EventArgs e)
        {
            LblShow.Text = $"Anzahl Buchstaben sind: {TxtInput.Text.Length}";
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            LblShow.Text = string.Empty;
            TxtInput.Text = string.Empty ;
        }
    }
}
