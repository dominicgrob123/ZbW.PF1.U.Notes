using SystemColor = System.Drawing.Color;
using MyColor = MB06.Color;

namespace MB06
{
    public partial class Garage : Form
    {

        public Garage()
        {
            InitializeComponent();
        }

        private void CmdCreate_Click(object sender, EventArgs e)
        {
            BicycleV2 bicycleV2 = new BicycleV2();
            bicycleV2.Weight = Convert.ToInt32(NudWeight.Value);
            if (TxtColor.Text.Equals("Blau"))
            {
                bicycleV2.Color = MyColor.Blue;
                CmdCreate.BackColor = SystemColor.Blue;
            }


            Bicycle b1 = new Bicycle(Convert.ToInt32(NudWeight.Value), TxtColor.Text);
            //b1.SetColor(TxtColor.Text);
            //b1.Weight = Convert.ToInt32(NudWeight.Value);
            //b1.Color = TxtColor.Text;

            var color = b1.GetColor();
            string value = b1.Print();
            LblShow.Text = value;

            Bicycle b2 = new Bicycle();
            LblShow.Text = b2.Print();

        }
    }
}
