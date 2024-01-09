using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB06.StaticAufgabe
{
    public class Person
    {
        public static int Counter { get; set; }

        public Person() {
            Counter++;
        }
    }
}
