using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB06.StaticAufgabe
{
    public partial class PersonView : Form
    {
        public PersonView()
        {
            InitializeComponent();
        }

        private void BtnCreatePerson_Click(object sender, EventArgs e)
        {
            var p = new Person();
            LblShowCounter.Text = Person.Counter.ToString();
        }
    }
}
