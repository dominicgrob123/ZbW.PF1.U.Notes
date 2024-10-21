namespace MB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdHello_Click_1(object sender, EventArgs e)
        {
            // Hier wird "Hallo" dem LblShow.Text zugewiesen
            LblShow.Text = "Hallo";
        }

        private void CmdEnd_Click(object sender, EventArgs e)
        {
            LblShow.Text = "End";
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumNummer_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
