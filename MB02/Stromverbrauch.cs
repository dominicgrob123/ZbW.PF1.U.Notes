namespace MB02
{
    public partial class Stromverbrauch : Form
    {
        public Stromverbrauch()
        {
            InitializeComponent();
            // int a =  MyFirstEnumColor.Blue;

            int num1 = 10;
            int resultat = num1 + 1;

            //andere Schreibweise => resultat = resultat + num1;
            resultat += num1;

            double resultat1 = 3 / (double)4;


        }

        public void Test()
        {


        }

        private void TmrTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Changed(object sender, EventArgs e)
        {
            RadMonday.Checked
        }

        private void RadMonday_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
