namespace MB04.Hund
{
    internal class Hund
    {
        private int _age;

        public Hund(string name, int age) {
            Name = name;
            Age = age;
        }

        public Hund()
        {

        }

        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                //Variante 1:
                if (value < 0 || value > 35)
                {
                    _age = -1;
                }
                else
                {
                    _age = value;
                }

                //Variante 2: 
                if (value < 0 || value > 35)
                {
                    throw new Exception("Nur zahlen 0-35 möglich");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string Spiele(Ball b)
        {
            var nameB = b.Name;
            return nameB;
        }

    }
}
