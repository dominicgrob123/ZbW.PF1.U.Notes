namespace MB06
{
    public class Bicycle
    {
        private string _color;
        private int _weight;

        public Bicycle(int weight, string color)
        {
            Color = color;
            SetWeight(weight);
        }

        public Bicycle() : this (20, "Schwarz")
        {
           // Color = "sdfdsf";
        }

        public void SetWeight(int weight)
        {
            if (weight >= 0)
            {
                _weight = weight;
            }
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }


        public string Print()
        {
            return $"Die Farbe ist: {Color} und das Gewicht ist: {_weight}!!";
        }

        public int Weight
        {
            get { return _weight; }
            set { 
                if(value >= 0)
                {
                    _weight = value;
                }
            }
        }

        public string Color { get; set; }
    }
}
