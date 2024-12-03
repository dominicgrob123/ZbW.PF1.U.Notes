using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB06
{
    internal class BicycleV2
    {

        private Color _color;
        private int _weight;

        public BicycleV2(int weight, Color color)
        {
            Color = color;
        }

        public BicycleV2() : this(20, Color.Blue)
        {
        }

        public string Print()
        {
            return $"Die Farbe ist: {Color} und das Gewicht ist: {_weight}!!";
        }

        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value >= 0)
                {
                    _weight = value;
                }
            }
        }

        public Color Color { get; set; }
    }
}

