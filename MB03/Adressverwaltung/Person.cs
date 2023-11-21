using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace MB03.Adressverwaltung
{

    public class Person
    {
        //Klassenveriabeln
        private string _name;
        private int _age;

        //Konstruktor
        public Person(string name, int age) {
            Name = name;
            Age =age;
        }

        public Person(string name)
        {
            Name = name;
            Age =12;
        }

        //Konstruktor
        public Person() : this ("nix", -33)
        {
           
        }

        //Methode mit Rückgabewert
        public string Ausgabe()
        {
            return Name + ": " + Age + "\r\n";
        }

        public string Ausgabe(string v)
        {
            return v + ": " + Age + "\r\n";
        }

        //Property
        public string Name
        {
            get {
                
                return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _name= "undefiniert";
                }
                else
                {
                    _name = value;
                }

                //andere Schreibweise eines if
                //_name = string.IsNullOrEmpty(value) ? "undefiniert" : value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
            }
        }
    }
}