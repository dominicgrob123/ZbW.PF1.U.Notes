using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB04.Hund
{
    public partial class DogView : Form
    {
        public DogView()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var name = TxtName.Text;
            var age = NuDAge.Value;

            Hund hund = new Hund();
            hund.Name = name;
            hund.Age  = Convert.ToInt32(age);

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            var nameBall = TxtNameBall.Text;
            Ball ball1 = new Ball(nameBall);
            
            var hund1 = new Hund();
            var resultat = hund1.Spiele(ball1);
            MessageBox.Show(resultat);
        }
    }
}
