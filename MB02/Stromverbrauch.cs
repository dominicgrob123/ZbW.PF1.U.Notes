namespace MB02
{
    public partial class Stromverbrauch : Form
    {
        public Stromverbrauch()
        {
            InitializeComponent();

            var a = (int)Day.Monday;

        }

        private void TmrIntervall_Tick(object sender, EventArgs e)
        {
            if (RadTuesday.Checked)
            {
                RadTuesday.Checked = false;
            }
            else
            {
                RadTuesday.Checked = true;
            }


        }

        private void Checkbox_Changed(object sender, EventArgs e)
        {

            if (ChkMonday.Checked)
            {
                TmrIntervall.Enabled = true;
            }
            else
            {
                TmrIntervall.Enabled = false;
            }
        }
    }
}
