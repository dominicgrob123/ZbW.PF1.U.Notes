using System;
using System.Windows.Forms;

namespace MB03.Adressverwaltung
{
    public partial class AdressverwaltungView : Form
    {
        public AdressverwaltungView()
        {
            InitializeComponent();
        }

        private void CmdCreatePerson_Click(object sender, EventArgs e)
        {
            //Namespace Demo
            var p = new MB03.Person();

            //Variante 1
            for (int i = 0; i < 1; i++)
            {
               Person person = new Person();
               person.Age = -1;
               TxtOutputArea.Text += person.Ausgabe();

            }

            //Zusatz
            Person l = new Person("Larissa", 31);
            TxtOutputArea.Text += l.Ausgabe();

            Person c = new Person();
            c.Name = "Cyrill";
            c.Age = 35;
            TxtOutputArea.Text += c.Ausgabe() ;


            //Zusatz 2
            var persons = new List<Person>() { new Person() { Name ="Mara", Age =25 } };

        }

    }
}
